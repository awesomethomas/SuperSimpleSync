using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Common;
using System.Threading;

namespace SuperSimpleSync
{
    class Program
    {
        // Darren Kent - Version History
        private DirectoryInfo LocalStorage = new System.IO.DirectoryInfo(@"U:\temp\TestSyncDir");
        private Guid accountId = Guid.Parse("{FC948776-0FA5-4ABC-A5F3-E8AC3115DFCA}");
        SyncServer.Sync _sync = new SyncServer.Sync();

        [STAThreadAttribute]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.Run(new GUI());
        }

        public void SetLocalStorage(String tmp)
        {
            DirectoryInfo newDir = new System.IO.DirectoryInfo(tmp);
            LocalStorage = newDir;
        }

        public DirectoryInfo GetLS()
        {
            return LocalStorage;
        }

        public void SyncWithServer()
        {
            _sync.Timeout = 600000;
            SyncDir local = Util.AuditTree(LocalStorage);
            SyncDir server = Util.FromXml<SyncDir>(_sync.GetServerSyncDir(accountId, local.Name));
            Util.RebuildParentRelationships(server);
            ResolveDifferencesWithLocal(server.GetNewerFiles(local), LocalStorage);
            ResolveDifferencesWithServer(local.GetNewerFiles(server), LocalStorage);
        }

        private void ResolveDifferencesWithServer(SyncDir diff, DirectoryInfo dir)
        {
            if (diff.Files != null)
            {
                foreach (SyncFile f in diff.Files)
                {
                    byte[] buffer = File.ReadAllBytes(dir.FullName + Path.DirectorySeparatorChar + f.Name);
                    _sync.SendFileToServer(accountId, f.BuildPath(), buffer);
                    _sync.appendLine(accountId, "Server->Local: " + f.Name + "    " + f.DateCreated + "    " + f.DateModified + "    " + f.BuildPath());
                }
            }
            if (diff.Directories != null)
            {
                foreach (SyncDir d in diff.Directories)
                {
                    DirectoryInfo sub = new DirectoryInfo(dir.FullName + Path.DirectorySeparatorChar + d.Name);
                    if (!sub.Exists)
                        sub.Create();
                    ResolveDifferencesWithServer(d, sub);
                }
            }
        }


        private void ResolveDifferencesWithLocal(SyncDir diff, DirectoryInfo dir)
        {
            if (diff.Files != null)
            {
                foreach (SyncFile f in diff.Files)
                {
                    byte[] buffer = _sync.GetFileFromServer(accountId, f.BuildPath());
                    File.WriteAllBytes(dir.FullName + Path.DirectorySeparatorChar + f.Name, buffer);
                    _sync.appendLine(accountId, "Local->Server: " + f.Name + "    "+f.DateCreated + "    " + f.DateModified + "    " + f.BuildPath());
                }
            }
            if (diff.Directories != null)
            {
                foreach (SyncDir d in diff.Directories)
                {
                    DirectoryInfo sub = new DirectoryInfo(dir.FullName + Path.DirectorySeparatorChar + d.Name);
                    if (!sub.Exists)
                        sub.Create();
                    ResolveDifferencesWithLocal(d, sub);
                }
            }
        }
    }
}
