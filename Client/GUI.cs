using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SuperSimpleSync
{
    public partial class GUI : Form
    {
        //UserSetting user;
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

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void stmExit_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void stmMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void GUI_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.WindowState = FormWindowState.Normal;
                this.Hide();
            }
        }

    }
}
