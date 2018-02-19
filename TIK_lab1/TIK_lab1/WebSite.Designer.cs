namespace TIK_lab1
{
    partial class WebSite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebSite));
            this.b_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.b_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.Color.PeachPuff;
            this.b_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_search.Location = new System.Drawing.Point(1076, 12);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(130, 40);
            this.b_search.TabIndex = 0;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = false;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(26, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1010, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(26, 59);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1332, 678);
            this.webBrowser1.TabIndex = 2;
            // 
            // b_copy
            // 
            this.b_copy.BackColor = System.Drawing.Color.SandyBrown;
            this.b_copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_copy.Location = new System.Drawing.Point(1236, 13);
            this.b_copy.Name = "b_copy";
            this.b_copy.Size = new System.Drawing.Size(122, 40);
            this.b_copy.TabIndex = 3;
            this.b_copy.Text = "Copy";
            this.b_copy.UseVisualStyleBackColor = false;
            this.b_copy.Click += new System.EventHandler(this.b_copy_Click);
            // 
            // WebSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 645);
            this.Controls.Add(this.b_copy);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebSite";
            this.Load += new System.EventHandler(this.WebSite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button b_copy;
    }
}