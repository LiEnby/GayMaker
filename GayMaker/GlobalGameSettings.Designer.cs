namespace GayMaker
{
    partial class GlobalGameSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalGameSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TexturePageSize = new System.Windows.Forms.ComboBox();
            this.FullScale = new System.Windows.Forms.RadioButton();
            this.AspectRatio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Interporlate = new System.Windows.Forms.CheckBox();
            this.Options = new System.Windows.Forms.Label();
            this.FrontTouchPad = new System.Windows.Forms.CheckBox();
            this.RearTouchPad = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TexturePageSize);
            this.panel1.Controls.Add(this.FullScale);
            this.panel1.Controls.Add(this.AspectRatio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Interporlate);
            this.panel1.Controls.Add(this.Options);
            this.panel1.Controls.Add(this.FrontTouchPad);
            this.panel1.Controls.Add(this.RearTouchPad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 164);
            this.panel1.TabIndex = 0;
            // 
            // TexturePageSize
            // 
            this.TexturePageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TexturePageSize.FormattingEnabled = true;
            this.TexturePageSize.Items.AddRange(new object[] {
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192"});
            this.TexturePageSize.Location = new System.Drawing.Point(124, 130);
            this.TexturePageSize.Name = "TexturePageSize";
            this.TexturePageSize.Size = new System.Drawing.Size(94, 21);
            this.TexturePageSize.TabIndex = 8;
            // 
            // FullScale
            // 
            this.FullScale.AutoSize = true;
            this.FullScale.Location = new System.Drawing.Point(6, 135);
            this.FullScale.Name = "FullScale";
            this.FullScale.Size = new System.Drawing.Size(69, 17);
            this.FullScale.TabIndex = 7;
            this.FullScale.TabStop = true;
            this.FullScale.Text = "Full scale";
            this.FullScale.UseVisualStyleBackColor = true;
            // 
            // AspectRatio
            // 
            this.AspectRatio.AutoSize = true;
            this.AspectRatio.Location = new System.Drawing.Point(6, 112);
            this.AspectRatio.Name = "AspectRatio";
            this.AspectRatio.Size = new System.Drawing.Size(108, 17);
            this.AspectRatio.TabIndex = 6;
            this.AspectRatio.TabStop = true;
            this.AspectRatio.Text = "Keep aspect ratio";
            this.AspectRatio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scaling Options";
            // 
            // Interporlate
            // 
            this.Interporlate.AutoSize = true;
            this.Interporlate.Location = new System.Drawing.Point(4, 21);
            this.Interporlate.Name = "Interporlate";
            this.Interporlate.Size = new System.Drawing.Size(183, 17);
            this.Interporlate.TabIndex = 4;
            this.Interporlate.Text = "Interporlate colors between pixels";
            this.Interporlate.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.Location = new System.Drawing.Point(1, 5);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(43, 13);
            this.Options.TabIndex = 3;
            this.Options.Text = "Options";
            // 
            // FrontTouchPad
            // 
            this.FrontTouchPad.AutoSize = true;
            this.FrontTouchPad.Location = new System.Drawing.Point(3, 67);
            this.FrontTouchPad.Name = "FrontTouchPad";
            this.FrontTouchPad.Size = new System.Drawing.Size(120, 17);
            this.FrontTouchPad.TabIndex = 2;
            this.FrontTouchPad.Text = "Enable Front Touch";
            this.FrontTouchPad.UseVisualStyleBackColor = true;
            // 
            // RearTouchPad
            // 
            this.RearTouchPad.AutoSize = true;
            this.RearTouchPad.Location = new System.Drawing.Point(3, 44);
            this.RearTouchPad.Name = "RearTouchPad";
            this.RearTouchPad.Size = new System.Drawing.Size(119, 17);
            this.RearTouchPad.TabIndex = 0;
            this.RearTouchPad.Text = "Enable Rear Touch";
            this.RearTouchPad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texture Page Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Global Game Settings:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(15, 195);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(235, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save Changes";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // GlobalGameSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(262, 230);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalGameSettings";
            this.ShowInTaskbar = false;
            this.Text = "Global Game Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlobalGameSettings_FormClosing);
            this.Load += new System.EventHandler(this.GlobalGameSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GlobalGameSettings_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox FrontTouchPad;
        private System.Windows.Forms.CheckBox RearTouchPad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.RadioButton FullScale;
        private System.Windows.Forms.RadioButton AspectRatio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Interporlate;
        private System.Windows.Forms.Label Options;
        private System.Windows.Forms.ComboBox TexturePageSize;
    }
}