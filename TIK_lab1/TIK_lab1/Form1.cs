using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace TIK_lab1
{
    public partial class TextAnalyzer : Form
    {
        List<Part> parts = new List<Part>();
        static string result;
        public string webSites;

        public TextAnalyzer()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                tb_website.Enabled = true;
            else tb_website.Enabled = false;
        }

        private void TextAnalyzer_Load(object sender, EventArgs e)
        {
            tb_website.Enabled = false;
            b_sort.Enabled = false;
            cb_symb.Enabled = false;
            cb_val.Enabled = false;
        }

        private void b_result_Click(object sender, EventArgs e)
        { 
            l_error.Text = "";
            tb_result.Text = "";
            tb_qualInf.Clear();
            parts.Clear();
            if (tb_text.Text == "")
                l_error.Text = "Error! Input the text";
            else
            {
                result = "";
                bool flag = false;
                if (cb_ru.Checked == true)
                {
                    result += "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                    flag = true;
                }
                if (cb_en.Checked == true)
                {
                    result += "ABCDEFGHIJKLMNOPQRSTUVWXYZzyxwvutsrqponmlkjihgfedcba";
                    flag = true;
                }
                if (cb_uk.Checked == true)
                {
                    result += "АаБбВвГгҐґДдЕеЄєЖжЗзИиІіЇїЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЬьЮюЯя";
                    flag = true;
                }
                if (cb_punctuation.Checked == true)
                {
                    flag = true;
                    result += ".,;:!¡?¿⁇⸮‽⸘…‐‒–—―[](){}⟨⟩„“«»“”‘’‹›";
                }
                if (flag == false)
                {
                    l_error.Text = "Error! Choose language"; tb_result.Clear();
                    return;
                }
                if (tb_result.Text == "")
                {
                    foreach (var letter in tb_text.Text.Distinct().ToArray())
                    {
                        var count = tb_text.Text.Count(chr => chr == letter);
                        if (result.IndexOf(letter) >= 0)
                        {
                            tb_result.Text += letter + "\t" + count + "\n";
                            parts.Add(new Part { PartName = letter, PartCount = count });
                        }
                    }
                    b_sort.Enabled = true;
                    cb_symb.Enabled = true;
                    cb_val.Enabled = true;
                    double param = 0;
                    for (int i = 0; i < parts.Count; i++)
                        param += parts[i].PartCount / (float)tb_text.Text.Length * (Math.Log(parts[i].PartCount / (float)tb_text.Text.Length, 2));
                    param = -param;
                    tb_entropy.Text = Math.Round(param, 2).ToString();
                    tb_qualInf.Text = "i = " + Math.Round((param * tb_text.Text.Length), 2).ToString() + " b";
                    tb_numCh.Text = tb_text.Text.Length.ToString();
                }
                else
                {
                    tb_result.Clear();
                    tb_text.Clear();
                    tb_website.Clear();
                    tb_qualInf.Clear();
                    tb_numCh.Clear();
                    tb_entropy.Clear();
                }
               
            }
        }

        private void b_sort_Click(object sender, EventArgs e)
        {
            if (tb_result.Text == "")
            {
                b_sort.Enabled = false;
                cb_symb.Enabled = false;
                cb_val.Enabled = false;
            }
            else
            {
                b_sort.Enabled = true;
                cb_symb.Enabled = true;
                cb_val.Enabled = true;
            }
            tb_result.Text = "";
            if (cb_symb.Checked == true && cb_val.Checked == false)
            {
                parts.Sort(delegate(Part x, Part y)
                { return x.PartName.CompareTo(y.PartName); });
            }
            else
            {
                cb_val.Checked = true;
                cb_symb.Checked = false;
                parts.Sort();
            }
            foreach (Part aPart in parts)
            {
                tb_result.Text += aPart;
            }
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            tb_result.Clear();
            tb_text.Clear();
            tb_website.Clear();
            tb_qualInf.Clear();
            tb_numCh.Clear();
        }

        private void b_openWeb_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_website.Text);
            WebSite web = new WebSite();
            web.ShowDialog();
            tb_text.Text = Clipboard.GetText();
        }

    }
}
