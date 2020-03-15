//IDC that my code is shit:
#pragma warning disable IDE1006 
#pragma warning disable IDE0017 

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GayMaker
{
    public partial class Preferences : Form
    {
        public bool ReadBoolean(string Bool)
        {
            if (Bool == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Preferences()
        {
            //Bypass Windows DPI Scaling (See issue #8 to see why its important)
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
        }

        public void CheckSdkPath()
        {
            if(officalSDK.Checked)
            {
                SDKDir.Enabled = true;
                browse.Enabled = true;
                VcVarsBatDir.Enabled = true;
                browseVCVARS.Enabled = true;
            }
            else
            {
                SDKDir.Enabled = false;
                browse.Enabled = false;
                VcVarsBatDir.Enabled = false;
                browseVCVARS.Enabled = false;
            }
        }

        private void Preferences_Load(object sender, EventArgs e)
        {



            try 
            {
               
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\GayMaker");

                Updates.Checked = ReadBoolean(key.GetValue("CheckForUpdates").ToString());
                SaveLast.Checked = ReadBoolean(key.GetValue("SaveLast").ToString());
                IndexedColor.Checked = ReadBoolean(key.GetValue("IndexedColor").ToString());

                SDKDir.Text = key.GetValue("SDKPath").ToString();
                VcVarsBatDir.Text = key.GetValue("VCVarsPath").ToString();

                officalSDK.Checked = ReadBoolean(key.GetValue("OfficalSDK").ToString());
                unOfficalSDK.Checked = ReadBoolean(key.GetValue("UNOfficalSDK").ToString());

                key.Close();

               
            }
            catch (Exception) { };

            CheckSdkPath();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\GayMaker");
                key.SetValue("CheckForUpdates", Updates.Checked);
                key.SetValue("SaveLast", SaveLast.Checked);
                key.SetValue("IndexedColor", IndexedColor.Checked);

                key.SetValue("SDKPath", SDKDir.Text);
                key.SetValue("VCVarsPath", VcVarsBatDir.Text);

                key.SetValue("OfficalSDK", officalSDK.Checked);
                key.SetValue("UNOfficalSDK", unOfficalSDK.Checked);

                key.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error while saving preferences!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Environment.SetEnvironmentVariable("SCE_PSP2_SDK_DIR", SDKDir.Text);

            Close();
        }

        private void unOfficalSDK_CheckedChanged(object sender, EventArgs e)
        {
            CheckSdkPath();
        }

        private void officalSDK_CheckedChanged(object sender, EventArgs e)
        {
            CheckSdkPath();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowDialog();
            SDKDir.Text = FBD.SelectedPath;
            FBD.Dispose();
        }

        private void browseVCVARS_Click(object sender, EventArgs e)
        {
            OpenFileDialog FBD = new OpenFileDialog();
            FBD.Filter = "vcvars32.bat|vcvars32.bat";
            FBD.ShowDialog();
            VcVarsBatDir.Text = FBD.FileName;
            FBD.Dispose();
        }
    }
}
