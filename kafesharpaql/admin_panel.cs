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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }
        string connectionString = DatabaseHelper.ConnectionString;

        private void admin_panel_Load(object sender, EventArgs e)
        {
            





        }

        
        

        

        

        private void admin_panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin_giris giris = new admin_giris();
            this.Hide();
            giris.Show();
        }

        

        private void kullanicibtn_Click(object sender, EventArgs e)
        {
            kullanicisilemleriadminpaneli kullanici = new kullanicisilemleriadminpaneli();
            kullanici.ShowDialog();
            this.Hide();
        }
    }
}
