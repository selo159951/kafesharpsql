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
    public partial class ana_menu : Form
    {
        public ana_menu()
        {
            InitializeComponent();
        }

        private void alısverispicturebox_Click(object sender, EventArgs e)
        {

        }

        private void hesapbtn_Click(object sender, EventArgs e)
        {
            hesap hesap = new hesap();
            hesap.Show();
            this.Hide();
        }
    }
}
