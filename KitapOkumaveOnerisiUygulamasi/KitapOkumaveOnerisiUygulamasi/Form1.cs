using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapOkumaveOnerisiUygulamasi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnOturumac_Click(object sender, EventArgs e)
        {
            OturumAc oturum = new OturumAc();
            oturum.Show();
            this.Hide();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOl UyeOl = new UyeOl();
            UyeOl.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
