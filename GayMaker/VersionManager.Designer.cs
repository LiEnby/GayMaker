namespace GayMaker
{
    partial class versionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(versionManager));
            this.downloadList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadVersion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.installedList = new System.Windows.Forms.ListBox();
            this.deleteVersion = new System.Windows.Forms.Button();
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadList
            // 
            this.downloadList.FormattingEnabled = true;
            this.downloadList.Location = new System.Drawing.Point(12, 25);
            this.downloadList.Name = "downloadList";
            this.downloadList.Size = new System.Drawing.Size(458, 186);
            this.downloadList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Downloads:";
            // 
            // downloadVersion
            // 
            this.downloadVersion.Location = new System.Drawing.Point(12, 217);
            this.downloadVersion.Name = "downloadVersion";
            this.downloadVersion.Size = new System.Drawing.Size(458, 23);
            this.downloadVersion.TabIndex = 4;
            this.downloadVersion.Text = "Download This Version";
            this.downloadVersion.UseVisualStyleBackColor = true;
            this.downloadVersion.Click += new System.EventHandler(this.downloadVersion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Allready Downloaded:";
            // 
            // installedList
            // 
            this.installedList.FormattingEnabled = true;
            this.installedList.Items.AddRange(new object[] {
            "1.4.9999"});
            this.installedList.Location = new System.Drawing.Point(15, 304);
            this.installedList.Name = "installedList";
            this.installedList.Size = new System.Drawing.Size(458, 199);
            this.installedList.TabIndex = 6;
            // 
            // deleteVersion
            // 
            this.deleteVersion.Location = new System.Drawing.Point(12, 509);
            this.deleteVersion.Name = "deleteVersion";
            this.deleteVersion.Size = new System.Drawing.Size(458, 23);
            this.deleteVersion.TabIndex = 7;
            this.deleteVersion.Text = "Delete This Version";
            this.deleteVersion.UseVisualStyleBackColor = true;
            this.deleteVersion.Click += new System.EventHandler(this.deleteVersion_Click);
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Location = new System.Drawing.Point(12, 259);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(461, 23);
            this.DownloadProgress.TabIndex = 8;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(12, 243);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(458, 13);
            this.Status.TabIndex = 9;
            this.Status.Text = "Waiting";
            // 
            // versionManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(485, 544);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.DownloadProgress);
            this.Controls.Add(this.deleteVersion);
            this.Controls.Add(this.installedList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downloadVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downloadList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "versionManager";
            this.ShowInTaskbar = false;
            this.Text = "GameMaker Studio Version Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.versionManager_FormClosing);
            this.Load += new System.EventHandler(this.versionManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox downloadList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button downloadVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox installedList;
        private System.Windows.Forms.Button deleteVersion;
        private System.Windows.Forms.ProgressBar DownloadProgress;
        private System.Windows.Forms.Label Status;
    }
}