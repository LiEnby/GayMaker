//IDC that my code is shit:
#pragma warning disable IDE1006 
#pragma warning disable IDE0017 

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using Ionic.Zip;
using System.Net;
using System.Net.Cache;
using System.Windows.Forms;
using System.Threading;

namespace GayMaker
{
    public partial class versionManager : Form
    {
        private void CopyDir(string source, string target)
        {

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
                    File.Copy(sysEntry, targetPath, true);
                }
            }
        }

        String[] Versions = { "1.4.1464", "1.4.1468", "1.4.1469", "1.4.1470", "1.4.1474", "1.4.1495", "1.4.1496", "1.4.1499", "1.4.1514", "1.4.1522", "1.4.1542", "1.4.1556", "1.4.1565", "1.4.1567", "1.4.1598", "1.4.1629", "1.4.1657", "1.4.1675", "1.4.1683", "1.4.1690", "1.4.1711", "1.4.1747", "1.4.1749", "1.4.1757", "1.4.1760", "1.4.1763", "1.4.1767", "1.4.1772", "1.4.1773", "1.4.1788", "1.4.1804", "1.99.505", "1.99.525", "1.99.533", "1.99.548", "1.99.549", "1.99.550", "1.99.551" };
        String[] VitaUrls = { "https://updater.yoyogames.com/api/download/psvita/71880e2e-e496-449f-9211-1a700f198335.zip", "https://updater.yoyogames.com/api/download/psvita/fb89b27d-7a56-4cdd-adbc-3b8e62ca2cc3.zip", "https://updater.yoyogames.com/api/download/psvita/da46f54f-5c00-4094-a26e-349035ae01a7.zip", "https://updater.yoyogames.com/api/download/psvita/c1761a9d-6420-44d0-835e-f3365e20a5ab.zip", "https://updater.yoyogames.com/api/download/psvita/aa7f0e02-6b9d-4d6f-8127-f4916d84c8fa.zip", "https://updater.yoyogames.com/api/download/psvita/8e7a116a-3518-482b-9d68-dc70aafa9772.zip", "https://updater.yoyogames.com/api/download/psvita/b5a773c3-8c81-4d50-937f-f2037dd6949a.zip", "https://updater.yoyogames.com/api/download/psvita/652004f6-4ba0-4779-93a9-3e8eacf31928.zip", "https://updater.yoyogames.com/api/download/psvita/e462256c-bed3-4301-9340-af428a41ba50.zip", "https://updater.yoyogames.com/api/download/psvita/59cca874-7bc7-426e-8535-434aa6dfc813.zip", "https://updater.yoyogames.com/api/download/psvita/4e51d1b5-3849-4cf4-86c6-d6b81bcf4e46.zip", "https://updater.yoyogames.com/api/download/psvita/53456f90-c66d-4b44-aa0d-db6e1d37e376.zip", "https://updater.yoyogames.com/api/download/psvita/bd1d4e64-5543-41ef-b0b6-94f3b5c377ac.zip", "https://updater.yoyogames.com/api/download/psvita/de15be40-b8e9-496a-aadb-46c3ea69e93c.zip", "https://updater.yoyogames.com/api/download/psvita/faf56e92-16f8-447b-a2a1-acbbbc31a659.zip", "https://updater.yoyogames.com/api/download/psvita/1a13f8d4-d9a6-43e4-b5cf-a2396fb1103c.zip", "https://updater.yoyogames.com/api/download/psvita/6dbeddb8-1468-4a2e-9c98-cc0117526c52.zip", "https://updater.yoyogames.com/api/download/psvita/18500239-c6cb-431f-9478-969bc5aa7e45.zip", "https://updater.yoyogames.com/api/download/psvita/9f4441e4-d72a-491c-9061-23db81308616.zip", "https://updater.yoyogames.com/api/download/psvita/640b0323-88f2-4e94-bb07-97034777a305.zip", "https://updater.yoyogames.com/api/download/psvita/52cfe6e4-9d4a-43a0-bfba-a38802b96be6.zip", "https://updater.yoyogames.com/api/download/psvita/501d070a-c53a-40a7-bf06-558161b77b30.zip", "https://updater.yoyogames.com/api/download/psvita/a7d57b1e-24dc-4e61-b402-9ec845cbb098.zip", "https://updater.yoyogames.com/api/download/psvita/dc390c15-b2de-494b-8031-651efee2020e.zip", "https://updater.yoyogames.com/api/download/psvita/213f252a-aa11-49fb-96e7-91b9242fad29.zip", "https://updater.yoyogames.com/api/download/psvita/0c23316a-f349-42f7-b267-59033632a77c.zip", "https://updater.yoyogames.com/api/download/psvita/58e19718-61a1-4be7-811b-b7558925d7ed.zip", "https://updater.yoyogames.com/api/download/psvita/95c61747-1ed2-4ec3-8ea0-037430417b34.zip", "https://updater.yoyogames.com/api/download/psvita/5fd1304c-42be-4d09-9359-4165a4d39591.zip", "https://updater.yoyogames.com/api/download/psvita/c9f28194-5994-459e-8218-b3bf45ddf1e0.zip", "https://updater.yoyogames.com/api/download/psvita/f8d08841-b6ae-4e34-a3d6-67407c4343b5.zip", "https://updater.yoyogames.com/api/download/psvita/09b42fab-6da7-4fe9-a60d-44e29fe6cf9a.zip", "https://updater.yoyogames.com/api/download/psvita/2dd4b46f-7a4e-4234-933c-1bcf0e34523e.zip", "https://updater.yoyogames.com/api/download/psvita/4b9f6329-4552-46d5-a401-e9f0d9c2a230.zip", "https://updater.yoyogames.com/api/download/psvita/77244b67-7e41-4f28-b83a-019f06739f9e.zip", "https://updater.yoyogames.com/api/download/psvita/b392e1d2-c431-4baa-9235-2dd1e95fc383.zip", "https://updater.yoyogames.com/api/download/psvita/afd82c60-daf5-4052-b785-a8327e8e509b.zip", "https://updater.yoyogames.com/api/download/psvita/a770d6eb-bf78-4ff6-8065-03ae79cda515.zip" };
        String[] Passwords = { "YJYDyTRu//reGTDMRtvqeA==", "qF5w5XngIlsjfF+Lgjvddg==", "HKMg1V1AJRyp4+fIpZe43Q==", "0fWronXzSHo0N3vP1OhXkw==", "mcUqbOFUxmKN/kfz0uczhA==", "Jo27hTbHw/fwIn6FWVyIiw==", "d0buqe+qJ7PoJ/+pO8UO8g==", "Psz0UkA3muQV9s+sJXQyyw==", "g7X4CTCE2P7zjHQjlUJjhg==", "VnKXoy+yOI1qt3ozXFW+VA==", "Wg4noeglJDRfAvzdHFMPAg==", "qzH9EbGL+EiQWERbAj63Hg==", "2l9hlMtrgVsXssl6BwGaaQ==", "pu05nMHNyzUYry9kF7WFdw==", "jM6jCc+Pr3muL/r+MXrJGQ==", "LdxwOYgTuC3kkPBHscNWZQ==", "eqJM94iGbbBsIA7iMCbCzg==", "nus0kqTASRp4r+cZQz4dHA==", "gXxOQ/hMdAG5XDnmzwRJBA==", "B8Yn0JHxXkE+q8DfboNZsw==", "2ZoimLxEz/Na7zoZnmQjbg==", "ftW7sk7jsT3tv09qQiOg9A==", "jvEhtQpW6yqRL0HLrU/k5w==", "9GsaUhrUn69As/n0hjyrDg==", "Xc13EtzfcI0wBdB46T8bCg==", "8ItorzszZnkr+AMeqvKt/g==", "z7jo2sFobX4wjv9sbokX5g==", "bfsOB+ih0Voayb+xuD+hmg==", "O8e/g0v8bnmVaxP0Mj+lTQ==", "CoUKbUNjJhUhN2Nis2Ofng==", "mnRXlyAzJDLXCk9xi5frmA==", "f+cjma9wcRLTqDBd5mpAgQ==", "WieG/fzWg+zksBrzMH0n0A==", "khCX7Bp6xPt9NdbhVMXzKg==", "AyvTY0JjJ8FcH93GNsqaMQ==", "hncejwoHFaVYgT4iQ1pKgg==", "DLP9sUfmMgcZ+q0BIncr8A==", "Z1E5Ad1HzQe9EzTuA7fbjg==" };

        String[] ProUrls = { "https://updater.yoyogames.com/api/download/pro/2aa95d44-cf9e-4a58-9d09-2a240bae2590.zip", "https://updater.yoyogames.com/api/download/pro/9c06dd3b-8105-4637-b720-93dbc7de7e7b.zip", "https://updater.yoyogames.com/api/download/pro/ea4c8359-2755-43b0-8c8c-21028d2e926f.zip", "https://updater.yoyogames.com/api/download/pro/34146826-64be-4ae2-b2ea-3d405f521bf4.zip", "https://updater.yoyogames.com/api/download/pro/7e1b4a27-c4cc-433a-a6cd-790c8370f69e.zip", "https://updater.yoyogames.com/api/download/pro/7ddfcb90-6d15-4593-9310-7effd86d5c5f.zip", "https://updater.yoyogames.com/api/download/pro/60809534-d886-4134-9b39-4f2a4b2d5417.zip", "https://updater.yoyogames.com/api/download/pro/7068d83c-5105-4e38-97cd-c8589ba995ac.zip", "https://updater.yoyogames.com/api/download/pro/e1c7104b-b79e-4f62-88b9-f5422b3a0062.zip", "https://updater.yoyogames.com/api/download/pro/8a2fadd8-9cbb-4c8b-b36d-34155a8b8366.zip", "https://updater.yoyogames.com/api/download/pro/422d570d-c0ba-46b1-90c6-96d4bb097198.zip", "https://updater.yoyogames.com/api/download/pro/3b8df5a4-61d3-42b2-8131-a7e3276a9d45.zip", "https://updater.yoyogames.com/api/download/pro/67808b11-d116-4f3b-9743-c3c56ca3fa11.zip", "https://updater.yoyogames.com/api/download/pro/0e138e3d-9f09-4a9e-9bb1-75de9dc35247.zip", "https://updater.yoyogames.com/api/download/pro/40d52eaf-d50e-46b0-b183-d45dea5fd1d3.zip", "https://updater.yoyogames.com/api/download/pro/015e9bdc-7e99-4815-a630-c2cb7fbad2bc.zip", "https://updater.yoyogames.com/api/download/pro/3c5ffb88-cc42-41e2-9365-2a3cd19f9f1c.zip", "https://updater.yoyogames.com/api/download/pro/e8a82731-30b9-4cbd-bb4a-23adb65918d7.zip", "https://updater.yoyogames.com/api/download/pro/951d162a-98a3-482b-b650-584c1b40638f.zip", "https://updater.yoyogames.com/api/download/pro/0acfc6df-06d8-4f58-9496-7a38c20c4efb.zip", "https://updater.yoyogames.com/api/download/pro/10ab3c1c-b1ee-4d80-90d2-0c189c508429.zip", "https://updater.yoyogames.com/api/download/pro/6df40635-9cf0-4ecb-9171-72ad3ecf96fe.zip", "https://updater.yoyogames.com/api/download/pro/86f8bf2a-8d70-4eb5-bd83-a2f2eb92bc7a.zip", "https://updater.yoyogames.com/api/download/pro/e703ba9b-b315-4b6a-b13b-5b0e2c816447.zip", "https://updater.yoyogames.com/api/download/pro/69966fb5-e022-4c9d-8c91-e5b82433fdbf.zip", "https://updater.yoyogames.com/api/download/pro/7ab65890-a469-41d4-b911-71b0ec18130c.zip", "https://updater.yoyogames.com/api/download/pro/1dcde91f-266a-4f83-b6aa-ae52706d11de.zip", "https://updater.yoyogames.com/api/download/pro/0f7d7ae9-c0ec-4518-867d-835b5657c301.zip", "https://updater.yoyogames.com/api/download/pro/4bf55408-2de9-426d-973c-27f8ffb25982.zip", "https://updater.yoyogames.com/api/download/pro/c132db45-6b5b-4dae-8a67-577bd8a3c77b.zip", "https://updater.yoyogames.com/api/download/pro/c7d823f5-9b53-4f23-8cfa-133814ae1d18.zip", "https://updater.yoyogames.com/api/download/pro/d7ebbb34-ee04-41b0-9d43-a751fd5c77e8.zip", "https://updater.yoyogames.com/api/download/pro/15d3bece-ebb8-49e9-b2ef-9a3eb8c0976a.zip", "https://updater.yoyogames.com/api/download/pro/7dfa06f9-ea44-4932-89fe-9efdaf0ba5c7.zip", "https://updater.yoyogames.com/api/download/pro/5fe561c7-a8b1-4cc3-9839-08268a1c6031.zip", "https://updater.yoyogames.com/api/download/pro/532013db-efb3-4227-81a4-36b6d8cb9029.zip", "https://updater.yoyogames.com/api/download/pro/7f485047-6575-476a-94f0-c27776664543.zip", "https://updater.yoyogames.com/api/download/pro/aa180c74-2b1c-4bc1-98b9-304394f8619d.zip", "https://updater.yoyogames.com/api/download/pro/82d49e93-c0e3-470e-8a5d-4bf3cd1db7db.zip", "https://updater.yoyogames.com/api/download/pro/15d3bece-ebb8-49e9-b2ef-9a3eb8c0976a.zip", "https://updater.yoyogames.com/api/download/pro/7dfa06f9-ea44-4932-89fe-9efdaf0ba5c7.zip", "https://updater.yoyogames.com/api/download/pro/5fe561c7-a8b1-4cc3-9839-08268a1c6031.zip", "https://updater.yoyogames.com/api/download/pro/532013db-efb3-4227-81a4-36b6d8cb9029.zip", "https://updater.yoyogames.com/api/download/pro/7f485047-6575-476a-94f0-c27776664543.zip", "https://updater.yoyogames.com/api/download/pro/aa180c74-2b1c-4bc1-98b9-304394f8619d.zip", "https://updater.yoyogames.com/api/download/pro/82d49e93-c0e3-470e-8a5d-4bf3cd1db7db.zip" };
        String[] ProPasswords = { "w8LU7n7qL/TTKYZ50Y+GJA==", "1a1kbg/He96W1kXu5MUtSw==", "cyUh9CJIX3fgyuugcqBgWw==", "yrMrZw1Nd5vgItLAMWWsWw==", "kp4xpA/K5cOuy9NefH6OiQ==", "j1eACYo4HFD8QgXLSc+WWA==", "CnIc2NJgxxf9CnvI2Jk1jg==", "AcyXSwl+I9HJXGW3lqr+wA==", "638Ow1jt7Fx1IzbZ91ZLUw==", "b56/tGBLlwj1aBS36ojAuw==", "UZnpjFq2a23rWg8OdTbOWw==", "pdpcCRrvm4NDK0Ak1V0KDw==", "csw6SBPb3FeJ+awgZVTJIA==", "QigzRUrPh6a1cruYfJIMSg==", "fk5N0e4Z4SNXwjaG3hTfbw==", "6knIcKZmICifwDFkPqnCiQ==", "DME9DhhFSmGQ4m+nSfXNew==", "r/XHptEBE+h2vU1aR9zZ6w==", "F/9CW15HDFGv9I/WLLBtJw==", "8lfa+wgkHFkJ9Eg6yXoB6w==", "gguQVlH7ZGIfbtKIY3YZbA==", "16I2d9EyM2j/zVyQmh3uxg==", "4O3W3Ih5MDgjEhSXlNSmtw==", "3COCVXB99MmOkp2CLddzmA==", "2ObB6N0sIVzBd76ysXC3Vg==", "4ZfC1NtXipOJPaF0m9UWHA==", "8xokrO5dadWdbTJkGmBF+w==", "RFR+3IEW+K9Q4SDndIaJGQ==", "QM3DGdmPRpwB7viZe85MUg==", "qF34ZrOIzWhOXBABarMAHg==", "GeAcP5ZmDHta/n7AO0vwYg==", "AR5cF7r65VTU8TThe6quaQ==", "cYc1VtX2k+oScURpEbyjRg==", "PJQAvameW9Mw9JY3FhW37A==", "yKJqh2+YvmwqXFThnJ6WtA==", "lzVJHoz+3J22cAKqS0kB1w==", "m7UQ8DLCMwnS+eOjgPkeYA==", "K25ONcZeWZ6Hj2QZhFiurQ==", "hQCOwIqppCXZ4TNlyEs9Ag==", "cYc1VtX2k+oScURpEbyjRg==", "PJQAvameW9Mw9JY3FhW37A==", "yKJqh2+YvmwqXFThnJ6WtA==", "lzVJHoz+3J22cAKqS0kB1w==", "m7UQ8DLCMwnS+eOjgPkeYA==", "K25ONcZeWZ6Hj2QZhFiurQ==", "hQCOwIqppCXZ4TNlyEs9Ag==" };

        private string currentDownload = "";

        String version;
        String url;
        String password;
        String yoyoUrl;

        String proUrl;
        String proPassword;


        private void startDownload(string URL,string path)
        {
            currentDownload = path;
            WebClient wc = new WebClient();
            wc.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            wc.Dispose();

            WebClient client = new WebClient();
            client.Headers.Add("pragma", "no-cache");

            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(URL), path);
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {


            if(currentDownload == "psvita.zip")
            {
                startDownload(proUrl, "pro.zip");
            }
            else if(currentDownload == "pro.zip")
            {
                startDownload(yoyoUrl, "gamemaker.zip");
            }
            else if(currentDownload == "gamemaker.zip")
            {
                DownloadProgress.Style = ProgressBarStyle.Marquee;
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    Invoke((Action)delegate { Status.Text = "Extracting psvita.zip"; }); 
                    if (Directory.Exists(@"_psvita"))
                    {
                        Directory.Delete(@"_psvita", true);
                    }

                    using (ZipFile archive = new ZipFile(@"psvita.zip"))
                    {
                        archive.Password = password;
                        archive.Encryption = EncryptionAlgorithm.PkzipWeak;
                        archive.ExtractAll(@"_psvita");
                    }

                    Invoke((Action)delegate { Status.Text = "Extracting pro.zip"; });

                    if (Directory.Exists(@"_pro"))
                    {
                        Directory.Delete(@"_pro", true);
                    }

                    using (ZipFile archive = new ZipFile(@"pro.zip"))
                    {
                        archive.Password = proPassword;
                        archive.Encryption = EncryptionAlgorithm.PkzipWeak;
                        archive.ExtractAll(@"_pro");
                    }


                    Invoke((Action)delegate { Status.Text = "Extracting gamemaker.zip"; });

                    if (Directory.Exists(@"_gamemaker"))
                    {
                        Directory.Delete(@"_gamemaker", true);
                    }

                    using (ZipFile archive = new ZipFile((@"gamemaker.zip")))
                    {
                        archive.Password = "12#_p@o3w$ir_ADD-_$#";
                        archive.Encryption = EncryptionAlgorithm.PkzipWeak;
                        archive.ExtractAll(@"_gamemaker");
                    }

                    if (!Directory.Exists(@"versions"))
                    {
                        Directory.CreateDirectory(@"versions");
                    }

                    if (!Directory.Exists(@"versions\\" + version))
                    {
                        Directory.CreateDirectory(@"versions\\" + version);
                    }

                    if (!Directory.Exists(@"versions\\" + version + "\\Runner"))
                    {
                        Directory.CreateDirectory(@"versions\\" + version + "\\Runner");
                    }

                    if (!Directory.Exists(@"versions\\" + version + "\\Shaders"))
                    {
                        Directory.CreateDirectory(@"versions\\" + version + "\\Shaders");
                    }
                    if (!Directory.Exists(@"versions\\" + version + "\\YYC"))
                    {
                        Directory.CreateDirectory(@"versions\\" + version + "\\YYC");
                    }
                    try
                    {
                        File.Copy(@"_gamemaker\\BouncyCastle.Crypto.dll", @"versions\\" + version + "\\BouncyCastle.Crypto.dll", true);
                        File.Copy(@"_gamemaker\\spine-csharp.dll", @"versions\\" + version + "\\spine-csharp.dll", true);
                        File.Copy(@"_gamemaker\\SharpCompress.dll", @"versions\\" + version + "\\SharpCompress.dll", true);
                        File.Copy(@"_gamemaker\\Ionic.Zip.Reduced.dll", @"versions\\" + version + "\\Ionic.Zip.Reduced.dll", true);
                        File.Copy(@"_gamemaker\\Newtonsoft.Json.dll", @"versions\\" + version + "\\Ionic.Zip.Reduced.dll", true);
                    }
                    catch (Exception) { };

                    File.Copy(@"_gamemaker\\GMAssetCompiler.exe", @"versions\\" + version + "\\GMAssetCompiler.exe", true);
                    File.Copy(@"_gamemaker\\ffmpeg.exe", @"versions\\" + version + "\\ffmpeg.exe", true);

                    CopyDir(@"_gamemaker\\Shaders", @"versions\\" + version + "\\Shaders");
                    CopyDir(@"_psvita\\YYC", @"versions\\" + version + "\\YYC");
                    CopyDir(@"_pro\YYC\\include", @"versions\\" + version + "\\YYC\\include");

                    File.Copy(@"_psvita\\PSVita\\CG_PShaderCommon.shader", @"versions\\" + version + "\\Shaders\\CG_PShaderCommon.shader", true);
                    File.Copy(@"_psvita\\PSVita\\CG_VShaderCommon.shader", @"versions\\" + version + "\\Shaders\\CG_VShaderCommon.shader", true);

                    CopyDir(@"Runner", @"versions\\" + version + "\\Runner");

                    File.Copy(@"_psvita\\PSVita\\PSVitaRunner.self", @"versions\\" + version + "\\Runner\\eboot.bin", true);

                    Directory.Delete(@"_gamemaker", true);
                    Directory.Delete(@"_psvita", true);
                    Directory.Delete(@"_pro", true);

                    File.Delete("psvita.zip");
                    File.Delete("gamemaker.zip");
                    File.Delete("pro.zip");

                    Invoke((Action)delegate {

                        downloadList.Enabled = true;
                        downloadVersion.Enabled = true;

                        downloadList.Items.Remove(version);
                        installedList.Items.Add(version);

                        Status.Text = "Waiting";
                        DownloadProgress.Value = 0;
                        DownloadProgress.Style = ProgressBarStyle.Continuous;
                        ControlBox = true;

                    });

                }).Start();
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgress.Value = e.ProgressPercentage;
            Status.Text = "Downloading " + currentDownload + " " +e.ProgressPercentage + "%";
        }

        public String getOriginalUrl(string version)
        {
            return "https://updater.yoyogames.com/api/download/original?filename=Original-" + version + ".zip";
        }

        public string findUrl(string version, bool pro)
        {
            int index = 0;
            foreach(string ver in Versions)
            { 
                if(ver == version)
                {
                    break;
                }
                index++;
            }

            if(pro)
            {
                String realUrl = "http://updatecdn.yoyogames.com/" + Path.GetFileName(ProUrls[index]);
                return realUrl;
            }
            else
            {
                String realUrl = "http://updatecdn.yoyogames.com/" + Path.GetFileName(VitaUrls[index]);
                return realUrl;
            }
            
            
        }

        public string getPassword(string url, bool pro)
        {
            string zip = Path.GetFileName(url);

            if (zip.Contains("Original"))
            {
                return "12#_p@o3w$ir_ADD-_$#";
            }

            int index = 0;

            if (pro)
            {
                foreach (String URL in ProUrls)
                {
                    if (Path.GetFileName(URL) == zip)
                    {
                        break;
                    }
                    index++;
                }
            }
            else
            {
                foreach (String URL in VitaUrls)
                {
                    if (Path.GetFileName(URL) == zip)
                    {
                        break;
                    }
                    index++;
                }
            }

            if(pro)
            {
                return ProPasswords[index];
            }
            else
            {
                return Passwords[index];
            }
            
        }

        public versionManager()
        {

            //Bypass Windows DPI Scaling (See issue #8 to see why its important)
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
        }

        private void versionManager_Load(object sender, EventArgs e)
        {
            try
            {
                foreach(String Version in Versions)
                {
                    downloadList.Items.Add(Version);
                }
                foreach (String dir in Directory.GetDirectories(@"versions"))
                {
                    installedList.Items.Add(Path.GetFileName(dir));
                    downloadList.Items.Remove(Path.GetFileName(dir));
                }
            }
            catch (Exception) { };


        }


        private void downloadVersion_Click(object sender, EventArgs e)
        {
            if(downloadList.SelectedIndex == -1){ return; }
            downloadVersion.Enabled = false;
            downloadList.Enabled = false;
            ControlBox = false;

            version = downloadList.SelectedItem.ToString();
            url = findUrl(version, false);
            password = getPassword(url,false);

            proUrl = findUrl(version, true);
            proPassword = getPassword(proUrl, true);

            yoyoUrl = getOriginalUrl(version);
            try
            {
                startDownload(url, "psvita.zip");
            }
            catch(Exception)
            {
                MessageBox.Show("Could not connect to yoyogames.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                downloadVersion.Enabled = true;
                downloadList.Enabled = true;
                ControlBox = true;
            }


        }

        private void deleteVersion_Click(object sender, EventArgs e)
        {
            if (installedList.SelectedIndex == -1) { return; }
            string toRemove = installedList.SelectedItem.ToString();
            if(toRemove == "1.4.9999")
            {
                MessageBox.Show("Cannot delete builtin 1.4.9999 version!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Directory.Delete(@"versions\\" + toRemove, true);
                installedList.Items.Remove(toRemove);
                downloadList.Items.Add(toRemove);
            }

        }

        private void versionManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ControlBox == false)
            {
                e.Cancel = true;
            }

            Program.GM.Enabled = true;

            Program.GM.reloadVersions();
        }
    }
}
