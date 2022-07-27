﻿using MyScreenSaver.Properties;
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

            if (Settings.Default.PictureDir.Count <= 0 || Settings.Default.MusicDir.Count <= 0)
            {
                ShowScreenSaverOptions();
            }
            else
            {
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
                                break;
                            case "/s":
                                ShowScreenSaverFrm();
                                break;
                            default:
                                MessageBox.Show("Geçersiz komut satırı argümanı(bağımsız değişkeni): " + arg, "Geçersiz Komut Satırı Argümanı(Bağımsız Değişkeni)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        //ShowScreenSaverOptions();
                        ShowScreenSaverFrm();
                    }
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;

                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
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
    }
}