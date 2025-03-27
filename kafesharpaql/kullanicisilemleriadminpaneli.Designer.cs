namespace kafesharpaql
{
    partial class kullanicisilemleriadminpaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanicisilemleriadminpaneli));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yenilebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.kullanicilar = new System.Windows.Forms.DataGridView();
            this.kullanicisilmegroup = new System.Windows.Forms.GroupBox();
            this.mailcmb = new System.Windows.Forms.ComboBox();
            this.maillbl = new System.Windows.Forms.Label();
            this.isimtxt = new System.Windows.Forms.TextBox();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.kullanıcıeklebtn = new System.Windows.Forms.Button();
            this.isimlbl = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilar)).BeginInit();
            this.kullanicisilmegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yenilebtn);
            this.groupBox2.Controls.Add(this.silbtn);
            this.groupBox2.Controls.Add(this.kullanicilar);
            this.groupBox2.Location = new System.Drawing.Point(32, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 315);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Silme";
            // 
            // yenilebtn
            // 
            this.yenilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.yenilebtn.FlatAppearance.BorderSize = 0;
            this.yenilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenilebtn.ForeColor = System.Drawing.Color.White;
            this.yenilebtn.Location = new System.Drawing.Point(32, 275);
            this.yenilebtn.Name = "yenilebtn";
            this.yenilebtn.Size = new System.Drawing.Size(75, 23);
            this.yenilebtn.TabIndex = 1;
            this.yenilebtn.Text = "Yenile";
            this.yenilebtn.UseVisualStyleBackColor = false;
            this.yenilebtn.Click += new System.EventHandler(this.yenilebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.silbtn.FlatAppearance.BorderSize = 0;
            this.silbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silbtn.ForeColor = System.Drawing.Color.White;
            this.silbtn.Location = new System.Drawing.Point(126, 275);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(75, 23);
            this.silbtn.TabIndex = 1;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = false;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // kullanicilar
            // 
            this.kullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.kullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanicilar.Location = new System.Drawing.Point(32, 19);
            this.kullanicilar.Name = "kullanicilar";
            this.kullanicilar.Size = new System.Drawing.Size(435, 225);
            this.kullanicilar.TabIndex = 0;
            // 
            // kullanicisilmegroup
            // 
            this.kullanicisilmegroup.Controls.Add(this.mailcmb);
            this.kullanicisilmegroup.Controls.Add(this.maillbl);
            this.kullanicisilmegroup.Controls.Add(this.isimtxt);
            this.kullanicisilmegroup.Controls.Add(this.mailtxt);
            this.kullanicisilmegroup.Controls.Add(this.kullanıcıeklebtn);
            this.kullanicisilmegroup.Controls.Add(this.isimlbl);
            this.kullanicisilmegroup.Location = new System.Drawing.Point(590, 40);
            this.kullanicisilmegroup.Name = "kullanicisilmegroup";
            this.kullanicisilmegroup.Size = new System.Drawing.Size(361, 189);
            this.kullanicisilmegroup.TabIndex = 2;
            this.kullanicisilmegroup.TabStop = false;
            this.kullanicisilmegroup.Text = "Kullanıcı Ekleme";
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
            this.mailcmb.Location = new System.Drawing.Point(216, 81);
            this.mailcmb.Name = "mailcmb";
            this.mailcmb.Size = new System.Drawing.Size(121, 21);
            this.mailcmb.TabIndex = 10;
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Location = new System.Drawing.Point(6, 88);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(83, 13);
            this.maillbl.TabIndex = 9;
            this.maillbl.Text = "Email Adresiniz :";
            // 
            // isimtxt
            // 
            this.isimtxt.Location = new System.Drawing.Point(124, 42);
            this.isimtxt.Name = "isimtxt";
            this.isimtxt.Size = new System.Drawing.Size(114, 20);
            this.isimtxt.TabIndex = 6;
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(124, 81);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(86, 20);
            this.mailtxt.TabIndex = 8;
            // 
            // kullanıcıeklebtn
            // 
            this.kullanıcıeklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.kullanıcıeklebtn.FlatAppearance.BorderSize = 0;
            this.kullanıcıeklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanıcıeklebtn.ForeColor = System.Drawing.Color.White;
            this.kullanıcıeklebtn.Location = new System.Drawing.Point(133, 139);
            this.kullanıcıeklebtn.Name = "kullanıcıeklebtn";
            this.kullanıcıeklebtn.Size = new System.Drawing.Size(75, 23);
            this.kullanıcıeklebtn.TabIndex = 5;
            this.kullanıcıeklebtn.Text = "Oluştur";
            this.kullanıcıeklebtn.UseVisualStyleBackColor = false;
            this.kullanıcıeklebtn.Click += new System.EventHandler(this.kullanıcıeklebtn_Click);
            // 
            // isimlbl
            // 
            this.isimlbl.AutoSize = true;
            this.isimlbl.Location = new System.Drawing.Point(17, 45);
            this.isimlbl.Name = "isimlbl";
            this.isimlbl.Size = new System.Drawing.Size(44, 13);
            this.isimlbl.TabIndex = 7;
            this.isimlbl.Text = "İsminiz :";
            // 
            // kullanicisilemleriadminpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1030, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.kullanicisilmegroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullanicisilemleriadminpaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.kullanicisilemleriadminpaneli_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilar)).EndInit();
            this.kullanicisilmegroup.ResumeLayout(false);
            this.kullanicisilmegroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button yenilebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.DataGridView kullanicilar;
        private System.Windows.Forms.GroupBox kullanicisilmegroup;
        private System.Windows.Forms.ComboBox mailcmb;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.TextBox isimtxt;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.Button kullanıcıeklebtn;
        private System.Windows.Forms.Label isimlbl;
    }
}