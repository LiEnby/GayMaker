namespace GayMaker
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.panel1 = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.SDKDir = new System.Windows.Forms.TextBox();
            this.unOfficalSDK = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.officalSDK = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IndexedColor = new System.Windows.Forms.CheckBox();
            this.SaveLast = new System.Windows.Forms.CheckBox();
            this.Updates = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VcVarsBatDir = new System.Windows.Forms.TextBox();
            this.browseVCVARS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.browseVCVARS);
            this.panel1.Controls.Add(this.VcVarsBatDir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.pathLabel);
            this.panel1.Controls.Add(this.SDKDir);
            this.panel1.Controls.Add(this.unOfficalSDK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.officalSDK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 187);
            this.panel1.TabIndex = 1;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(210, 110);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(7, 97);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(76, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "SDK Location:";
            // 
            // SDKDir
            // 
            this.SDKDir.Location = new System.Drawing.Point(10, 113);
            this.SDKDir.Name = "SDKDir";
            this.SDKDir.Size = new System.Drawing.Size(193, 20);
            this.SDKDir.TabIndex = 2;
            // 
            // unOfficalSDK
            // 
            this.unOfficalSDK.AutoSize = true;
            this.unOfficalSDK.Enabled = false;
            this.unOfficalSDK.Location = new System.Drawing.Point(6, 68);
            this.unOfficalSDK.Name = "unOfficalSDK";
            this.unOfficalSDK.Size = new System.Drawing.Size(109, 17);
            this.unOfficalSDK.TabIndex = 2;
            this.unOfficalSDK.Text = "UNOFFICAL SDK";
            this.unOfficalSDK.UseVisualStyleBackColor = true;
            this.unOfficalSDK.CheckedChanged += new System.EventHandler(this.unOfficalSDK_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SDK Type:";
            // 
            // officalSDK
            // 
            this.officalSDK.AutoSize = true;
            this.officalSDK.Checked = true;
            this.officalSDK.Location = new System.Drawing.Point(6, 45);
            this.officalSDK.Name = "officalSDK";
            this.officalSDK.Size = new System.Drawing.Size(93, 17);
            this.officalSDK.TabIndex = 3;
            this.officalSDK.TabStop = true;
            this.officalSDK.Text = "OFFICAL SDK";
            this.officalSDK.UseVisualStyleBackColor = true;
            this.officalSDK.CheckedChanged += new System.EventHandler(this.officalSDK_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "YYC Options:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.IndexedColor);
            this.panel2.Controls.Add(this.SaveLast);
            this.panel2.Controls.Add(this.Updates);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 107);
            this.panel2.TabIndex = 2;
            // 
            // IndexedColor
            // 
            this.IndexedColor.AutoSize = true;
            this.IndexedColor.Checked = true;
            this.IndexedColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IndexedColor.Location = new System.Drawing.Point(6, 71);
            this.IndexedColor.Name = "IndexedColor";
            this.IndexedColor.Size = new System.Drawing.Size(176, 17);
            this.IndexedColor.TabIndex = 3;
            this.IndexedColor.Text = "Convert PNG\'s to Indexed Color";
            this.IndexedColor.UseVisualStyleBackColor = true;
            // 
            // SaveLast
            // 
            this.SaveLast.AutoSize = true;
            this.SaveLast.Checked = true;
            this.SaveLast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveLast.Location = new System.Drawing.Point(6, 48);
            this.SaveLast.Name = "SaveLast";
            this.SaveLast.Size = new System.Drawing.Size(173, 17);
            this.SaveLast.TabIndex = 2;
            this.SaveLast.Text = "Save last used Project Settings";
            this.SaveLast.UseVisualStyleBackColor = true;
            // 
            // Updates
            // 
            this.Updates.AutoSize = true;
            this.Updates.Checked = true;
            this.Updates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Updates.Location = new System.Drawing.Point(6, 25);
            this.Updates.Name = "Updates";
            this.Updates.Size = new System.Drawing.Size(115, 17);
            this.Updates.TabIndex = 1;
            this.Updates.Text = "Check for Updates";
            this.Updates.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "GayMaker Options:";
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(12, 318);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(296, 23);
            this.SaveChanges.TabIndex = 3;
            this.SaveChanges.Text = "Save Preferences";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "vcvars32.bat Location:";
            // 
            // VcVarsBatDir
            // 
            this.VcVarsBatDir.Location = new System.Drawing.Point(10, 152);
            this.VcVarsBatDir.Name = "VcVarsBatDir";
            this.VcVarsBatDir.Size = new System.Drawing.Size(193, 20);
            this.VcVarsBatDir.TabIndex = 6;
            // 
            // browseVCVARS
            // 
            this.browseVCVARS.Location = new System.Drawing.Point(210, 149);
            this.browseVCVARS.Name = "browseVCVARS";
            this.browseVCVARS.Size = new System.Drawing.Size(75, 23);
            this.browseVCVARS.TabIndex = 7;
            this.browseVCVARS.Text = "Browse";
            this.browseVCVARS.UseVisualStyleBackColor = true;
            this.browseVCVARS.Click += new System.EventHandler(this.browseVCVARS_Click);
            // 
            // Preferences
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(314, 353);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.ShowInTaskbar = false;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton officalSDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox SDKDir;
        private System.Windows.Forms.RadioButton unOfficalSDK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox SaveLast;
        private System.Windows.Forms.CheckBox Updates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.CheckBox IndexedColor;
        private System.Windows.Forms.Button browseVCVARS;
        private System.Windows.Forms.TextBox VcVarsBatDir;
        private System.Windows.Forms.Label label4;
    }
}