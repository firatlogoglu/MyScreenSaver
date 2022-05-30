using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class ShowScreenSaverForm : Form
    {
        public ShowScreenSaverForm()
        {
            InitializeComponent();
        }

        private void ShowScreenSaverForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}