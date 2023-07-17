using MyScreenSaver.Forms;
using MyScreenSaver.Methods;
using MyScreenSaver.Properties;
using System;
using System.Windows.Forms;

namespace MyScreenSaver
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            SettingsMethods.CheackSCRNSAVE();
            bool exePart = Application.ExecutablePath.Contains(".exe");
            try
            {
                bool ar = args[0].Contains("/i");
                if (exePart == true && !ar)
                {
                    Environment.Exit(1);
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult != -2146233080)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                SettingsMethods.GetLanguageApplication();
                try
                {
                    if (args.Length > 0)
                    {
                        string arg = args[0].ToLowerInvariant().Trim().Substring(0, 2);
                        switch (arg)
                        {
                            case "/c":
                                // Options (Yapılandır/Seçenekler)
                                ShowScreenSaverOptions();
                                break;
                            case "/p":
                                if (Settings.Default.ImageSlideshow)
                                {
                                    if (SettingsMethods.FullPictureDir())
                                    {
                                        ShowScreenSaverFrm();
                                    }
                                    else
                                    {
                                        ShowScreenSaverOptions();
                                    }
                                }
                                else
                                {
                                    if (SettingsMethods.FullVideoDir())
                                    {
                                        ShowVideoPlayerFrm();
                                    }
                                    else
                                    {
                                        ShowScreenSaverOptions();
                                    }
                                }
                                break;
                            case "/s":
                                if (Settings.Default.ImageSlideshow)
                                {
                                    if (SettingsMethods.FullPictureDir())
                                    {
                                        ShowScreenSaverFrm();
                                    }
                                    else
                                    {
                                        ShowScreenSaverOptions();
                                    }
                                }
                                else
                                {
                                    if (SettingsMethods.FullVideoDir())
                                    {
                                        ShowVideoPlayerFrm();
                                    }
                                    else
                                    {
                                        ShowScreenSaverOptions();
                                    }
                                }

                                break;
                            case "/i":
                                SettingsMethods.InstallSCR();
                                Environment.Exit(0);
                                break;
                            default:
                                MessageBox.Show("Geçersiz komut satırı argümanı(bağımsız değişkeni): " + arg, "Geçersiz Komut Satırı Argümanı(Bağımsız Değişkeni)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        //ShowScreenSaverOptions();
                        if (Settings.Default.ImageSlideshow)
                        {
                            if (SettingsMethods.FullPictureDir())
                            {
                                ShowScreenSaverFrm();
                            }
                            else
                            {
                                ShowScreenSaverOptions();
                            }
                        }
                        else
                        {
                            if (SettingsMethods.FullVideoDir())
                            {
                                ShowVideoPlayerFrm();
                            }
                            else
                            {
                                ShowScreenSaverOptions();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;

                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private static void ShowScreenSaverFrm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShowScreenSaverForm());
        }

        private static void ShowScreenSaverOptions()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OptionsForm());
        }

        private static void ShowVideoPlayerFrm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Settings.Default.VideoAppWMP)
            {
                Application.Run(new VideoPlayerWMPForm());
            }
            else
            {
                Application.Run(new VideoPlayerVLCForm());
            }
        }

        private static void ShowUpdateManagerFrm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UpdateManagerForm());
        }
    }
}