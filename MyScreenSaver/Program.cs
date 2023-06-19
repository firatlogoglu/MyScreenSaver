using MyScreenSaver.Properties;
using MyScreenSaver.Methods;
using System;
using System.Globalization;
using System.Threading;
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
            if (Settings.Default.Language == Languages.TurkishTR)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
            }
            else if (Settings.Default.Language == Languages.EnglishUS)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Languages.EnglishCodeUS);
            }
            else if (Settings.Default.Language == Languages.EnglishUK)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Languages.EnglishCodeGB_UK);
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
            }

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
                            ShowScreenSaverFrm();
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

        static void ShowScreenSaverFrm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShowScreenSaverForm());
        }

        static void ShowScreenSaverOptions()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OptionsForm());
        }

        static void ShowVideoPlayerFrm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Settings.Default.VideoAppWMP)
            {
               Application.Run(new VideoPlayerWMPForm());
                //Application.Run(new InternetForm());
            }
            else
            {
                Application.Run(new VideoPlayerVLCForm());
            }
        }
    }
}