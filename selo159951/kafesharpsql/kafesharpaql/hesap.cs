using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
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
    public partial class hesap : Form
    {
        public hesap()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Database=kafesharp;User ID=root;Password=112233;";



        private void hesap_Load(object sender, EventArgs e)
        {
            mailcmb.SelectedItem = "@gmail.com";
            hesapclass hsp = new hesapclass();
            epostatxt.Text = hsp.mailisim;
            string giris_yapilan_mail = hsp.mailisim;

        }

        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            hesapclass hspa = new hesapclass();
            string giris_yapilan_mail = hspa.mailisim;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Yeni e-posta adresini al
                    string newEmail = epostatxt.Text.Trim() + mailcmb.SelectedItem.ToString();

                    // Güncellenecek eski e-posta (oturum açmış olan)
                    string currentEmail = giris_yapilan_mail;

                    // Güncelleme sorgusu
                    string updateQuery = "UPDATE users SET email = @newEmail WHERE email = @currentEmail";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newEmail", newEmail);
                        command.Parameters.AddWithValue("@currentEmail", currentEmail);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("E-posta başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            giris_yapilan_mail = newEmail;  // Yeni e-postayı oturum değişkenine kaydet
                        }
                        else
                        {
                            MessageBox.Show("E-posta güncellenemedi. Eski e-posta bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
