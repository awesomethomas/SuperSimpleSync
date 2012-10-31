namespace SuperSimpleSync
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolderClient = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root Directory to Sync with Server:";
            // 
            // txtFolderClient
            // 
            this.txtFolderClient.Location = new System.Drawing.Point(16, 42);
            this.txtFolderClient.Name = "txtFolderClient";
            this.txtFolderClient.Size = new System.Drawing.Size(238, 20);
            this.txtFolderClient.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(260, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(16, 83);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(107, 23);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "Sync With Server";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(16, 214);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(321, 72);
            this.txtOutput.TabIndex = 4;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 298);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolderClient);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.Text = "SuperSimpleSync Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TextBox txtFolderClient;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.TextBox txtOutput;
    }
}