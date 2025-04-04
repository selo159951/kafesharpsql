namespace kafesharpaql
{
    partial class admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            this.kullanicibtn = new System.Windows.Forms.Button();
            this.indirimbtn = new System.Windows.Forms.Button();
            this.urunislembtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullanicibtn
            // 
            this.kullanicibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.kullanicibtn.FlatAppearance.BorderSize = 0;
            this.kullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanicibtn.ForeColor = System.Drawing.Color.White;
            this.kullanicibtn.Location = new System.Drawing.Point(161, 47);
            this.kullanicibtn.Name = "kullanicibtn";
            this.kullanicibtn.Size = new System.Drawing.Size(146, 39);
            this.kullanicibtn.TabIndex = 2;
            this.kullanicibtn.Text = "Kullanıcı İşlemleri";
            this.kullanicibtn.UseVisualStyleBackColor = false;
            this.kullanicibtn.Click += new System.EventHandler(this.kullanicibtn_Click);
            // 
            // indirimbtn
            // 
            this.indirimbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.indirimbtn.FlatAppearance.BorderSize = 0;
            this.indirimbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indirimbtn.ForeColor = System.Drawing.Color.White;
            this.indirimbtn.Location = new System.Drawing.Point(161, 157);
            this.indirimbtn.Name = "indirimbtn";
            this.indirimbtn.Size = new System.Drawing.Size(146, 39);
            this.indirimbtn.TabIndex = 3;
            this.indirimbtn.Text = "İndirim Kodu İşlemleri";
            this.indirimbtn.UseVisualStyleBackColor = false;
            // 
            // urunislembtn
            // 
            this.urunislembtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.urunislembtn.FlatAppearance.BorderSize = 0;
            this.urunislembtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunislembtn.ForeColor = System.Drawing.Color.White;
            this.urunislembtn.Location = new System.Drawing.Point(161, 103);
            this.urunislembtn.Name = "urunislembtn";
            this.urunislembtn.Size = new System.Drawing.Size(146, 39);
            this.urunislembtn.TabIndex = 4;
            this.urunislembtn.Text = "Ürün İşlemleri";
            this.urunislembtn.UseVisualStyleBackColor = false;
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(503, 274);
            this.Controls.Add(this.urunislembtn);
            this.Controls.Add(this.indirimbtn);
            this.Controls.Add(this.kullanicibtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_panel_FormClosing);
            this.Load += new System.EventHandler(this.admin_panel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kullanicibtn;
        private System.Windows.Forms.Button indirimbtn;
        private System.Windows.Forms.Button urunislembtn;
    }
}