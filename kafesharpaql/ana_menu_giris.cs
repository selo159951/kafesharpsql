using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace kafesharpaql
{
    public partial class ana_menu_giris : Form
    {
        public ana_menu_giris()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Database=kafesharp;User ID=root;Password=112233;";
        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            string loggedInUser = null; // Giriş yapılan kullanıcıyı tutacak değişken
            int userid;

            while (true)
            {
                if (string.IsNullOrWhiteSpace(isimtxt.Text) || string.IsNullOrWhiteSpace(mailtxt.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string isim = isimtxt.Text.Trim();
                    string email = mailtxt.Text.Trim() + mailcmb.SelectedItem;
                    

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Kullanıcının var olup olmadığını kontrol et
                            string checkQuery = "SELECT id FROM users WHERE isim = @isim OR email = @email";
                            using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@isim", isim);
                                checkCommand.Parameters.AddWithValue("@email", email);

                                object result = checkCommand.ExecuteScalar();
                                if (result != null)
                                {
                                    hesapclass user = new hesapclass();
                                    // Kullanıcı bilgilerini UserSession'a kaydet
                                    userid = Convert.ToInt32(result); // Kullanıcının ID'sini al

                                    user.UserName = isim; // Kullanıcı ismi
                                    user.UserEmail = email; // Kullanıcı emaili
                                    user.mailisim = mailtxt.Text.Trim();
                                    user.UserId = userid; // Kullanıcı ID'si
                                    // Kullanıcı zaten mevcut, giriş yap
                                    loggedInUser = isim; // Giriş yapılan ismi değişkene ata
                                    MessageBox.Show("Giriş başarılı! Hoş geldiniz, " + loggedInUser, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ana_menu anamenu = new ana_menu(); // ID'yi ana menüye gönder
                                    isimtxt.Clear();
                                    mailtxt.Clear();
                                    anamenu.Show();
                                    this.Hide();
                                    return; // Giriş yapıldı, işlemi sonlandır
                                }

                            }



                            // Kullanıcıyı ekle
                            string insertQuery = "INSERT INTO users (isim, email) VALUES (@isim, @email)";
                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@isim", isim);
                                insertCommand.Parameters.AddWithValue("@email", email);

                                int rowsAffected = insertCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    hesapclass user = new hesapclass();
                                    // Kullanıcı bilgilerini UserSession'a kaydet

                                    user.UserId = userid; // Kullanıcı ID'si
                                    user.UserName = isim; // Kullanıcı ismi
                                    user.UserEmail = email; // Kullanıcı emaili
                                    user.mailisim = mailtxt.Text.Trim();

                                    MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    isimtxt.Clear();
                                    mailtxt.Clear();
                                    ana_menu anamenu = new ana_menu();
                                    anamenu.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                }
            }



           



            
            

        }

        private void ana_menu_giris_Load(object sender, EventArgs e)
        {
            mailcmb.SelectedItem = "@gmail.com";
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            admin_giris admin = new admin_giris();
            admin.Show();
            this.Hide();
        }
    }
    
}
