namespace kafesharpaql
{
    partial class admin_giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_giris));
            this.isimlbl = new System.Windows.Forms.Label();
            this.kullanicitxt = new System.Windows.Forms.TextBox();
            this.girisbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.geridonbtn = new System.Windows.Forms.Button();
            this.durumlbl = new System.Windows.Forms.Label();
            this.loginTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // isimlbl
            // 
            this.isimlbl.AutoSize = true;
            this.isimlbl.Location = new System.Drawing.Point(84, 80);
            this.isimlbl.Name = "isimlbl";
            this.isimlbl.Size = new System.Drawing.Size(70, 13);
            this.isimlbl.TabIndex = 8;
            this.isimlbl.Text = "Kullanıcı Adı :";
            // 
            // kullanicitxt
            // 
            this.kullanicitxt.Location = new System.Drawing.Point(174, 77);
            this.kullanicitxt.Name = "kullanicitxt";
            this.kullanicitxt.Size = new System.Drawing.Size(100, 20);
            this.kullanicitxt.TabIndex = 7;
            // 
            // girisbtn
            // 
            this.girisbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.girisbtn.FlatAppearance.BorderSize = 0;
            this.girisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisbtn.ForeColor = System.Drawing.Color.White;
            this.girisbtn.Location = new System.Drawing.Point(139, 194);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(75, 23);
            this.girisbtn.TabIndex = 6;
            this.girisbtn.Text = "Giriş";
            this.girisbtn.UseVisualStyleBackColor = false;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Şifreniz";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(174, 122);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 20);
            this.sifretxt.TabIndex = 9;
            // 
            // geridonbtn
            // 
            this.geridonbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.geridonbtn.FlatAppearance.BorderSize = 0;
            this.geridonbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geridonbtn.ForeColor = System.Drawing.Color.White;
            this.geridonbtn.Location = new System.Drawing.Point(12, 287);
            this.geridonbtn.Name = "geridonbtn";
            this.geridonbtn.Size = new System.Drawing.Size(75, 23);
            this.geridonbtn.TabIndex = 11;
            this.geridonbtn.Text = "Geri Dön";
            this.geridonbtn.UseVisualStyleBackColor = false;
            this.geridonbtn.Click += new System.EventHandler(this.geridonbtn_Click);
            // 
            // durumlbl
            // 
            this.durumlbl.AutoSize = true;
            this.durumlbl.Location = new System.Drawing.Point(84, 164);
            this.durumlbl.Name = "durumlbl";
            this.durumlbl.Size = new System.Drawing.Size(50, 13);
            this.durumlbl.TabIndex = 12;
            this.durumlbl.Text = "Durum : -";
            // 
            // loginTimer
            // 
            this.loginTimer.Interval = 1000;
            this.loginTimer.Tick += new System.EventHandler(this.loginTimer_Tick);
            // 
            // admin_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(380, 322);
            this.Controls.Add(this.durumlbl);
            this.Controls.Add(this.geridonbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.isimlbl);
            this.Controls.Add(this.kullanicitxt);
            this.Controls.Add(this.girisbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label isimlbl;
        private System.Windows.Forms.TextBox kullanicitxt;
        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button geridonbtn;
        private System.Windows.Forms.Label durumlbl;
        private System.Windows.Forms.Timer loginTimer;
    }
}