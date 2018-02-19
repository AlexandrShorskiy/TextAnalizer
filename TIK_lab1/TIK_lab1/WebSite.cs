using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIK_lab1
{
    public partial class WebSite : Form
    {
        TextAnalyzer web = new TextAnalyzer();
        public WebSite()
        {
            InitializeComponent();
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void b_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(webBrowser1.Document.Body.InnerText);
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void WebSite_Load(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
            webBrowser1.Navigate(textBox1.Text);
        }
    }
}
