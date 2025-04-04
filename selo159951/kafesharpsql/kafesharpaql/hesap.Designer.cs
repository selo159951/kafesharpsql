namespace kafesharpaql
{
    partial class hesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesap));
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.Kaydetbtn = new System.Windows.Forms.Button();
            this.epostalbl = new System.Windows.Forms.Label();
            this.izincheckbox = new System.Windows.Forms.CheckBox();
            this.mailcmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(95, 42);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(100, 20);
            this.epostatxt.TabIndex = 0;
            // 
            // Kaydetbtn
            // 
            this.Kaydetbtn.Location = new System.Drawing.Point(108, 170);
            this.Kaydetbtn.Name = "Kaydetbtn";
            this.Kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.Kaydetbtn.TabIndex = 1;
            this.Kaydetbtn.Text = "Kaydet";
            this.Kaydetbtn.UseVisualStyleBackColor = true;
            this.Kaydetbtn.Click += new System.EventHandler(this.Kaydetbtn_Click);
            // 
            // epostalbl
            // 
            this.epostalbl.AutoSize = true;
            this.epostalbl.Location = new System.Drawing.Point(8, 45);
            this.epostalbl.Name = "epostalbl";
            this.epostalbl.Size = new System.Drawing.Size(81, 13);
            this.epostalbl.TabIndex = 2;
            this.epostalbl.Text = "Güncel E-Posta";
            // 
            // izincheckbox
            // 
            this.izincheckbox.AutoSize = true;
            this.izincheckbox.Checked = true;
            this.izincheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.izincheckbox.Location = new System.Drawing.Point(107, 93);
            this.izincheckbox.Name = "izincheckbox";
            this.izincheckbox.Size = new System.Drawing.Size(76, 17);
            this.izincheckbox.TabIndex = 3;
            this.izincheckbox.Text = "İletişim İzni";
            this.izincheckbox.UseVisualStyleBackColor = true;
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
            this.mailcmb.Location = new System.Drawing.Point(202, 40);
            this.mailcmb.Name = "mailcmb";
            this.mailcmb.Size = new System.Drawing.Size(96, 21);
            this.mailcmb.TabIndex = 4;
            // 
            // hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(310, 266);
            this.Controls.Add(this.mailcmb);
            this.Controls.Add(this.izincheckbox);
            this.Controls.Add(this.epostalbl);
            this.Controls.Add(this.Kaydetbtn);
            this.Controls.Add(this.epostatxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap";
            this.Load += new System.EventHandler(this.hesap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.Button Kaydetbtn;
        private System.Windows.Forms.Label epostalbl;
        private System.Windows.Forms.CheckBox izincheckbox;
        private System.Windows.Forms.ComboBox mailcmb;
    }
}