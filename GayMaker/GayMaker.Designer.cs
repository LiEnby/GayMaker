namespace GayMaker
{
    partial class GayMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GayMaker));
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectPath = new System.Windows.Forms.TextBox();
            this.BrowseProject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IconPath = new System.Windows.Forms.TextBox();
            this.BrowseIcon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PicPath = new System.Windows.Forms.TextBox();
            this.BrowsePic = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GameSettings = new System.Windows.Forms.Panel();
            this.YYCEnabled = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DownloadMoreRAM = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GMVersion = new System.Windows.Forms.ComboBox();
            this.LeftGate = new System.Windows.Forms.CheckBox();
            this.GdbCategory = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GlobalGameSettings = new System.Windows.Forms.Label();
            this.TitleIdBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.BrowseGate = new System.Windows.Forms.Button();
            this.GatePath = new System.Windows.Forms.TextBox();
            this.StartupLabel = new System.Windows.Forms.Label();
            this.BrowsePath = new System.Windows.Forms.Button();
            this.BgPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Compiler = new System.Windows.Forms.PictureBox();
            this.Prefs = new System.Windows.Forms.Label();
            this.selectedHome = new System.Windows.Forms.RadioButton();
            this.selectedLive = new System.Windows.Forms.RadioButton();
            this.SelectedRun = new System.Windows.Forms.RadioButton();
            this.CreateVPK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GmacOut = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.HomePage = new System.Windows.Forms.Panel();
            this.ShortNamePreview = new System.Windows.Forms.Label();
            this.IconBG = new System.Windows.Forms.PictureBox();
            this.Running = new System.Windows.Forms.Panel();
            this.LiveArea = new System.Windows.Forms.Panel();
            this.SFZ = new System.Windows.Forms.PictureBox();
            this.GateBG = new System.Windows.Forms.PictureBox();
            this.LABackground = new System.Windows.Forms.PictureBox();
            this.EE1 = new System.Windows.Forms.PictureBox();
            this.GameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compiler)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBG)).BeginInit();
            this.LiveArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GateBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LABackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EE1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project File (.gmx):";
            // 
            // ProjectPath
            // 
            this.ProjectPath.Location = new System.Drawing.Point(6, 32);
            this.ProjectPath.Name = "ProjectPath";
            this.ProjectPath.ReadOnly = true;
            this.ProjectPath.Size = new System.Drawing.Size(282, 20);
            this.ProjectPath.TabIndex = 2;
            this.ProjectPath.Text = "(none)";
            // 
            // BrowseProject
            // 
            this.BrowseProject.Location = new System.Drawing.Point(291, 29);
            this.BrowseProject.Name = "BrowseProject";
            this.BrowseProject.Size = new System.Drawing.Size(70, 23);
            this.BrowseProject.TabIndex = 3;
            this.BrowseProject.Text = "Browse";
            this.BrowseProject.UseVisualStyleBackColor = true;
            this.BrowseProject.Click += new System.EventHandler(this.BrowseProject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Icon0 (PNG, 128x128):";
            // 
            // IconPath
            // 
            this.IconPath.Location = new System.Drawing.Point(7, 71);
            this.IconPath.Name = "IconPath";
            this.IconPath.ReadOnly = true;
            this.IconPath.Size = new System.Drawing.Size(278, 20);
            this.IconPath.TabIndex = 6;
            this.IconPath.Text = "img\\icon0.png";
            // 
            // BrowseIcon
            // 
            this.BrowseIcon.Location = new System.Drawing.Point(291, 68);
            this.BrowseIcon.Name = "BrowseIcon";
            this.BrowseIcon.Size = new System.Drawing.Size(70, 23);
            this.BrowseIcon.TabIndex = 7;
            this.BrowseIcon.Text = "Browse";
            this.BrowseIcon.UseVisualStyleBackColor = true;
            this.BrowseIcon.Click += new System.EventHandler(this.BrowseIcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pic0 (PNG, 960x544)";
            // 
            // PicPath
            // 
            this.PicPath.Location = new System.Drawing.Point(7, 186);
            this.PicPath.Name = "PicPath";
            this.PicPath.ReadOnly = true;
            this.PicPath.Size = new System.Drawing.Size(278, 20);
            this.PicPath.TabIndex = 9;
            this.PicPath.Text = "img\\pic0.png";
            // 
            // BrowsePic
            // 
            this.BrowsePic.Location = new System.Drawing.Point(291, 186);
            this.BrowsePic.Name = "BrowsePic";
            this.BrowsePic.Size = new System.Drawing.Size(70, 23);
            this.BrowsePic.TabIndex = 10;
            this.BrowsePic.Text = "Browse";
            this.BrowsePic.UseVisualStyleBackColor = true;
            this.BrowsePic.Click += new System.EventHandler(this.BrowsePic_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Preview:";
            // 
            // GameSettings
            // 
            this.GameSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameSettings.Controls.Add(this.YYCEnabled);
            this.GameSettings.Controls.Add(this.label8);
            this.GameSettings.Controls.Add(this.DownloadMoreRAM);
            this.GameSettings.Controls.Add(this.label7);
            this.GameSettings.Controls.Add(this.GMVersion);
            this.GameSettings.Controls.Add(this.LeftGate);
            this.GameSettings.Controls.Add(this.GdbCategory);
            this.GameSettings.Controls.Add(this.pictureBox3);
            this.GameSettings.Controls.Add(this.GlobalGameSettings);
            this.GameSettings.Controls.Add(this.TitleIdBox);
            this.GameSettings.Controls.Add(this.label6);
            this.GameSettings.Controls.Add(this.AppName);
            this.GameSettings.Controls.Add(this.title);
            this.GameSettings.Controls.Add(this.BrowseGate);
            this.GameSettings.Controls.Add(this.GatePath);
            this.GameSettings.Controls.Add(this.StartupLabel);
            this.GameSettings.Controls.Add(this.BrowsePath);
            this.GameSettings.Controls.Add(this.BgPath);
            this.GameSettings.Controls.Add(this.label4);
            this.GameSettings.Controls.Add(this.PicPath);
            this.GameSettings.Controls.Add(this.label1);
            this.GameSettings.Controls.Add(this.BrowsePic);
            this.GameSettings.Controls.Add(this.ProjectPath);
            this.GameSettings.Controls.Add(this.BrowseProject);
            this.GameSettings.Controls.Add(this.label3);
            this.GameSettings.Controls.Add(this.label2);
            this.GameSettings.Controls.Add(this.BrowseIcon);
            this.GameSettings.Controls.Add(this.IconPath);
            this.GameSettings.Location = new System.Drawing.Point(968, 25);
            this.GameSettings.Name = "GameSettings";
            this.GameSettings.Size = new System.Drawing.Size(368, 354);
            this.GameSettings.TabIndex = 14;
            // 
            // YYCEnabled
            // 
            this.YYCEnabled.AutoSize = true;
            this.YYCEnabled.Location = new System.Drawing.Point(257, 333);
            this.YYCEnabled.Name = "YYCEnabled";
            this.YYCEnabled.Size = new System.Drawing.Size(69, 17);
            this.YYCEnabled.TabIndex = 29;
            this.YYCEnabled.Text = "Use YYC";
            this.YYCEnabled.UseVisualStyleBackColor = true;
            this.YYCEnabled.CheckedChanged += new System.EventHandler(this.YYCEnabled_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "GM Version:";
            // 
            // DownloadMoreRAM
            // 
            this.DownloadMoreRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DownloadMoreRAM.FormattingEnabled = true;
            this.DownloadMoreRAM.Items.AddRange(new object[] {
            "None",
            "+29MiB",
            "+77MiB",
            "+109MiB"});
            this.DownloadMoreRAM.Location = new System.Drawing.Point(257, 226);
            this.DownloadMoreRAM.Name = "DownloadMoreRAM";
            this.DownloadMoreRAM.Size = new System.Drawing.Size(103, 21);
            this.DownloadMoreRAM.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Download More RAM:";
            // 
            // GMVersion
            // 
            this.GMVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GMVersion.FormattingEnabled = true;
            this.GMVersion.Items.AddRange(new object[] {
            "1.4.9999"});
            this.GMVersion.Location = new System.Drawing.Point(257, 306);
            this.GMVersion.MaxDropDownItems = 100;
            this.GMVersion.Name = "GMVersion";
            this.GMVersion.Size = new System.Drawing.Size(103, 21);
            this.GMVersion.TabIndex = 25;
            this.GMVersion.SelectedIndexChanged += new System.EventHandler(this.GMVersion_SelectedIndexChanged);
            // 
            // LeftGate
            // 
            this.LeftGate.AutoSize = true;
            this.LeftGate.Location = new System.Drawing.Point(257, 253);
            this.LeftGate.Name = "LeftGate";
            this.LeftGate.Size = new System.Drawing.Size(74, 17);
            this.LeftGate.TabIndex = 24;
            this.LeftGate.Text = "#LeftGate";
            this.LeftGate.UseVisualStyleBackColor = true;
            this.LeftGate.CheckedChanged += new System.EventHandler(this.LeftGate_CheckedChanged);
            // 
            // GdbCategory
            // 
            this.GdbCategory.AutoSize = true;
            this.GdbCategory.Location = new System.Drawing.Point(257, 270);
            this.GdbCategory.Name = "GdbCategory";
            this.GdbCategory.Size = new System.Drawing.Size(63, 17);
            this.GdbCategory.TabIndex = 23;
            this.GdbCategory.Text = "No SFZ";
            this.GdbCategory.UseVisualStyleBackColor = true;
            this.GdbCategory.CheckedChanged += new System.EventHandler(this.GdbCategory_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(7, 328);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 18);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // GlobalGameSettings
            // 
            this.GlobalGameSettings.AutoSize = true;
            this.GlobalGameSettings.ForeColor = System.Drawing.Color.Black;
            this.GlobalGameSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GlobalGameSettings.Location = new System.Drawing.Point(27, 331);
            this.GlobalGameSettings.Name = "GlobalGameSettings";
            this.GlobalGameSettings.Size = new System.Drawing.Size(109, 13);
            this.GlobalGameSettings.TabIndex = 21;
            this.GlobalGameSettings.Text = "Global Game Settings";
            this.GlobalGameSettings.Click += new System.EventHandler(this.GlobalGameSettings_DoubleClick);
            this.GlobalGameSettings.MouseEnter += new System.EventHandler(this.GlobalGameSettings_Enter);
            this.GlobalGameSettings.MouseLeave += new System.EventHandler(this.GlobalGameSettings_Leave);
            // 
            // TitleIdBox
            // 
            this.TitleIdBox.Location = new System.Drawing.Point(7, 227);
            this.TitleIdBox.MaxLength = 9;
            this.TitleIdBox.Name = "TitleIdBox";
            this.TitleIdBox.Size = new System.Drawing.Size(244, 20);
            this.TitleIdBox.TabIndex = 20;
            this.TitleIdBox.Text = "GMSV00001";
            this.TitleIdBox.TextChanged += new System.EventHandler(this.TitleIdBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "TitleID:";
            // 
            // AppName
            // 
            this.AppName.Location = new System.Drawing.Point(6, 268);
            this.AppName.MaxLength = 40;
            this.AppName.Multiline = true;
            this.AppName.Name = "AppName";
            this.AppName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AppName.Size = new System.Drawing.Size(245, 54);
            this.AppName.TabIndex = 18;
            this.AppName.Text = "GM:S";
            this.AppName.TextChanged += new System.EventHandler(this.AppName_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(4, 252);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(30, 13);
            this.title.TabIndex = 17;
            this.title.Text = "Title:";
            // 
            // BrowseGate
            // 
            this.BrowseGate.Location = new System.Drawing.Point(291, 146);
            this.BrowseGate.Name = "BrowseGate";
            this.BrowseGate.Size = new System.Drawing.Size(70, 23);
            this.BrowseGate.TabIndex = 16;
            this.BrowseGate.Text = "Browse";
            this.BrowseGate.UseVisualStyleBackColor = true;
            this.BrowseGate.Click += new System.EventHandler(this.BrowseGate_Click);
            // 
            // GatePath
            // 
            this.GatePath.Location = new System.Drawing.Point(7, 149);
            this.GatePath.Name = "GatePath";
            this.GatePath.ReadOnly = true;
            this.GatePath.Size = new System.Drawing.Size(278, 20);
            this.GatePath.TabIndex = 15;
            this.GatePath.Text = "img\\startup.png";
            // 
            // StartupLabel
            // 
            this.StartupLabel.AutoSize = true;
            this.StartupLabel.Location = new System.Drawing.Point(4, 133);
            this.StartupLabel.Name = "StartupLabel";
            this.StartupLabel.Size = new System.Drawing.Size(118, 13);
            this.StartupLabel.TabIndex = 14;
            this.StartupLabel.Text = "startup (PNG, 280x158)";
            // 
            // BrowsePath
            // 
            this.BrowsePath.Location = new System.Drawing.Point(291, 107);
            this.BrowsePath.Name = "BrowsePath";
            this.BrowsePath.Size = new System.Drawing.Size(70, 23);
            this.BrowsePath.TabIndex = 13;
            this.BrowsePath.Text = "Browse";
            this.BrowsePath.UseVisualStyleBackColor = true;
            this.BrowsePath.Click += new System.EventHandler(this.BrowsePath_Click);
            // 
            // BgPath
            // 
            this.BgPath.Location = new System.Drawing.Point(7, 110);
            this.BgPath.Name = "BgPath";
            this.BgPath.ReadOnly = true;
            this.BgPath.Size = new System.Drawing.Size(278, 20);
            this.BgPath.TabIndex = 12;
            this.BgPath.Text = "img\\bg0.png";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bg0 (PNG, 840x500):";
            // 
            // Compiler
            // 
            this.Compiler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Compiler.BackgroundImage")));
            this.Compiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Compiler.Image = ((System.Drawing.Image)(resources.GetObject("Compiler.Image")));
            this.Compiler.Location = new System.Drawing.Point(1249, 4);
            this.Compiler.Name = "Compiler";
            this.Compiler.Size = new System.Drawing.Size(17, 18);
            this.Compiler.TabIndex = 30;
            this.Compiler.TabStop = false;
            // 
            // Prefs
            // 
            this.Prefs.AutoSize = true;
            this.Prefs.Location = new System.Drawing.Point(1266, 7);
            this.Prefs.Name = "Prefs";
            this.Prefs.Size = new System.Drawing.Size(64, 13);
            this.Prefs.TabIndex = 29;
            this.Prefs.Text = "Preferences";
            this.Prefs.Click += new System.EventHandler(this.Prefs_Click);
            this.Prefs.MouseEnter += new System.EventHandler(this.Prefs_MouseEnter);
            this.Prefs.MouseLeave += new System.EventHandler(this.Prefs_MouseLeave);
            // 
            // selectedHome
            // 
            this.selectedHome.AutoSize = true;
            this.selectedHome.Checked = true;
            this.selectedHome.Location = new System.Drawing.Point(54, 7);
            this.selectedHome.Name = "selectedHome";
            this.selectedHome.Size = new System.Drawing.Size(85, 17);
            this.selectedHome.TabIndex = 15;
            this.selectedHome.TabStop = true;
            this.selectedHome.Text = "Homescreen";
            this.selectedHome.UseVisualStyleBackColor = true;
            this.selectedHome.CheckedChanged += new System.EventHandler(this.selectedHome_CheckedChanged);
            // 
            // selectedLive
            // 
            this.selectedLive.AutoSize = true;
            this.selectedLive.Location = new System.Drawing.Point(145, 7);
            this.selectedLive.Name = "selectedLive";
            this.selectedLive.Size = new System.Drawing.Size(66, 17);
            this.selectedLive.TabIndex = 16;
            this.selectedLive.TabStop = true;
            this.selectedLive.Text = "Livearea";
            this.selectedLive.UseVisualStyleBackColor = true;
            this.selectedLive.CheckedChanged += new System.EventHandler(this.selectedLive_CheckedChanged);
            // 
            // SelectedRun
            // 
            this.SelectedRun.AutoSize = true;
            this.SelectedRun.Location = new System.Drawing.Point(217, 7);
            this.SelectedRun.Name = "SelectedRun";
            this.SelectedRun.Size = new System.Drawing.Size(79, 17);
            this.SelectedRun.TabIndex = 17;
            this.SelectedRun.TabStop = true;
            this.SelectedRun.Text = "Bootscreen";
            this.SelectedRun.UseVisualStyleBackColor = true;
            this.SelectedRun.CheckedChanged += new System.EventHandler(this.SelectedRun_CheckedChanged);
            // 
            // CreateVPK
            // 
            this.CreateVPK.Enabled = false;
            this.CreateVPK.Location = new System.Drawing.Point(1067, 544);
            this.CreateVPK.Name = "CreateVPK";
            this.CreateVPK.Size = new System.Drawing.Size(192, 23);
            this.CreateVPK.TabIndex = 18;
            this.CreateVPK.Text = "Make VPK";
            this.CreateVPK.UseVisualStyleBackColor = true;
            this.CreateVPK.Click += new System.EventHandler(this.CreateVPK_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GmacOut);
            this.panel1.Location = new System.Drawing.Point(3, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 107);
            this.panel1.TabIndex = 21;
            // 
            // GmacOut
            // 
            this.GmacOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GmacOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GmacOut.Location = new System.Drawing.Point(0, 0);
            this.GmacOut.Multiline = true;
            this.GmacOut.Name = "GmacOut";
            this.GmacOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GmacOut.Size = new System.Drawing.Size(1329, 103);
            this.GmacOut.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::GayMaker.Properties.Resources.Export;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(1067, 385);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(192, 153);
            this.Logo.TabIndex = 19;
            this.Logo.TabStop = false;
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // HomePage
            // 
            this.HomePage.BackgroundImage = global::GayMaker.Properties.Resources.bg;
            this.HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomePage.Controls.Add(this.ShortNamePreview);
            this.HomePage.Controls.Add(this.IconBG);
            this.HomePage.Location = new System.Drawing.Point(3, 25);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(960, 544);
            this.HomePage.TabIndex = 13;
            // 
            // ShortNamePreview
            // 
            this.ShortNamePreview.BackColor = System.Drawing.Color.Transparent;
            this.ShortNamePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortNamePreview.ForeColor = System.Drawing.Color.AliceBlue;
            this.ShortNamePreview.Location = new System.Drawing.Point(161, 194);
            this.ShortNamePreview.Name = "ShortNamePreview";
            this.ShortNamePreview.Size = new System.Drawing.Size(180, 60);
            this.ShortNamePreview.TabIndex = 1;
            this.ShortNamePreview.Text = "GM:S";
            this.ShortNamePreview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IconBG
            // 
            this.IconBG.BackColor = System.Drawing.Color.Transparent;
            this.IconBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconBG.BackgroundImage")));
            this.IconBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IconBG.Image = ((System.Drawing.Image)(resources.GetObject("IconBG.Image")));
            this.IconBG.Location = new System.Drawing.Point(186, 63);
            this.IconBG.Name = "IconBG";
            this.IconBG.Size = new System.Drawing.Size(128, 128);
            this.IconBG.TabIndex = 0;
            this.IconBG.TabStop = false;
            this.IconBG.Click += new System.EventHandler(this.IconBG_Click);
            // 
            // Running
            // 
            this.Running.BackColor = System.Drawing.Color.Black;
            this.Running.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Running.BackgroundImage")));
            this.Running.Location = new System.Drawing.Point(3, 25);
            this.Running.Name = "Running";
            this.Running.Size = new System.Drawing.Size(960, 544);
            this.Running.TabIndex = 20;
            // 
            // LiveArea
            // 
            this.LiveArea.BackgroundImage = global::GayMaker.Properties.Resources.bg;
            this.LiveArea.Controls.Add(this.SFZ);
            this.LiveArea.Controls.Add(this.GateBG);
            this.LiveArea.Controls.Add(this.LABackground);
            this.LiveArea.Location = new System.Drawing.Point(3, 25);
            this.LiveArea.Name = "LiveArea";
            this.LiveArea.Size = new System.Drawing.Size(960, 544);
            this.LiveArea.TabIndex = 2;
            // 
            // SFZ
            // 
            this.SFZ.BackColor = System.Drawing.Color.Transparent;
            this.SFZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SFZ.Image = global::GayMaker.Properties.Resources.Icons;
            this.SFZ.Location = new System.Drawing.Point(327, 42);
            this.SFZ.Name = "SFZ";
            this.SFZ.Size = new System.Drawing.Size(306, 69);
            this.SFZ.TabIndex = 1;
            this.SFZ.TabStop = false;
            // 
            // GateBG
            // 
            this.GateBG.BackColor = System.Drawing.Color.Black;
            this.GateBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GateBG.BackgroundImage")));
            this.GateBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GateBG.Image = global::GayMaker.Properties.Resources.Gate;
            this.GateBG.Location = new System.Drawing.Point(333, 194);
            this.GateBG.Name = "GateBG";
            this.GateBG.Size = new System.Drawing.Size(290, 166);
            this.GateBG.TabIndex = 2;
            this.GateBG.TabStop = false;
            this.GateBG.Click += new System.EventHandler(this.GateBG_Click);
            // 
            // LABackground
            // 
            this.LABackground.BackColor = System.Drawing.Color.Black;
            this.LABackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LABackground.BackgroundImage")));
            this.LABackground.Location = new System.Drawing.Point(60, 42);
            this.LABackground.Name = "LABackground";
            this.LABackground.Size = new System.Drawing.Size(840, 500);
            this.LABackground.TabIndex = 0;
            this.LABackground.TabStop = false;
            // 
            // EE1
            // 
            this.EE1.BackColor = System.Drawing.Color.Transparent;
            this.EE1.Location = new System.Drawing.Point(1333, 681);
            this.EE1.Name = "EE1";
            this.EE1.Size = new System.Drawing.Size(10, 10);
            this.EE1.TabIndex = 1;
            this.EE1.TabStop = false;
            this.EE1.Click += new System.EventHandler(this.EE1_Click);
            // 
            // GayMaker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 690);
            this.Controls.Add(this.EE1);
            this.Controls.Add(this.Compiler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Prefs);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.CreateVPK);
            this.Controls.Add(this.SelectedRun);
            this.Controls.Add(this.selectedLive);
            this.Controls.Add(this.selectedHome);
            this.Controls.Add(this.GameSettings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LiveArea);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.Running);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1360, 729);
            this.MinimumSize = new System.Drawing.Size(1360, 726);
            this.Name = "GayMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " GayMaker V";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GayMaker_FormClosing);
            this.Load += new System.EventHandler(this.GayMaker_Load);
            this.GameSettings.ResumeLayout(false);
            this.GameSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compiler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.HomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconBG)).EndInit();
            this.LiveArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SFZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GateBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LABackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EE1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectPath;
        private System.Windows.Forms.Button BrowseProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IconPath;
        private System.Windows.Forms.Button BrowseIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PicPath;
        private System.Windows.Forms.Button BrowsePic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel HomePage;
        private System.Windows.Forms.PictureBox IconBG;
        private System.Windows.Forms.Panel GameSettings;
        private System.Windows.Forms.Label ShortNamePreview;
        private System.Windows.Forms.RadioButton selectedHome;
        private System.Windows.Forms.RadioButton selectedLive;
        private System.Windows.Forms.RadioButton SelectedRun;
        private System.Windows.Forms.TextBox BgPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowsePath;
        private System.Windows.Forms.Button BrowseGate;
        private System.Windows.Forms.TextBox GatePath;
        private System.Windows.Forms.Label StartupLabel;
        private System.Windows.Forms.TextBox AppName;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox TitleIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateVPK;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel LiveArea;
        private System.Windows.Forms.PictureBox LABackground;
        private System.Windows.Forms.PictureBox SFZ;
        private System.Windows.Forms.PictureBox GateBG;
        private System.Windows.Forms.Panel Running;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox GmacOut;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label GlobalGameSettings;
        private System.Windows.Forms.CheckBox GdbCategory;
        private System.Windows.Forms.CheckBox LeftGate;
        private System.Windows.Forms.ComboBox GMVersion;
        private System.Windows.Forms.ComboBox DownloadMoreRAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Prefs;
        private System.Windows.Forms.PictureBox Compiler;
        private System.Windows.Forms.CheckBox YYCEnabled;
        private System.Windows.Forms.PictureBox EE1;
    }
}

