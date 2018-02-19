namespace TIK_lab1
{
    partial class TextAnalyzer
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextAnalyzer));
            this.tb_text = new System.Windows.Forms.RichTextBox();
            this.gb_language = new System.Windows.Forms.GroupBox();
            this.cb_uk = new System.Windows.Forms.CheckBox();
            this.cb_punctuation = new System.Windows.Forms.CheckBox();
            this.cb_en = new System.Windows.Forms.CheckBox();
            this.cb_ru = new System.Windows.Forms.CheckBox();
            this.tb_result = new System.Windows.Forms.RichTextBox();
            this.b_result = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_qualInf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_website = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l_error = new System.Windows.Forms.Label();
            this.b_sort = new System.Windows.Forms.Button();
            this.cb_symb = new System.Windows.Forms.CheckBox();
            this.cb_val = new System.Windows.Forms.CheckBox();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_openWeb = new System.Windows.Forms.Button();
            this.tb_entropy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_numCh = new System.Windows.Forms.TextBox();
            this.gb_language.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(12, 12);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(548, 582);
            this.tb_text.TabIndex = 0;
            this.tb_text.Text = "";
            // 
            // gb_language
            // 
            this.gb_language.Controls.Add(this.cb_uk);
            this.gb_language.Controls.Add(this.cb_punctuation);
            this.gb_language.Controls.Add(this.cb_en);
            this.gb_language.Controls.Add(this.cb_ru);
            this.gb_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_language.Location = new System.Drawing.Point(577, 13);
            this.gb_language.Name = "gb_language";
            this.gb_language.Size = new System.Drawing.Size(487, 62);
            this.gb_language.TabIndex = 1;
            this.gb_language.TabStop = false;
            this.gb_language.Text = "What count?";
            // 
            // cb_uk
            // 
            this.cb_uk.AutoSize = true;
            this.cb_uk.Location = new System.Drawing.Point(247, 33);
            this.cb_uk.Name = "cb_uk";
            this.cb_uk.Size = new System.Drawing.Size(84, 20);
            this.cb_uk.TabIndex = 4;
            this.cb_uk.Text = "Ukrainian";
            this.cb_uk.UseVisualStyleBackColor = true;
            // 
            // cb_punctuation
            // 
            this.cb_punctuation.AutoSize = true;
            this.cb_punctuation.Location = new System.Drawing.Point(375, 33);
            this.cb_punctuation.Name = "cb_punctuation";
            this.cb_punctuation.Size = new System.Drawing.Size(96, 20);
            this.cb_punctuation.TabIndex = 3;
            this.cb_punctuation.Text = "Punctuation";
            this.cb_punctuation.UseVisualStyleBackColor = true;
            // 
            // cb_en
            // 
            this.cb_en.AutoSize = true;
            this.cb_en.Location = new System.Drawing.Point(141, 33);
            this.cb_en.Name = "cb_en";
            this.cb_en.Size = new System.Drawing.Size(71, 20);
            this.cb_en.TabIndex = 2;
            this.cb_en.Text = "English";
            this.cb_en.UseVisualStyleBackColor = true;
            // 
            // cb_ru
            // 
            this.cb_ru.AutoSize = true;
            this.cb_ru.Location = new System.Drawing.Point(18, 33);
            this.cb_ru.Name = "cb_ru";
            this.cb_ru.Size = new System.Drawing.Size(76, 20);
            this.cb_ru.TabIndex = 1;
            this.cb_ru.Text = "Russian";
            this.cb_ru.UseVisualStyleBackColor = true;
            // 
            // tb_result
            // 
            this.tb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_result.Location = new System.Drawing.Point(9, 56);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(143, 183);
            this.tb_result.TabIndex = 2;
            this.tb_result.Text = "";
            // 
            // b_result
            // 
            this.b_result.BackColor = System.Drawing.Color.DarkOrange;
            this.b_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_result.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_result.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_result.Location = new System.Drawing.Point(966, 291);
            this.b_result.Name = "b_result";
            this.b_result.Size = new System.Drawing.Size(98, 40);
            this.b_result.TabIndex = 4;
            this.b_result.Text = "To count";
            this.b_result.UseVisualStyleBackColor = false;
            this.b_result.Click += new System.EventHandler(this.b_result_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_numCh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_entropy);
            this.groupBox1.Controls.Add(this.tb_qualInf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_result);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(577, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // tb_qualInf
            // 
            this.tb_qualInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_qualInf.Location = new System.Drawing.Point(260, 40);
            this.tb_qualInf.Multiline = true;
            this.tb_qualInf.Name = "tb_qualInf";
            this.tb_qualInf.Size = new System.Drawing.Size(143, 30);
            this.tb_qualInf.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity of information";
//            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letter";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(583, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Count from site";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_website
            // 
            this.tb_website.Location = new System.Drawing.Point(762, 115);
            this.tb_website.Name = "tb_website";
            this.tb_website.Size = new System.Drawing.Size(302, 20);
            this.tb_website.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(759, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter website";
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(715, 212);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 16);
            this.l_error.TabIndex = 9;
            // 
            // b_sort
            // 
            this.b_sort.BackColor = System.Drawing.Color.SeaShell;
            this.b_sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_sort.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_sort.Location = new System.Drawing.Point(577, 291);
            this.b_sort.Name = "b_sort";
            this.b_sort.Size = new System.Drawing.Size(98, 38);
            this.b_sort.TabIndex = 10;
            this.b_sort.Text = "Sort";
            this.b_sort.UseVisualStyleBackColor = false;
            this.b_sort.Click += new System.EventHandler(this.b_sort_Click);
            // 
            // cb_symb
            // 
            this.cb_symb.AutoSize = true;
            this.cb_symb.Location = new System.Drawing.Point(681, 291);
            this.cb_symb.Name = "cb_symb";
            this.cb_symb.Size = new System.Drawing.Size(77, 17);
            this.cb_symb.TabIndex = 11;
            this.cb_symb.Text = "by symbols";
            this.cb_symb.UseVisualStyleBackColor = true;
            // 
            // cb_val
            // 
            this.cb_val.AutoSize = true;
            this.cb_val.Location = new System.Drawing.Point(681, 314);
            this.cb_val.Name = "cb_val";
            this.cb_val.Size = new System.Drawing.Size(71, 17);
            this.cb_val.TabIndex = 12;
            this.cb_val.Text = "by values";
            this.cb_val.UseVisualStyleBackColor = true;
            // 
            // b_clear
            // 
            this.b_clear.BackColor = System.Drawing.Color.Linen;
            this.b_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_clear.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_clear.Location = new System.Drawing.Point(577, 152);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(98, 38);
            this.b_clear.TabIndex = 13;
            this.b_clear.Text = "Clear";
            this.b_clear.UseVisualStyleBackColor = false;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // b_openWeb
            // 
            this.b_openWeb.BackColor = System.Drawing.Color.Linen;
            this.b_openWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_openWeb.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_openWeb.Location = new System.Drawing.Point(966, 152);
            this.b_openWeb.Name = "b_openWeb";
            this.b_openWeb.Size = new System.Drawing.Size(98, 38);
            this.b_openWeb.TabIndex = 15;
            this.b_openWeb.Text = "Open Site";
            this.b_openWeb.UseVisualStyleBackColor = false;
            this.b_openWeb.Click += new System.EventHandler(this.b_openWeb_Click);
            // 
            // tb_entropy
            // 
            this.tb_entropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_entropy.Location = new System.Drawing.Point(260, 121);
            this.tb_entropy.Multiline = true;
            this.tb_entropy.Name = "tb_entropy";
            this.tb_entropy.Size = new System.Drawing.Size(143, 30);
            this.tb_entropy.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Entropy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of characters";
            // 
            // tb_numCh
            // 
            this.tb_numCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_numCh.Location = new System.Drawing.Point(260, 209);
            this.tb_numCh.Multiline = true;
            this.tb_numCh.Name = "tb_numCh";
            this.tb_numCh.Size = new System.Drawing.Size(143, 30);
            this.tb_numCh.TabIndex = 12;
            // 
            // TextAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 606);
            this.Controls.Add(this.b_openWeb);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.cb_val);
            this.Controls.Add(this.cb_symb);
            this.Controls.Add(this.b_sort);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_website);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_result);
            this.Controls.Add(this.gb_language);
            this.Controls.Add(this.tb_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextAnalyzer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextAnalyzer";
            this.Load += new System.EventHandler(this.TextAnalyzer_Load);
            this.gb_language.ResumeLayout(false);
            this.gb_language.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_text;
        private System.Windows.Forms.GroupBox gb_language;
        private System.Windows.Forms.CheckBox cb_en;
        private System.Windows.Forms.CheckBox cb_ru;
        private System.Windows.Forms.RichTextBox tb_result;
        private System.Windows.Forms.Button b_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb_website;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.Button b_sort;
        private System.Windows.Forms.CheckBox cb_punctuation;
        private System.Windows.Forms.CheckBox cb_symb;
        private System.Windows.Forms.CheckBox cb_val;
        private System.Windows.Forms.CheckBox cb_uk;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.TextBox tb_qualInf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_openWeb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_entropy;
        private System.Windows.Forms.TextBox tb_numCh;
        private System.Windows.Forms.Label label6;
    }
}

