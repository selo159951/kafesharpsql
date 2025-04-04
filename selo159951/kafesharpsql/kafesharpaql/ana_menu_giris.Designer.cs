namespace kafesharpaql
{
    partial class ana_menu_giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ana_menu_giris));
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.isimtxt = new System.Windows.Forms.TextBox();
            this.isimlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.mailcmb = new System.Windows.Forms.ComboBox();
            this.adminbtn = new System.Windows.Forms.Button();
            this.renkpalet = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.kaydetbtn.FlatAppearance.BorderSize = 0;
            this.kaydetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetbtn.ForeColor = System.Drawing.Color.White;
            this.kaydetbtn.Location = new System.Drawing.Point(172, 204);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 0;
            this.kaydetbtn.Text = "Giriş";
            this.kaydetbtn.UseVisualStyleBackColor = false;
            // 
            // isimtxt
            // 
            this.isimtxt.Location = new System.Drawing.Point(159, 101);
            this.isimtxt.Name = "isimtxt";
            this.isimtxt.Size = new System.Drawing.Size(100, 20);
            this.isimtxt.TabIndex = 1;
            // 
            // isimlbl
            // 
            this.isimlbl.AutoSize = true;
            this.isimlbl.Location = new System.Drawing.Point(69, 104);
            this.isimlbl.Name = "isimlbl";
            this.isimlbl.Size = new System.Drawing.Size(44, 13);
            this.isimlbl.TabIndex = 2;
            this.isimlbl.Text = "İsminiz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mail Adresiniz :";
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(159, 140);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(100, 20);
            this.mailtxt.TabIndex = 3;
            // 
            // mailcmb
            // 
            this.mailcmb.FormattingEnabled = true;
            this.mailcmb.Items.AddRange(new object[] {
            "@gmail.com",
            "@yandex.com",
            "@yahoo.com",
            "@outlook.com",
            "@hotmail.com"});
            this.mailcmb.Location = new System.Drawing.Point(265, 140);
            this.mailcmb.Name = "mailcmb";
            this.mailcmb.Size = new System.Drawing.Size(95, 21);
            this.mailcmb.TabIndex = 5;
            // 
            // adminbtn
            // 
            this.adminbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.adminbtn.FlatAppearance.BorderSize = 0;
            this.adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminbtn.ForeColor = System.Drawing.Color.White;
            this.adminbtn.Location = new System.Drawing.Point(352, 12);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(75, 23);
            this.adminbtn.TabIndex = 6;
            this.adminbtn.Text = "Admin Girişi";
            this.adminbtn.UseVisualStyleBackColor = false;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // ana_menu_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(439, 282);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.mailcmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailtxt);
            this.Controls.Add(this.isimlbl);
            this.Controls.Add(this.isimtxt);
            this.Controls.Add(this.kaydetbtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ana_menu_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.ana_menu_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.TextBox isimtxt;
        private System.Windows.Forms.Label isimlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.ComboBox mailcmb;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.ColorDialog renkpalet;
    }
}

