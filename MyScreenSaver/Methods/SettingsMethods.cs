using Microsoft.Win32;
using MyScreenSaver.Languages;
using MyScreenSaver.Properties;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MyScreenSaver.Methods
{
    internal class SettingsMethods
    {
        internal static void SetRegedit(string path)
        {
            Registry.CurrentUser.OpenSubKey("Control Panel", RegistryKeyPermissionCheck.ReadWriteSubTree).CreateSubKey("Desktop").SetValue("SCRNSAVE.EXE", path);
        }

        internal static string GetRegedit()
        {
            try
            {
                object reg = Registry.CurrentUser.OpenSubKey("Control Panel", RegistryKeyPermissionCheck.ReadWriteSubTree).OpenSubKey("Desktop").GetValue("SCRNSAVE.EXE");
                if (null != reg)
                {
                    return reg.ToString();
                }
                return null;
            }
            catch (Exception)
            {
                SetSCRNSAVE("");
                return Registry.CurrentUser.OpenSubKey("Control Panel", RegistryKeyPermissionCheck.ReadWriteSubTree).OpenSubKey("Desktop").GetValue("SCRNSAVE.EXE").ToString();
            }
        }

        /// <summary>
        /// Edit/Set HKEY_CURRENT_USER\Control Panel\Desktop\SCRNSAVE.EXE
        /// Default: HKEY_CURRENT_USER\Control Panel\Desktop\SCRNSAVE.EXE ...\MyScreenSaver.scr
        /// </summary>
        /// <param name="path"></param>
        internal static void SetSCRNSAVE(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                path = Application.StartupPath + "\\" + "MyScreenSaver.scr";
            }

            #region desk.cpl
            //System.Diagnostics.Process.Start("rundll32.exe", "desk.cpl,InstallScreenSaver " + path);
            System.Diagnostics.Process.Start("control", "desk.cpl,,@screensaver");
            #endregion

            SetRegedit(path);
        }

        internal static void CheackSCRNSAVE()
        {
            string path = Application.StartupPath + "\\" + "MyScreenSaver.scr";
            string ass = GetRegedit();

            if (path != ass)
            {
                InstallSCR();
            }
        }

        internal static void InstallSCR()
        {
            SetSCRNSAVE("");
            SetCurrentUILanguage();
        }

        internal static string[] GetAllLanguageCodes()
        {
            string[] alllangcodes = new string[3];
            alllangcodes[0] = AllLanguageCodes.TurkishCodeTR;
            alllangcodes[1] = AllLanguageCodes.EnglishCodeUS;
            alllangcodes[2] = AllLanguageCodes.EnglishCodeGB_UK;

            return alllangcodes;
        }

        internal static string[] GetAllLanguageDisplayNames()
        {
            string[] alllangcodes = new string[3];
            alllangcodes[0] = GetLanguageDisplayName(AllLanguageCodes.TurkishCodeTR);
            alllangcodes[1] = GetLanguageDisplayName(AllLanguageCodes.EnglishCodeUS);
            alllangcodes[2] = GetLanguageDisplayName(AllLanguageCodes.EnglishCodeGB_UK);

            return alllangcodes;
        }

        internal static void SetLanguage(string languageCode)
        {
            Localization.Culture = new CultureInfo(languageCode);
            Settings.Default.Language = GetLanguageDisplayName(languageCode);
            Settings.Default.Save();
            Application.Restart();
        }

        internal static void SetLanguage2(string languageCode)
        {
            Localization.Culture = new CultureInfo(languageCode);
            Settings.Default.Language = GetLanguageDisplayName(languageCode);
            Settings.Default.Save();
            Application.Exit();
        }


        internal static void SetCurrentUILanguage()
        {
            string getuilangcode = GetCurrentUILanguageCode();

            if (AllLanguageCodes.EnglishCodeGB_UK == getuilangcode)
            {
                SetLanguage2(getuilangcode);
            }

            if (AllLanguageCodes.EnglishCodeUS == getuilangcode)
            {
                SetLanguage2(getuilangcode);
            }

            if (AllLanguageCodes.TurkishCodeTR == getuilangcode)
            {
                SetLanguage2(getuilangcode);
            }

            if (AllLanguageCodes.EnglishCodeGB_UK != getuilangcode && AllLanguageCodes.EnglishCodeUS != getuilangcode && AllLanguageCodes.TurkishCodeTR != getuilangcode)
            {
                MessageBox.Show("There is no " + GetLanguageDisplayName(getuilangcode) + " language support in this software.");

                SetLanguage2(AllLanguageCodes.EnglishCodeGB_UK);
            }
        }

        internal static void GetLanguageApplication()
        {
            string defaultLanguage = Settings.Default.Language;

            if (defaultLanguage == GetLanguageDisplayName(AllLanguageCodes.TurkishCodeTR))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(AllLanguageCodes.TurkishCodeTR);
            }
            else if (defaultLanguage == GetLanguageDisplayName(AllLanguageCodes.EnglishCodeUS))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(AllLanguageCodes.EnglishCodeUS);
            }
            else if (defaultLanguage == GetLanguageDisplayName(AllLanguageCodes.EnglishCodeGB_UK))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(AllLanguageCodes.EnglishCodeGB_UK);
            }
            else
            {
                SetCurrentUILanguage();
            }
        }

        internal static void SetAppCloseMouseDbClick(bool mouseDbClick)
        {
            if (mouseDbClick)
            {
                Settings.Default.AppCloseMouseDbClick = true;
            }
            else
            {
                Settings.Default.AppCloseMouseDbClick = false;
            }
            Settings.Default.Save();
        }

        internal static void SetPictureAuto(bool chk)
        {
            if (chk)
            {
                Settings.Default.PictureAuto = true;
            }
            else
            {
                Settings.Default.PictureAuto = false;
            }
            Settings.Default.Save();
        }

        internal static void ChkBoxShowTime(bool chk)
        {
            if (chk)
            {
                Settings.Default.ShowTime = true;
            }
            else
            {
                Settings.Default.ShowTime = false;
            }
            Settings.Default.Save();
        }

        internal static void SetRememberRemoveFileList(bool chk)
        {
            if (chk)
            {
                Settings.Default.RememberRemoveFileList = true;
            }
            else
            {
                Settings.Default.RememberRemoveFileList = false;
            }
            Settings.Default.Save();
        }

        internal static void RadioBtnImageSlideshow(bool chk)
        {
            if (chk)
            {
                Settings.Default.ImageSlideshow = true;
            }
            else
            {
                Settings.Default.ImageSlideshow = false;
            }
            Settings.Default.Save();
        }

        internal static void RadioBtnWPA(bool chk)
        {
            if (chk)
            {
                Settings.Default.VideoAppWMP = true;
            }
            else
            {
                Settings.Default.VideoAppWMP = false;
            }
            Settings.Default.Save();
        }

        internal static void RadioBtnWPA2(bool chk)
        {
            if (chk)
            {
                Settings.Default.MusicAppWMP = true;
            }
            else
            {
                Settings.Default.MusicAppWMP = false;
            }
            Settings.Default.Save();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        internal static string GetLanguageDisplayName(string languageCode = null)
        {
            if (languageCode == "" || languageCode == null)
            {
                return new CultureInfo(GetCurrentUILanguageCode()).DisplayName;
            }
            else
            {
                return new CultureInfo(languageCode).DisplayName;
            }
        }

        internal static string GetCurrentUILanguageCode()
        {
            return CultureInfo.CurrentUICulture.Name;
        }

        internal static void AddPictureDirs(string selectedpath)
        {
            Settings.Default.PictureDir.Add(selectedpath);
            Settings.Default.Save();
        }

        internal static void RemovePictureDir(int index)
        {
            Settings.Default.PictureDir.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void DefaultPictureDirs(string defaultuser)
        {
            Settings.Default.PictureDir.Clear();
            Settings.Default.PictureDir.Add(defaultuser);
            Settings.Default.Save();
        }

        internal static void AllRemovePictureDirs()
        {
            Settings.Default.PictureDir.Clear();
            Settings.Default.Save();
        }

        internal static void SetTimePicture(int time)
        {
            Settings.Default.PictureTime = time;
            Settings.Default.Save();
        }

        internal static void AddMusicDirs(string selectedpath)
        {
            Settings.Default.MusicDir.Add(selectedpath);
            Settings.Default.Save();
        }

        internal static void RemoveMusicDir(int index)
        {
            Settings.Default.MusicDir.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemoveMusicDirs()
        {
            Settings.Default.MusicDir.Clear();
            Settings.Default.Save();
        }

        internal static void AddPictureExtension(string extension)
        {
            Settings.Default.PictureExtensions.Add(extension);
            Settings.Default.Save();
        }

        internal static void DefaultPictureExtension(string[] extension)
        {
            Settings.Default.PictureExtensions.Clear();
            Settings.Default.PictureExtensions.AddRange(extension);
            Settings.Default.Save();
        }

        internal static void RemovePictureExtension(int index)
        {
            Settings.Default.PictureExtensions.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemovePictureExtensions()
        {
            Settings.Default.PictureExtensions.Clear();
            Settings.Default.Save();
        }

        internal static void ChkBoxMusicPlayer(bool chk)
        {
            if (chk)
            {
                Settings.Default.MusicPlayer = true;
            }
            else
            {
                Settings.Default.MusicPlayer = false;
            }
            Settings.Default.Save();
        }

        internal static void DefaultMusicDirs(string defaultuser)
        {
            Settings.Default.MusicDir.Clear();
            Settings.Default.MusicDir.Add(defaultuser);
            Settings.Default.Save();
        }

        internal static void AddMusicExtension(string extension)
        {
            Settings.Default.MusicExtensions.Add(extension);
            Settings.Default.Save();
        }

        internal static void DefaultMusicExtension(string[] extension)
        {
            Settings.Default.MusicExtensions.Clear();
            Settings.Default.MusicExtensions.AddRange(extension);
            Settings.Default.Save();
        }

        internal static void RemoveMusicExtension(int index)
        {
            Settings.Default.MusicExtensions.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemoveMusicExtensions()
        {
            Settings.Default.MusicExtensions.Clear();
            Settings.Default.Save();
        }

        internal static void AddVideoDirs(string selectedpath)
        {
            Settings.Default.VideoDir.Add(selectedpath);
            Settings.Default.Save();
        }

        internal static void RemoveVideoDir(int index)
        {
            Settings.Default.VideoDir.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemoveVideoDirs()
        {
            Settings.Default.VideoDir.Clear();
            Settings.Default.Save();
        }

        internal static void DefaultVideoDirs(string defaultuser)
        {
            Settings.Default.VideoDir.Clear();
            Settings.Default.VideoDir.Add(defaultuser);
            Settings.Default.Save();
        }

        internal static void AddVideoExtension(string extension)
        {
            Settings.Default.VideoExtensions.Add(extension);
            Settings.Default.Save();
        }

        internal static void DefaultVideoExtension(string[] extension)
        {
            Settings.Default.VideoExtensions.Clear();
            Settings.Default.VideoExtensions.AddRange(extension);
            Settings.Default.Save();
        }

        internal static void RemoveVideoExtension(int index)
        {
            Settings.Default.VideoExtensions.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemoveVideoExtensions()
        {
            Settings.Default.VideoExtensions.Clear();
            Settings.Default.Save();
        }

        internal static bool FullPictureDir()
        {
            if (Settings.Default.PictureDir.Count > 0 && Settings.Default.PictureExtensions.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool FullVideoDir()
        {
            if (Settings.Default.VideoDir.Count > 0 && Settings.Default.VideoExtensions.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static void SetClockAndDate(bool chk)
        {
            if (chk)
            {
                Settings.Default.ClockAndDate = true;
            }
            else
            {
                Settings.Default.ClockAndDate = false;
            }
            Settings.Default.Save();
        }
    }
}