using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperSimpleSync
{
    public partial class GUI : Form
    {
        public GUI()
        {

            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtFolderClient.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Program p = new Program();
            DateTime ds = DateTime.Now;

            p.SetLocalStorage(txtFolderClient.Text);
            try
            {
                p.SyncWithServer();
            }
            catch (Exception ex)
            {
                txtOutput.AppendText(ds.ToString() + ": There was an error syncing: " + ex.Message + "\n");
            }
            txtOutput.AppendText(ds.ToString() + ": Sync successful!\n");
        }
    }
}
