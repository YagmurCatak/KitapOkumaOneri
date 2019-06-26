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
    public partial class KitapOkuma : Form
    {
        public KitapOkuma()
        {
            InitializeComponent();
            pdf.LoadFile("C:\\Users\\Yagmur\\Desktop\\yazlabprojeleri\\Yazılım_Lab_I\\Kohlbergin Bilişsel Ahlak Gelişimi.pdf");
        }
        
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Kitaplar kitapListele = new Kitaplar();
            kitapListele.Show();
            this.Hide();
        }
    }
}