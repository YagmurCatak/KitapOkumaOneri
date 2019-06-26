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

namespace KitapOkumaveOnerisiUygulamasi
{
    public partial class YöneticiPaneli : Form
    {
        public YöneticiPaneli()
        {
            InitializeComponent();
            KitaplarıListele();
            KullaniciListele();
        }

        public static string kitapisbn ;
        public string baglanti = "Server=localhost;Database=booksdatabase;port=3306;persistsecurityinfo=True;SslMode=none;Uid=root;Pwd='1234';";

        private void btnOturumAC_Click(object sender, EventArgs e)
        {
            OturumAc oturum = new OturumAc();
            oturum.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in grdKitap.SelectedRows)  //Seçili Satırları Silme
            {
                string isbn = (drow.Cells[3].Value).ToString();
                KitapSil(isbn);
                KitaplarıListele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int Flag= 0;
            Flag = Kontrol();

            if (Flag != 1)
            {
                kitapisbn = KitapEkle();
                KitaplarıListele();
                texttemizle();
            }
        }

        
        public void texttemizle()
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtResim.Clear();
            txtYayın.Clear();
            txtYayimci.Clear();
            txtisbn.Clear();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            ResimDosyaYoluBelirle();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in grdKullanici.SelectedRows)  //Seçili Satırları Silme
            {
                String KullaniciAdi = (drow.Cells[0].Value).ToString();
                KullaniciSil(KullaniciAdi);
                KullaniciListele();
            }
        }

        public string KitapEkle()
        {
            MySqlConnection kitapeklebaglanti = new MySqlConnection(baglanti);
            kitapeklebaglanti.Open();
            string kitapEkle = "insert into tbl_bxbooks(`Image-URL-S`,booktitle,bookauthor,ısbn,publication,publisher) values('" + txtResim.Text + "','" + txtKitapAdi.Text + "','" + txtYazar.Text + "','" +txtisbn.Text + "','" + Convert.ToInt32(txtYayın.Text) + "','" + txtYayimci.Text + "')";

            MySqlCommand kitapeklebgl = new MySqlCommand(kitapEkle,kitapeklebaglanti);
            kitapeklebgl.ExecuteNonQuery();
            kitapeklebaglanti.Close();
            return txtisbn.Text;
        }

        private void KitaplarıListele()
        {
            /*DataGridViewImageColumn Resim = new DataGridViewImageColumn();
            grdKitapListeleme.Columns.Add(Resim);
            Resim.HeaderText = "Resim";
            */

            MySqlConnection kitapBaglanti = new MySqlConnection(baglanti);
            DataTable dt = new DataTable();
            string kitapadi = "select  `Image-URL-S`,booktitle,bookauthor,ısbn,publication,publisher from booksdatabase.tbl_bxbooks";
            kitapBaglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(kitapadi, kitapBaglanti);
            da.Fill(dt);
            grdKitap.DataSource = dt;

            kitapBaglanti.Close();
        }

        private void KitapSil(string isbn)
        {
            MySqlConnection kitapSilBaglantı = new MySqlConnection(baglanti);
            string kitapSilsorgu = "DELETE FROM tbl_bxbooks where ısbn = '" + isbn + "';";

            MySqlCommand silKomut = new MySqlCommand(kitapSilsorgu, kitapSilBaglantı);
            silKomut.Parameters.AddWithValue("@ısbn", isbn);
            kitapSilBaglantı.Open();
            silKomut.ExecuteNonQuery();
            kitapSilBaglantı.Close();
        }

        private int Kontrol ()
        {
            int Kontrol = 0;
            if(txtisbn.Text == "")
            {
                errorKitap.SetError(txtisbn, "Bir deger girmek zorundasin");
                Kontrol = 1;
            }
            if(txtKitapAdi.Text == "")
            {
                errorKitap.SetError(txtKitapAdi, "Bir deger girmek zorundasin");
                Kontrol = 1;
            } 
            if(txtResim.Text == "")
            {
                errorKitap.SetError(txtResim, "Bir deger girmek zorundasin");
                Kontrol = 1;
            }
            if(txtYayimci.Text == "")
            {
                errorKitap.SetError(txtYayimci, "Bir deger girmek zorundasin");
                Kontrol = 1;
            }
            if(txtYayın.Text == "")
            {
                errorKitap.SetError(txtYayın, "Bir deger girmek zorundasin");
                Kontrol = 1;
            }
            if(txtYazar.Text == "")
            {
                errorKitap.SetError(txtYazar, "Bir deger girmek zorundasin");
                Kontrol = 1;
            }
            return Kontrol; 
        }

        private void ResimDosyaYoluBelirle()
        { 
            //https://www.ahmetcansever.com/programlama/c-veritabanina-resim-yolu-ekleme-ve-pictureboxta-gosterme/

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtResim.Text = dosyayolu;

        }

        private void KullaniciListele()
        {
            MySqlConnection kullaniciBaglanti = new MySqlConnection(baglanti);
            DataTable dt = new DataTable();
            string kullaniciSorgu = "select  kullaniciadi from booksdatabase.tbl_kullanicibilgileri";
            kullaniciBaglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(kullaniciSorgu, kullaniciBaglanti);
            da.Fill(dt);
            grdKullanici.DataSource = dt;

            kullaniciBaglanti.Close();
        }
       
        private void KullaniciSil(String kullaniciadi )
        {
            MySqlConnection kullaniciSilBaglantı = new MySqlConnection(baglanti);
            string kullaniciSilsorgu = "DELETE FROM tbl_kullanicibilgileri where kullaniciadi = '" + kullaniciadi + "';";

            MySqlCommand silKomut = new MySqlCommand(kullaniciSilsorgu, kullaniciSilBaglantı);
            silKomut.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            kullaniciSilBaglantı.Open();
            silKomut.ExecuteNonQuery();
            kullaniciSilBaglantı.Close();
        }

        
    }
}
