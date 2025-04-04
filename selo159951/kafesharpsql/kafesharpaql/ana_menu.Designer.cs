namespace kafesharpaql
{
    partial class ana_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ana_menu));
            this.hesapbtn = new System.Windows.Forms.Button();
            this.bilgilergroup = new System.Windows.Forms.GroupBox();
            this.istatistik2 = new System.Windows.Forms.Label();
            this.istatistik1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alısverispicturebox = new System.Windows.Forms.PictureBox();
            this.bilgilergroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alısverispicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // hesapbtn
            // 
            this.hesapbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.hesapbtn.FlatAppearance.BorderSize = 0;
            this.hesapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesapbtn.ForeColor = System.Drawing.Color.White;
            this.hesapbtn.Location = new System.Drawing.Point(713, 12);
            this.hesapbtn.Name = "hesapbtn";
            this.hesapbtn.Size = new System.Drawing.Size(75, 23);
            this.hesapbtn.TabIndex = 0;
            this.hesapbtn.Text = "Hesap";
            this.hesapbtn.UseVisualStyleBackColor = false;
            this.hesapbtn.Click += new System.EventHandler(this.hesapbtn_Click);
            // 
            // bilgilergroup
            // 
            this.bilgilergroup.Controls.Add(this.label2);
            this.bilgilergroup.Controls.Add(this.istatistik1);
            this.bilgilergroup.Controls.Add(this.istatistik2);
            this.bilgilergroup.Location = new System.Drawing.Point(405, 35);
            this.bilgilergroup.Name = "bilgilergroup";
            this.bilgilergroup.Size = new System.Drawing.Size(355, 358);
            this.bilgilergroup.TabIndex = 2;
            this.bilgilergroup.TabStop = false;
            this.bilgilergroup.Text = "İstatikler";
            // 
            // istatistik2
            // 
            this.istatistik2.AutoSize = true;
            this.istatistik2.Location = new System.Drawing.Point(44, 89);
            this.istatistik2.Name = "istatistik2";
            this.istatistik2.Size = new System.Drawing.Size(136, 13);
            this.istatistik2.TabIndex = 0;
            this.istatistik2.Text = "Toplam Alınan Ürün Sayısı :";
            // 
            // istatistik1
            // 
            this.istatistik1.AutoSize = true;
            this.istatistik1.Location = new System.Drawing.Point(44, 47);
            this.istatistik1.Name = "istatistik1";
            this.istatistik1.Size = new System.Drawing.Size(110, 13);
            this.istatistik1.TabIndex = 0;
            this.istatistik1.Text = "Toplam Harcanan Tl :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İndirim Kodu Kazanmaya Son : .... (+100 TL Alışveriş)";
            // 
            // alısverispicturebox
            // 
            this.alısverispicturebox.Image = global::kafesharpaql.Properties.Resources.alisverispng;
            this.alısverispicturebox.Location = new System.Drawing.Point(12, 35);
            this.alısverispicturebox.Name = "alısverispicturebox";
            this.alısverispicturebox.Size = new System.Drawing.Size(332, 358);
            this.alısverispicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alısverispicturebox.TabIndex = 3;
            this.alısverispicturebox.TabStop = false;
            this.alısverispicturebox.Click += new System.EventHandler(this.alısverispicturebox_Click);
            // 
            // ana_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alısverispicturebox);
            this.Controls.Add(this.bilgilergroup);
            this.Controls.Add(this.hesapbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ana_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.bilgilergroup.ResumeLayout(false);
            this.bilgilergroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alısverispicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hesapbtn;
        private System.Windows.Forms.GroupBox bilgilergroup;
        private System.Windows.Forms.PictureBox alısverispicturebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label istatistik1;
        private System.Windows.Forms.Label istatistik2;
    }
}