using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            try
            {
                if (args.Length > 0)
                {
                    string arg = args[0].ToLowerInvariant();
                    switch (arg)
                    {
                        case "/c":
                            // Options (Seçenekler)
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
                    ShowScreenSaverFrm();
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
    }
}
