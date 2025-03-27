using MySql.Data.MySqlClient;
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
    public partial class kullanicisilemleriadminpaneli : Form
    {
        public kullanicisilemleriadminpaneli()
        {
            InitializeComponent();
        }
        string connectionString = DatabaseHelper.ConnectionString;

        private void kullanıcıeklebtn_Click(object sender, EventArgs e)
        {
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
                            string query = "INSERT INTO users (isim, email) VALUES (@isim, @email)";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                // Parametreleri ekleyelim (SQL Injection'a karşı önlem)
                                command.Parameters.AddWithValue("@isim", isim);
                                command.Parameters.AddWithValue("@email", email);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    isimtxt.Clear();
                                    mailtxt.Clear();
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
        private void VerileriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM kafesharp.users"; // MySQL'den tüm verileri çek
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    kullanicilar.DataSource = dt; // DataGridView'e verileri aktar
                }
                conn.Close();
            }
        }

        private void yenilebtn_Click(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            if (kullanicilar.SelectedRows.Count > 0) // Seçili satır var mı kontrol et
            {
                int selectedId = Convert.ToInt32(kullanicilar.SelectedRows[0].Cells["id"].Value); // ID sütunundan al

                DialogResult dialogResult = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM kafesharp.users WHERE id = @id"; // SQL silme sorgusu
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }

                    MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VerileriGetir(); // DataGridView güncellenmeli
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kullanicisilemleriadminpaneli_Load(object sender, EventArgs e)
        {
            mailcmb.SelectedItem = "@gmail.com";
            VerileriGetir();
        }
    }
}
