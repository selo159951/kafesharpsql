using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafesharpaql
{
    public partial class admin_giris : Form
    {
        private int remainingAttempts = 3; 
        private DateTime lockoutEndTime; 
        private bool isLocked = false; 
        public admin_giris()
        {
            InitializeComponent();
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            ana_menu_giris geri = new ana_menu_giris();
            geri.Show();
            this.Hide();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            if (isLocked)
            {
                TimeSpan remainingTime = lockoutEndTime - DateTime.Now;
                MessageBox.Show($"Lütfen {remainingTime.Seconds} saniye bekleyin!", "Giriş Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string correctUsername = "admin";  // Doğru kullanıcı adı
            string correctPassword = "admin"; // Doğru şifre

            string enteredUsername = kullanicitxt.Text;
            string enteredPassword = sifretxt.Text;

            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                MessageBox.Show("Giriş başarılı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                durumlbl.Text = "Durum: Giriş başarılı!";
                remainingAttempts = 3; // Hakkı sıfırla
                admin_panel panel = new admin_panel();
                this.Hide();
                panel.Show();
            }
            else
            {
                remainingAttempts--;
                durumlbl.Text = $"Durum: Hatalı giriş! Kalan hakkınız: {remainingAttempts}";

                if (remainingAttempts == 0)
                {
                    isLocked = true;
                    lockoutEndTime = DateTime.Now.AddMinutes(1);
                    girisbtn.Enabled = false; // Butonu devre dışı bırak
                    loginTimer.Start(); // Timer başlasın
                    MessageBox.Show("Çok fazla yanlış giriş yaptınız! Lütfen 1 dakika bekleyin.", "Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= lockoutEndTime)
            {
                isLocked = false;
                remainingAttempts = 3;
                girisbtn.Enabled = true;
                durumlbl.Text = "Durum: Bekleniyor...";
                loginTimer.Stop(); // Timer durdur
            }
            else
            {
                TimeSpan remainingTime = lockoutEndTime - DateTime.Now;
                durumlbl.Text = $"Durum: Kilitlendi - {remainingTime.Seconds} saniye kaldı!";
            }
        }
    }
}
