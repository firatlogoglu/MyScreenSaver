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
    public partial class InternetForm : Form
    {
        public InternetForm()
        {
            InitializeComponent();
            //webBrowser.Url.AbsoluteUri("ASDAS");
            webBrowser.Navigate("github.com");
            panel1.Visible = false;
            panel1.Enabled = false;
         

        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
       
            this.Text = webBrowser.Document.Title;
            txtURL.Text = e.Url.DnsSafeHost;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtURL.Text))
            {
                webBrowser.Navigate(txtURL.Text);
            }
        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
  
        }
    }
}
