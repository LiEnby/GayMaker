//IDC that my code is shit:
#pragma warning disable IDE1006 
#pragma warning disable IDE0017 

using GayMaker.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Cache;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;


namespace GayMaker
{
    public partial class GayMaker : Form
    {
        public String CurrentVersion = "1.7.6";
        private string stderr = "";

        private bool HasShaders = false;
        private bool isLoading = false;

        public string ReadSetting(string Setting)
        {
            string Value = "";
            try
            {

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\GayMaker");
                Value = key.GetValue(Setting).ToString();
                key.Close();
            }
            catch (Exception) { return "invalid"; }
            return Value;
        }

        private void EE1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created in 26/01/2019 by SilicaAndPina\nI like to see cute girls die!\n\nCongratulations! you found the easter egg in my software\nI wonder how long before it gets found?\nTweet #GAYMAKER for bragging rights!","Cute Girls Dying");
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        public bool CheckSetting(string Setting)
        {
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\GayMaker");
                if (!ReadBoolean(key.GetValue(Setting).ToString()))
                {
                    key.Close();
                    return true;
                }
                else
                {
                    key.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public GayMaker()
        {
            //Bypass Windows DPI Scaling (See issue #8 to see why its important)
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
            GlobalGameSettings.Enabled = false;
        }
        

        public void reloadVersions()
        {
            GMVersion.Items.Clear();
            GMVersion.Items.Add("1.4.9999");
            try
            {
                foreach (String version in Directory.GetDirectories(@"versions"))
                {
                    GMVersion.Items.Add(Path.GetFileName(version));
                }
            }
            catch (Exception) { };

            GMVersion.Items.Add("Manager");

            GMVersion.SelectedIndex = 0;
        }

        public bool ReadBoolean(string Bool)
        {
            if(Bool == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReloadIcons()
        {
            GateBG.BackgroundImage.Dispose();
            LABackground.BackgroundImage.Dispose();
            IconBG.BackgroundImage.Dispose();
            Running.BackgroundImage.Dispose();

            Image LABG = new Bitmap(BgPath.Text);
            LABackground.BackgroundImage = LABG;
            Image GBG = new Bitmap(GatePath.Text);
            GateBG.BackgroundImage = GBG;
            Image IBG = new Bitmap(IconPath.Text);
            IconBG.BackgroundImage = IBG;
            Image PBG = new Bitmap(PicPath.Text);
            Running.BackgroundImage = PBG;
        }

        public String GetProjectPath() //For GlobalGameSettings
        {
            return ProjectPath.Text;
        }

        private void CheckForUpdates()
        {
            if(CheckSetting("CheckForUpdates"))
            {
                return;
            }

            WebClient wc = new WebClient();

            wc.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            String UpdateString = wc.DownloadString("https://raw.githubusercontent.com/KuromeSan/GayMaker/master/latest.md");
            String[] Data = UpdateString.Split('~');
            if (Data[0] != CurrentVersion)
            {
                DialogResult yesOrNo = MessageBox.Show("An update to GayMaker was found, Version: " + Data[0]+ "\nWant to download it?\n\nThis system software update improves system performance.", "UPDATE FOUND!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(yesOrNo == DialogResult.Yes)
                {
                    Update updateForm = new Update();
                    this.Hide();
                    updateForm.ShowDialog();
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void CopyDir(string source, string target)
        {
            GmacOut.AppendText("Copying Directory: \"" + source + "\" -> \"" + target + "\"\r\n");

            if (!Directory.Exists(target)) Directory.CreateDirectory(target);
            string[] sysEntries = Directory.GetFileSystemEntries(source);

            foreach (string sysEntry in sysEntries)
            {
                string fileName = Path.GetFileName(sysEntry);
                string targetPath = Path.Combine(target, fileName);
                if (Directory.Exists(sysEntry))
                    CopyDir(sysEntry, targetPath);
                else
                {
                    GmacOut.AppendText("Copying \"" + fileName + "\" -> \""+targetPath+"\"\r\n");
                    File.Copy(sysEntry, targetPath, true);
                }
            }
        }

        private void Make8Bit(string Src, string Dst)
        {
            GmacOut.AppendText("Making " + Src + " 8 bit color depth!");
            Bitmap orig = new Bitmap(Src);
            if ((orig.PixelFormat != PixelFormat.Format8bppIndexed) || (!CheckSetting("IndexedColor")))
            {
                Bitmap clone = orig.Clone(new Rectangle(0, 0, orig.Width, orig.Height), PixelFormat.Format8bppIndexed);
                clone.Save(@Dst);
                clone.Dispose();
                GmacOut.AppendText(" Done!\r\n");
            }
            else
            {
                GmacOut.AppendText(" No need!\r\n");
                File.Copy(Src, Dst);
            }
            orig.Dispose();
            

        }

        private bool CompileProject(string Src, string Dst, bool YYC=false)
        {
            string GMVer = GMVersion.SelectedItem.ToString();

            XmlDocument DefaultConfig = new XmlDocument();
            DefaultConfig.Load(Path.GetDirectoryName(ProjectPath.Text) + "\\Configs\\Default.config.gmx");
            XmlNode TP = DefaultConfig.GetElementsByTagName("option_psvita_texture_page")[0]; // Issue #5 Fixed!
            XmlNode SH = DefaultConfig.GetElementsByTagName("option_shortcircuit")[0]; 
            String versionBit = GMVer.Split('.')[2];

            string args;
            if(HasShaders && !YYC)
            {
                args = "/c /m=psvita /config=\"Default\" /tgt=2147483648 /obob=True /obpp=False /obru=True /obes=False /i=3 /cvm /tp="+TP.InnerText+" /mv=1 /iv=0 /rv=0 /bv="+ versionBit +" /sh=" + SH.InnerText +" / psvitasdk=\""+Directory.GetCurrentDirectory()+"\\psvitasdk\" /gn=\"" + AppName.Text + "\" /o=\"" + Dst + "\" \"" + Src + "\"";
            }
            else 
            {
                args = "/c /m=psvita /config=\"Default\" /tgt=2147483648 /obob=True /obpp=False /obru=True /obes=False /i=3 /cvm /tp="+TP.InnerText+ " /mv=1 /iv=0 /rv=0 /bv=" + versionBit +" /sh=" + SH.InnerText +" / gn=\"" + AppName.Text + "\" /o=\"" + Dst + "\" \"" + Src + "\"";
            }
            if(YYC)
            {
                string YYCDIR = "";
                if(GMVer == "1.4.9999")
                {
                    YYCDIR = Directory.GetCurrentDirectory() + "\\YYC";
                }
                else
                {
                    YYCDIR = Directory.GetCurrentDirectory() + "\\versions\\" + GMVer + "\\YYC";
                }
                if(!Directory.Exists(YYCDIR))
                {
                    MessageBox.Show("YYC Files NOT downloaded for Version " + GMVer + " Please re-download it in Version Manager.");
                    this.Enabled = false;
                    versionManager VM = new versionManager();
                    VM.ShowDialog();
                    return false;
                }

                args = "/c /m=llvm-psvita /llvmSource=\"" + YYCDIR + "\"  /config=\"Default\" /tgt=2147483648 /obob=True /obpp=False /obru=True /obes=False /i=3 /j=4 /tp=" + TP.InnerText + " /psvitasdk=\"" + ReadSetting("SDKPath") + "\" /mv=1 /iv=0 /rv=0 /bv=" + versionBit + " /gn=\"" + AppName.Text + "\" /cd=\"" + Path.GetDirectoryName(Dst) + "/YYCCache\" /o=\"" + Dst + "\" \"" + Src + "\" ";
            }

            GmacOut.AppendText("-- GMASSETCOMPILER BEGIN --\r\n");
            GmacOut.AppendText("GMAssetCompiler.exe "+args+"\r\n");
            Process gmac = new Process();
            if (GMVer == "1.4.9999")
            {
                gmac.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "GMAssetCompiler.exe";
                gmac.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            }
            else
            {
                gmac.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory +"versions\\" + GMVer + "\\GMAssetCompiler.exe";
                gmac.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "versions\\" + GMVer;
            }

            gmac.StartInfo.Arguments = args;
            gmac.StartInfo.UseShellExecute = false;
            gmac.StartInfo.CreateNoWindow = true;
            gmac.StartInfo.RedirectStandardOutput = true;
            gmac.StartInfo.RedirectStandardError = true;
            gmac.ErrorDataReceived += new DataReceivedEventHandler(gmacError);
            gmac.OutputDataReceived += new DataReceivedEventHandler(gmacWrite);
            GMAC.GetPermissionToExecute(); //Resolve issue #7
            gmac.Start();
            gmac.BeginOutputReadLine();
            gmac.BeginErrorReadLine();
            while(!gmac.HasExited)
            {
                Application.DoEvents();
            }
            if (gmac.ExitCode != 0)
            {

                MessageBox.Show("GMAssetCompiler.exe Returned Error Code: " + gmac.ExitCode.ToString()+"\n\n"+stderr,"GMAC Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                stderr = "";
                Directory.Delete(Dst, true);
                return false;
            }
            gmac.Dispose();
            GmacOut.AppendText("-- GMASSETCOMPILER FINISHED! --\r\n");
            GmacOut.AppendText("Renaming to game.win...");
            foreach(String file in Directory.GetFiles(Dst))
            {
                if(file.EndsWith(".win"))
                {
                    File.Move(file, Dst + "\\game.win");
                }
                
                if(file.EndsWith(".yydebug"))
                {
                    File.Delete(file);
                }
            }
            GmacOut.AppendText("OK!\r\n");
            return true;
        }



        void gmacWrite(object sender, DataReceivedEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                if(e.Data != null)
                    if (e.Data.ToString().ToLower().Contains("error"))
                        stderr += e.Data + "\r\n";
                GmacOut.AppendText(e.Data+"\r\n");
                
            }));
        }

        void gmacError(object sender, DataReceivedEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                stderr += e.Data + "\r\n";
                GmacOut.AppendText(e.Data + "\r\n");
            }));
        }

        private void AppName_TextChanged(object sender, EventArgs e)
        {
            if(AppName.TextLength == 0)
            {
                CreateVPK.Enabled = false;
            }
            else
            {
                CreateVPK.Enabled = true;
            }
            ShortNamePreview.Text = AppName.Text;
            selectedHome.Checked = true;
        }

        private void selectedHome_CheckedChanged(object sender, EventArgs e)
        {
            HomePage.Visible = true;
            LiveArea.Visible = false;
            Running.Visible = false;
        }

        private void selectedLive_CheckedChanged(object sender, EventArgs e)
        {
            HomePage.Visible = false;
            LiveArea.Visible = true;
            Running.Visible = false;
        }

        private void SelectedRun_CheckedChanged(object sender, EventArgs e)
        {
            HomePage.Visible = false;
            LiveArea.Visible = false;
            Running.Visible = true;
        }

        private void GdbCategory_CheckedChanged(object sender, EventArgs e)
        {
            HomePage.Visible = false;
            LiveArea.Visible = true;
            Running.Visible = false;

            selectedLive.Checked = true;

            if (GdbCategory.Checked)
            {
                SFZ.Hide();
            }
            else
            {
                SFZ.Show();
            }
        }

        private void LeftGate_CheckedChanged(object sender, EventArgs e)
        {
            HomePage.Visible = false;
            LiveArea.Visible = true;
            Running.Visible = false;

            selectedLive.Checked = true;

            if(LeftGate.Checked)
            {
                GateBG.Location = new Point(574,194);
            }
            else
            {
                GateBG.Location = new Point(333, 194);
            }

        }

        private void GayMaker_Load(object sender, EventArgs e)
        {
            isLoading = true;

            Environment.SetEnvironmentVariable("SCE_PSP2_SDK_DIR",ReadSetting("SdkPath"));

            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2); //Center Screen

            SFZ.Parent = LABackground;
            SFZ.Location = new Point(267, 0);
            String EXEPath = Assembly.GetExecutingAssembly().Location;
            GMVersion.SelectedIndex = 0;
            DownloadMoreRAM.SelectedIndex = 0;
            if (File.Exists(Path.ChangeExtension(EXEPath, "old")))
            {
                File.Delete(Path.ChangeExtension(EXEPath, ".old"));
            }

            this.Text += CurrentVersion;
            try
            {
                CheckForUpdates();
            }
            catch(Exception){ };


            reloadVersions();

            try //Lazily fix issue #4
            {
                if (CheckSetting("SaveLast"))
                {
                    throw new Exception("SaveLastDisabled");
                }
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\GayMaker");

                ProjectPath.Text = key.GetValue("project").ToString();
                IconPath.Text = key.GetValue("icon0").ToString();
                BgPath.Text = key.GetValue("bg0").ToString();
                GatePath.Text = key.GetValue("gate0").ToString();
                PicPath.Text = key.GetValue("pic0").ToString();
                AppName.Text = key.GetValue("title").ToString();
                TitleIdBox.Text = key.GetValue("titleid").ToString();

                GdbCategory.Checked = ReadBoolean(key.GetValue("gdb").ToString());
                LeftGate.Checked = ReadBoolean(key.GetValue("leftgate").ToString());
                YYCEnabled.Checked = ReadBoolean(key.GetValue("useYYC").ToString());

                GMVersion.SelectedIndex = int.Parse(key.GetValue("lastVersion").ToString());
                DownloadMoreRAM.SelectedIndex = int.Parse(key.GetValue("downloadMoreRAM").ToString());
                

                selectedHome.Checked = true;
                HomePage.Visible = true;
                LiveArea.Visible = false;
                Running.Visible = false;


                key.Close();
            }
            catch (Exception){ };


            if(!File.Exists(ProjectPath.Text))
            {
                ProjectPath.Text = "(none)";
            }
            else
            {
                GlobalGameSettings.Enabled = true; // Fix issue #4

                if (TitleIdBox.TextLength != TitleIdBox.MaxLength)
                {
                    CreateVPK.Enabled = false;
                }
                else
                {
                    CreateVPK.Enabled = true;
                }

            }

            if (!File.Exists(BgPath.Text))
            {
                BgPath.Text = "img\\bg0.png";
            }

            if (!File.Exists(GatePath.Text))
            {
                GatePath.Text = "img\\startup.png";
            }

            if (!File.Exists(IconPath.Text))
            {
                IconPath.Text = "img\\icon0.png";
            }

            if (!File.Exists(PicPath.Text))
            {
                PicPath.Text = "img\\pic0.png";
            }

            if (!File.Exists(ProjectPath.Text))
            {
                ProjectPath.Text = "(none)";
            }


            ReloadIcons();
            isLoading = false;

        }

        private void BrowseIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Portable Network Graphics|*.PNG";
            openFileDialog1.Title = "Select a PNG File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                if (img.Height == 128 && img.Width == 128)
                {
                    IconBG.BackgroundImage.Dispose();
                    IconBG.BackgroundImage = img;
                    selectedHome.Checked = true;
                    IconPath.Text = openFileDialog1.FileName;
                }
                else
                {
                    img.Dispose(); //fix issue #2
                    MessageBox.Show("Image is not 128x128!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void BrowsePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Portable Network Graphics|*.PNG";
            openFileDialog1.Title = "Select a PNG File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                if (img.Height == 500 && img.Width == 840)
                {
                    LABackground.BackgroundImage.Dispose();
                    LABackground.BackgroundImage = img;
                    selectedLive.Checked = true;
                    BgPath.Text = openFileDialog1.FileName;
                }
                else
                {
                    img.Dispose(); //fix issue #2
                    MessageBox.Show("Image is not 840x500!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BrowseGate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Portable Network Graphics|*.PNG";
            openFileDialog1.Title = "Select a PNG File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                if (img.Height == 158 && img.Width == 280)
                {
                    GateBG.BackgroundImage.Dispose();
                    GateBG.BackgroundImage = img;
                    selectedLive.Checked = true;
                    GatePath.Text = openFileDialog1.FileName;
                }
                else
                {
                    img.Dispose(); //fix issue #2
                    MessageBox.Show("Image is not 280x158!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BrowsePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Portable Network Graphics|*.PNG";
            openFileDialog1.Title = "Select a PNG File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                if (img.Height == 544 && img.Width == 960)
                {
                    Running.BackgroundImage.Dispose();
                    Running.BackgroundImage = img;
                    SelectedRun.Checked = true;
                    PicPath.Text = openFileDialog1.FileName;
                }
                else
                {
                    img.Dispose(); //fix issue #2
                    MessageBox.Show("Image is not 960x544 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TitleIdBox_TextChanged(object sender, EventArgs e)
        {
            int i = TitleIdBox.SelectionStart;

            TitleIdBox.Text = TitleIdBox.Text.ToUpper();
            Regex rgx = new Regex("[^A-Z0-9]");
            TitleIdBox.Text = rgx.Replace(TitleIdBox.Text, "");

            TitleIdBox.SelectionStart = i;
            if(TitleIdBox.TextLength != TitleIdBox.MaxLength)
            {
                CreateVPK.Enabled = false;
            }
            else
            {
                CreateVPK.Enabled = true;
            }
        }

        private void BrowseProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "GameMaker Project Files|*.project.gmx";
            openFileDialog1.Title = "Select a GMX File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BgPath.Text = "img\\bg0.png";
                GatePath.Text = "img\\startup.png";
                IconPath.Text = "img\\icon0.png";
                PicPath.Text = "img\\pic0.png";
                TitleIdBox.Text = "GMSV00001";
                AppName.Text = "GM:S";
                DownloadMoreRAM.SelectedIndex = 0;
                GMVersion.SelectedIndex = 0;

                ReloadIcons();

                LeftGate.Checked = false;
                GdbCategory.Checked = false;

                ProjectPath.Text = openFileDialog1.FileName;
                CreateVPK.Enabled = true;
                GlobalGameSettings.Enabled = true;
            }
        }

        private void CreateVPK_Click(object sender, EventArgs e)
        {
            string tempdir = "";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Vita Packages|*.VPK";
            saveFileDialog1.Title = "Save VPK File";

            if (YYCEnabled.Checked)
            {
                string SDKPath = ReadSetting("SDKPath");
                string VCVars = ReadSetting("VCVarsPath");

                if(SDKPath == "invalid")
                {
                    MessageBox.Show("SDK Not Defined!", "SDK Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Prefs_Click(null, null);
                    return;
                }

                if (VCVars == "invalid")
                {
                    MessageBox.Show("vcvars32.bat Not Defined!", "VCVars Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Prefs_Click(null, null);
                    return;
                }

                if (!Directory.Exists(SDKPath))
                {
                    MessageBox.Show("SDK Directory: " + SDKPath + " Doesnt exist!", "SDK Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Prefs_Click(null, null);
                    return;
                }

                if (!File.Exists(VCVars))
                {
                    MessageBox.Show("Directory: " + VCVars + " Doesnt exist!", "VCVars Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Prefs_Click(null, null);
                    return;
                }

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string GMVer = GMVersion.SelectedItem.ToString();
                    tempdir = Path.GetDirectoryName(saveFileDialog1.FileName) + "\\_temp";
                    if (Directory.Exists(tempdir))
                    {
                        GmacOut.AppendText("Deleting _temp\r\n");
                        Directory.Delete(tempdir, true);
                    }
                    Directory.CreateDirectory(tempdir);
                    if (GMVer == "1.4.9999")
                    {
                        CopyDir(@"Runner", tempdir);
                    }
                    else
                    {
                        CopyDir("versions\\" + GMVer + "\\Runner", tempdir);
                    }

                    Make8Bit(IconPath.Text, tempdir + "\\sce_sys\\icon0.png");
                    Make8Bit(PicPath.Text, tempdir + "\\sce_sys\\pic0.png");
                    Make8Bit(BgPath.Text, tempdir + "\\sce_sys\\livearea\\contents\\bg0.png");
                    Make8Bit(GatePath.Text, tempdir + "\\sce_sys\\livearea\\contents\\startup.png");

                    if (!CompileProject(ProjectPath.Text, tempdir + "\\games", true))
                    {
                        Directory.Delete(tempdir, true);
                        CreateVPK.Enabled = true;
                        return;
                    }

                    Regex rgx = new Regex("[^a-zA-Z0-9-]");
                    string AppNameSln = rgx.Replace(AppName.Text, "_");
                    string ProjectName = Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(ProjectPath.Text));

                    string args = "/c \"\"" + ReadSetting("VCVarsPath") + "\" && " + Path.GetPathRoot(tempdir).Replace("\\", "") + " && cd \"" + tempdir + "\\YYCCache\\" + ProjectName + "\\Default\\Scripts\\PSVitaSolution\" && msbuild /m:%NUMBER_OF_PROCESSORS% \"" + AppNameSln + ".sln\" /p:Configuration=Release /t:build /verbosity:minimal\"";

                    GmacOut.AppendText("cmd.exe " + args);
                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";

                    cmd.StartInfo.Arguments = args;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.RedirectStandardError = true;
                    cmd.ErrorDataReceived += new DataReceivedEventHandler(gmacError);
                    cmd.OutputDataReceived += new DataReceivedEventHandler(gmacWrite);
                    cmd.Start();
                    cmd.BeginOutputReadLine();
                    cmd.BeginErrorReadLine();
                    while (!cmd.HasExited)
                    {
                        Application.DoEvents();
                    }
                    if (cmd.ExitCode != 0)
                    {
                        try
                        {
                            cmd.CancelErrorRead();
                            cmd.CancelOutputRead();
                        }
                        catch (Exception) { };
                        MessageBox.Show("Compilation Error: "+cmd.ExitCode+"\n\n"+stderr, "Compile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stderr = "";
                        Directory.Delete(tempdir, true);
                        CreateVPK.Enabled = true;
                        return;
                    }
                    cmd.Dispose();

                    GmacOut.AppendText("Locating SELF\r\n");

                    foreach(string fn in Directory.GetFiles(tempdir + "\\YYCCache\\" + ProjectName + "\\Default\\Scripts\\PSVitaSolution\\PSVita_Release"))
                    {
                        if (Path.GetExtension(fn) == ".self")
                        {
                            GmacOut.AppendText("Moving " + fn + " to " + tempdir + "\\eboot.bin\r\n");
                            File.Delete(tempdir + "\\eboot.bin");
                            File.Move(fn, tempdir + "\\eboot.bin");
                            break;
                        }
                    }

                    Directory.Delete(tempdir + "\\YYCCache", true);


                }
                else
                {
                    CreateVPK.Enabled = true;
                    return;
                }
            }
            else
            {
                CreateVPK.Enabled = false;
                HasShaders = File.ReadAllText(ProjectPath.Text).Contains("</shaders>"); //Too lazy to parse XML properly.
                if (HasShaders)
                {
                    if (!Directory.Exists(@"psvitasdk"))
                    {
                        DialogResult msgResult = MessageBox.Show("It's been detected that you are using Shaders in your GM Project\nHowever no copy of the Vita Shader Compiler (psp2cgc.exe) was found.\nBrowse to psp2cgc.exe?", "Shader Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (msgResult == DialogResult.Yes)
                        {
                            OpenFileDialog openFileDialog = new OpenFileDialog();
                            openFileDialog.Filter = "psp2cgc.exe|psp2cgc.exe";
                            openFileDialog.Title = "Browse to Vita Shader Compiler.";
                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {

                                if (!Directory.Exists(@"psvitasdk"))
                                {
                                    GmacOut.AppendText("Creating PSP2SDK Directory Structure\r\n");
                                    Directory.CreateDirectory("psvitasdk");
                                    Directory.CreateDirectory("psvitasdk/host_tools");
                                    Directory.CreateDirectory("psvitasdk/host_tools/bin");
                                }
                                File.Copy(openFileDialog.FileName, @"psvitasdk/host_tools/bin/psp2cgc.exe");

                            }
                            else
                            {
                                CreateVPK.Enabled = true;
                                return;
                            }
                        }
                        else
                        {
                            CreateVPK.Enabled = true;
                            return;
                        }

                    }
                }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string GMVer = GMVersion.SelectedItem.ToString();
                    tempdir = Path.GetDirectoryName(saveFileDialog1.FileName) + "\\_temp";
                    if (Directory.Exists(tempdir))
                    {
                        Directory.Delete(tempdir, true);
                    }
                    Directory.CreateDirectory(tempdir);
                    if (GMVer == "1.4.9999")
                    {
                        CopyDir(@"Runner", tempdir);
                    }
                    else
                    {
                        CopyDir("versions\\" + GMVer + "\\Runner", tempdir);
                    }

                    Make8Bit(IconPath.Text, tempdir + "\\sce_sys\\icon0.png");
                    Make8Bit(PicPath.Text, tempdir + "\\sce_sys\\pic0.png");
                    Make8Bit(BgPath.Text, tempdir + "\\sce_sys\\livearea\\contents\\bg0.png");
                    Make8Bit(GatePath.Text, tempdir + "\\sce_sys\\livearea\\contents\\startup.png");

                    if(!CompileProject(ProjectPath.Text, tempdir + "\\games"))
                    {
                        Directory.Delete(tempdir, true);
                        CreateVPK.Enabled = true;
                        return;
                    }
                }
                else
                {
                    CreateVPK.Enabled = true;
                    return;
                }
            }
                FileStream fd = File.Open(tempdir + "\\sce_sys\\param.sfo", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                GmacOut.AppendText("Writing " + AppName.Text + " to TITLE of param.sfo\r\n");
                fd.Seek(0x2C8, SeekOrigin.Begin);
                foreach (Byte by in ASCIIEncoding.ASCII.GetBytes(AppName.Text))
                {
                    fd.WriteByte(by);
                }


                fd.Seek(0x2FC, SeekOrigin.Begin);
                foreach (Byte by in ASCIIEncoding.ASCII.GetBytes(AppName.Text))
                {
                    fd.WriteByte(by);
                }

                if (GdbCategory.Checked)
                {
                    GmacOut.AppendText("Writing gdb to CATEGORY of param.sfo\n");
                    fd.Seek(0x266, SeekOrigin.Begin);
                    fd.WriteByte(0x62);  //ASCII 'b'
                }

                GmacOut.AppendText("Writing " + TitleIdBox.Text + " to TITLE_ID of param.sfo\r\n");
                fd.Seek(0x37C, SeekOrigin.Begin);
                foreach (Byte by in ASCIIEncoding.ASCII.GetBytes(TitleIdBox.Text))
                {
                    fd.WriteByte(by);
                }

                GmacOut.AppendText("Writing " + (DownloadMoreRAM.SelectedIndex * 4).ToString() + " to ATTRIBUTE2 of param.sfo!\n");
                fd.Seek(0x23C, SeekOrigin.Begin);
                fd.WriteByte(Convert.ToByte(DownloadMoreRAM.SelectedIndex * 4));
                fd.Close();

                if (LeftGate.Checked)
                {
                    GmacOut.AppendText("Writing #LeftGate template.xml\r\n");
                    File.WriteAllText(tempdir + "\\sce_sys\\livearea\\contents\\template.xml", Properties.Resources.gdbTemplate);
                }

                GmacOut.AppendText("Creating VPK ...");
                if (File.Exists(saveFileDialog1.FileName)) //Fix Issue #1
                {
                    File.Delete(saveFileDialog1.FileName);
                }
                
                
                ZipFile.CreateFromDirectory(tempdir, saveFileDialog1.FileName);
                GmacOut.AppendText("OK\r\n");

                GmacOut.AppendText("Deleting " + tempdir + " ...");
                Directory.Delete(tempdir, true);
                GmacOut.AppendText("OK!\r\n");

                GmacOut.AppendText("Done!\r\n");
                CreateVPK.Enabled = true;
                MessageBox.Show("VPK Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
            
            
        

        private void GlobalGameSettings_Enter(object sender, EventArgs e)
        {
            GlobalGameSettings.ForeColor = Color.Blue;
            GlobalGameSettings.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Underline);
            this.Cursor = Cursors.Hand;
        }

        private void GlobalGameSettings_Leave(object sender, EventArgs e)
        {
            GlobalGameSettings.ForeColor = Color.Black;
            GlobalGameSettings.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
            this.Cursor = Cursors.Arrow;
        }


        private void GlobalGameSettings_DoubleClick(object sender, EventArgs e)
        {
            GlobalGameSettings GlobalGames = new GlobalGameSettings();
            GlobalGames.ShowDialog();
        }

        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string appdata = Environment.GetEnvironmentVariable("appdata");
                if (!File.ReadAllText(appdata + "\\GameMaker-Studio\\fnames").Contains("// PlayStation Vita specific"))
                {
                    DialogResult MSG = MessageBox.Show("Do you want to install PSVita Specific functions into\nGameMaker:Studio?", "Install vita functions?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (MSG == DialogResult.Yes)
                    {
                        GmacOut.AppendText("Adding vita functions to (global) fnames file...\r\n");
                        File.AppendAllText(appdata + "\\GameMaker-Studio\\fnames", Resources.fnames);
                        MessageBox.Show("PSVita Specific functions have been added to:\n%appdata%\\GameMaker-Studio\\fnames", "Installed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("PSVita Specific functions allready installed!", "Installed Allready", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally{}


        }

        private void GayMaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CheckSetting("SaveLast"))
            {
                return;
            }
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\GayMaker");
                key.SetValue("project", ProjectPath.Text);
                key.SetValue("icon0", IconPath.Text);
                key.SetValue("bg0", BgPath.Text);
                key.SetValue("gate0", GatePath.Text);
                key.SetValue("pic0", PicPath.Text);
                key.SetValue("title", AppName.Text);
                key.SetValue("titleid", TitleIdBox.Text);
                key.SetValue("gdb", GdbCategory.Checked);
                key.SetValue("leftgate", LeftGate.Checked);
                key.SetValue("useYYC", YYCEnabled.Checked);
                key.SetValue("lastVersion", GMVersion.SelectedIndex);
                key.SetValue("downloadMoreRAM", DownloadMoreRAM.SelectedIndex);
                key.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to save settings to registry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GMVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.4.9999 comes built in
            if (GMVersion.SelectedItem.ToString() == "Manager")
            {
                GMVersion.SelectedIndex -= 1;
                this.Enabled = false;
                versionManager VM = new versionManager();
                VM.ShowDialog();
            }
        }

        private void IconBG_Click(object sender, EventArgs e)
        {
            selectedLive.Checked = true;
        }

        private void GateBG_Click(object sender, EventArgs e)
        {
            SelectedRun.Checked = true;
        }

        private void Prefs_Click(object sender, EventArgs e)
        {
            Preferences PrefsForm = new Preferences();
            PrefsForm.ShowDialog();
        }

        private void Prefs_MouseEnter(object sender, EventArgs e)
        {
            Prefs.ForeColor = Color.Blue;
            Prefs.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Underline);
            this.Cursor = Cursors.Hand;
        }

        private void Prefs_MouseLeave(object sender, EventArgs e)
        {
            Prefs.ForeColor = Color.Black;
            Prefs.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
            this.Cursor = Cursors.Arrow;
        }

        private void YYCEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (YYCEnabled.Checked && !isLoading)
            {
                DialogResult dr = MessageBox.Show("YYC requires you to have:\n- Visual Studio 2015\n- SCE SDK (Version 03.550-3.570)\n- Visual Studio Intergrations for VS2015\n- Razor for VS2015\n(Dont ask me for links)\n\nAllready installed in your PC\nAnd ENSURE GayMaker is pointing to them in the Preferences Page\nEnable YYC?", "YYC Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    YYCEnabled.Checked = true;
                }
                else
                {
                    YYCEnabled.Checked = false;
                }
            }
        }

    }
}
