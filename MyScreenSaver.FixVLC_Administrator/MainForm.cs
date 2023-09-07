using MyScreenSaver.FixVLC_Administrator.Methods;
using System;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace MyScreenSaver.FixVLC_Administrator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                bool isElevated;
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                {
                    WindowsPrincipal principal = new WindowsPrincipal(identity);
                    isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
                }
                if (isElevated)
                {
                    string x86;
                    string x64;
                    if (Environment.Is64BitOperatingSystem && !Environment.Is64BitProcess)
                    {
                        x86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                        x64 = @"C:\Program Files";
                    }
                    else
                    {
                        x86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                        x64 = "";
                    }

                    string path = @"\VideoLAN\VLC\lua\playlist\";

                    string filename = "youtube.luac";
                    string filenamebak = "youtube.luac.bak";
                    string filename2 = "youtube.lua";
                    string filename2bak = "youtube.lua.bak";
                    string x86fullPath = x86 + path;
                    string x64fullPath = x64 + path;

                    string fullpath = Application.StartupPath + @"\Units\VLC\" + filename2;

                    if (SettingsMethods.IsDirExists(x86fullPath))
                    {
                        if (SettingsMethods.IsFileExists(x86fullPath + filename))
                        {
                            File.Copy(x86fullPath + filename, x86fullPath + filenamebak, true);
                            File.Delete(x86fullPath + filename);
                            if (SettingsMethods.IsFileExists(x86fullPath + filename2))
                            {
                                File.Copy(x86fullPath + filename2, x86fullPath + filename2bak, true);
                                File.Delete(x86fullPath + filename2);

                                File.Copy(fullpath, x86fullPath + filename2, true);
                            }
                            else
                            {
                                File.Copy(fullpath, x86fullPath + filename2, true);
                            }
                        }
                        else
                        {
                            if (SettingsMethods.IsFileExists(x86fullPath + filename2))
                            {
                                File.Copy(x86fullPath + filename2, x86fullPath + filename2bak, true);
                                File.Delete(x86fullPath + filename2);

                                File.Copy(fullpath, x86fullPath + filename2, true);
                            }
                            else
                            {
                                File.Copy(fullpath, x86fullPath + filename2, true);
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(x64) && SettingsMethods.IsDirExists(x64fullPath))
                    {
                        if (SettingsMethods.IsFileExists(x64fullPath + filename))
                        {
                            File.Copy(x64fullPath + filename, x64fullPath + filenamebak, true);
                            File.Delete(x64fullPath + filename);
                            if (SettingsMethods.IsFileExists(x64fullPath + filename2))
                            {
                                File.Copy(x64fullPath + filename2, x64fullPath + filename2bak, true);
                                File.Delete(x64fullPath + filename2);

                                File.Copy(fullpath, x64fullPath + filename2, true);
                            }
                            else
                            {
                                File.Copy(fullpath, x64fullPath + filename2, true);
                            }
                        }
                        else
                        {
                            if (SettingsMethods.IsFileExists(x64fullPath + filename2))
                            {
                                File.Copy(x64fullPath + filename2, x64fullPath + filename2bak, true);
                                File.Delete(x64fullPath + filename2);

                                File.Copy(fullpath, x64fullPath + filename2, true);
                            }
                            else
                            {
                                File.Copy(fullpath, x64fullPath + filename2, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}