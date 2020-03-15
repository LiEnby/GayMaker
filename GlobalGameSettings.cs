//IDC that my code is shit:
#pragma warning disable IDE1006 
#pragma warning disable IDE0017 

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace GayMaker
{
    public partial class GlobalGameSettings : Form
    {
        
        bool RearTouchEnabled = false;
        bool FrontTouchEnabled = false;
        bool IntorpolateEnabled = false;
        bool MakeFullScale = true;
        bool KeepAspectRatio = false;
        int PageSize = 2048;

        String ProjectPath;
        XmlDocument DefaultConfig = new XmlDocument();

        public GlobalGameSettings()
        {
            //Bypass Windows DPI Scaling
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
        }


        private void GlobalGameSettings_Load(object sender, EventArgs e)
        {
            Program.GM.Enabled = false;

            ProjectPath = Path.GetDirectoryName(Program.GM.GetProjectPath());
            Console.WriteLine(ProjectPath);
            DefaultConfig.Load(ProjectPath + "\\Configs\\Default.config.gmx");

            XmlNode FT = DefaultConfig.GetElementsByTagName("option_psvita_fronttouch")[0];
            XmlNode RT = DefaultConfig.GetElementsByTagName("option_psvita_reartouch")[0];
            XmlNode TP = DefaultConfig.GetElementsByTagName("option_psvita_texture_page")[0];
            XmlNode IT = DefaultConfig.GetElementsByTagName("option_psvita_interpolate")[0];
            XmlNode SC = DefaultConfig.GetElementsByTagName("option_psvita_scale")[0];

            try
            {
                //If global game settings was never opened then its true/false for some reason

                if (bool.Parse(FT.InnerText))
                {
                    FrontTouchEnabled = true;
                }
                else
                {
                    FrontTouchEnabled = false;
                }
                
                if(bool.Parse(RT.InnerText))
                {
                    RearTouchEnabled = true;
                }
                else
                {
                    RearTouchEnabled = false;
                }
                if(bool.Parse(IT.InnerText))
                {
                    IntorpolateEnabled = true;
                }
                else
                {
                    IntorpolateEnabled = false;
                }
            }
            catch
            {
                //Otherwise its -1 / 0 (GM IS WEIRD) 

                if (int.Parse(FT.InnerText) == 0)
                {
                    FrontTouchEnabled = false;
                }
                else
                {
                    FrontTouchEnabled = true;
                }

                if (int.Parse(RT.InnerText) == 0)
                {
                    RearTouchEnabled = false;
                }
                else
                {
                    RearTouchEnabled = true;
                }

                if (int.Parse(IT.InnerText) == 0)
                {
                    IntorpolateEnabled = false;
                }
                else
                {
                    IntorpolateEnabled = true;
                }
            }; 



            if (int.Parse(SC.InnerText) == 0)
            {
                MakeFullScale = true;
                KeepAspectRatio = false;
            }
            else
            {
                MakeFullScale = false;
                KeepAspectRatio = true;
            }

            PageSize = int.Parse(TP.InnerText);

            //Update Form

            FrontTouchPad.Checked = FrontTouchEnabled;
            RearTouchPad.Checked = RearTouchEnabled;
            Interporlate.Checked = IntorpolateEnabled;

            FullScale.Checked = MakeFullScale;
            AspectRatio.Checked = KeepAspectRatio;

            TexturePageSize.Text = PageSize.ToString();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrontTouchPad.Checked)
                {
                    XmlNode FT = DefaultConfig.GetElementsByTagName("option_psvita_fronttouch")[0];
                    FT.InnerText = "-1";
                }
                else
                {
                    XmlNode FT = DefaultConfig.GetElementsByTagName("option_psvita_fronttouch")[0];
                    FT.InnerText = "0";
                }

                if (RearTouchPad.Checked)
                {
                    XmlNode RT = DefaultConfig.GetElementsByTagName("option_psvita_reartouch")[0];
                    RT.InnerText = "-1";
                }
                else
                {
                    XmlNode RT = DefaultConfig.GetElementsByTagName("option_psvita_reartouch")[0];
                    RT.InnerText = "0";
                }

                if (Interporlate.Checked)
                {
                    XmlNode IT = DefaultConfig.GetElementsByTagName("option_psvita_interpolate")[0];
                    IT.InnerText = "-1";
                }
                else
                {
                    XmlNode IT = DefaultConfig.GetElementsByTagName("option_psvita_interpolate")[0];
                    IT.InnerText = "0";
                }

                if(AspectRatio.Checked)
                {
                    XmlNode SC = DefaultConfig.GetElementsByTagName("option_psvita_scale")[0];
                    SC.InnerText = "-1";
                }
                else
                {
                    XmlNode SC = DefaultConfig.GetElementsByTagName("option_psvita_scale")[0];
                    SC.InnerText = "0";
                }

                XmlNode TP = DefaultConfig.GetElementsByTagName("option_psvita_texture_page")[0];
                TP.InnerText = TexturePageSize.Text;

                //Save without creating newlines (i dont think it really matters but its good to be as accurate as possible)
                XmlWriterSettings settings = new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true };
                XmlWriter writer = XmlWriter.Create(ProjectPath + "\\Configs\\Default.config.gmx", settings);
                DefaultConfig.Save(writer);
                writer.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("There was an error while saving settings!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            Program.GM.Enabled = true;

            Close();

        }

        private void GlobalGameSettings_KeyDown(object sender, KeyEventArgs e)
        {
            //Keyboard Shortcuts are Nice.

            if(e.KeyCode == Keys.Enter)
            {
                Save_Click(null, null);
            }

            else if(e.KeyCode == Keys.Escape)
            {
                Program.GM.Enabled = true;
                Close();
            }
        }

        private void GlobalGameSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.GM.Enabled = true;
        }
    }
}
