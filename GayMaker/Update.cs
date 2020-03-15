//IDC that my code is shit:
#pragma warning disable IDE1006 
#pragma warning disable IDE0017 

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Cache;
using System.Reflection;
using System.Windows.Forms;

namespace GayMaker
{
    public partial class Update : Form
    {
        public Update()
        {
            //Bypass Windows DPI Scaling
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
        }

        private void startDownload()
        {
            WebClient wc = new WebClient();
            wc.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            String UpdateString = wc.DownloadString("https://raw.githubusercontent.com/KuromeSan/GayMaker/master/latest.md");
            String[] Data = UpdateString.Split('~');
            String UpdateUrl = Data[1];
            wc.Dispose();

            WebClient client = new WebClient();
            client.Headers.Add("pragma", "no-cache");

            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(UpdateUrl),"upgrade.zip");
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

            label1.Text = "Extracting";

            String EXEPath = Assembly.GetExecutingAssembly().Location;

            File.Move(EXEPath, Path.ChangeExtension(EXEPath, ".old"));

            ZipArchive archive = new ZipArchive(File.OpenRead("upgrade.zip"));
            foreach(ZipArchiveEntry file in archive.Entries)
            {
                if (File.Exists(file.FullName))
                {
                    File.Delete(file.FullName);
                }
            }

            ZipFile.ExtractToDirectory("upgrade.zip", Path.GetDirectoryName(EXEPath));

            File.Delete("upgrade.zip");

            Application.Restart();

        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgress.Value = e.ProgressPercentage;
            label1.Text = "Downloading: " + e.ProgressPercentage + "%";
        }

        private void Update_Load(object sender, EventArgs e)
        {
            startDownload();
        }

    }
}
