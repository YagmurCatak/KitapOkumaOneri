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
    public partial class OturumAc : Form
    {
        public OturumAc()
        {
            InitializeComponent();
        }

        public string baglanti = "Server=localhost;Database=booksdatabase;port=3306;persistsecurityinfo=True;SslMode=none;Uid=root;Pwd='1234';";
        int flag = 0;

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            BosAlanKontrol();
            int kontrol = sifrekontrol();

            if(kontrol == 1)
            {
                //kitapların listelendiği sayfanın açılmasını sağlar.
                Kitaplar kitap = new Kitaplar();
                kitap.Show();
                this.Hide();
            }
            
        }

        public void BosAlanKontrol()
        {
            if (txtKullaniciAdi.Text == "")
                error.SetError(txtKullaniciAdi, "Bir deger girmek zorundasiniz");
            if (txtSifre.Text == "")
                error.SetError(txtSifre, "Bir deger girmek zorundasiniz");
        }

        public int sifrekontrol()
        {
            //kullanici bilgileri tablosunu okuyarak kullaniciadi ile şifresinin aynı olup olmadığının kontrolü yapılır.
            //eğer kullanici adı şifre ile eşleşiyor ise flag değeri 1 , eşleşmiyor sa flag değeri 0 olur ve fonksiyonun geri dönüş değeridir. 

            MySqlConnection KullaniciBilgileri = new MySqlConnection(baglanti);
            KullaniciBilgileri.Open();

            string mysqlKullanicibilgileri = "SELECT * FROM `Tbl_kullanicibilgileri`";
            MySqlCommand cmdkullanicibilgileri = new MySqlCommand(mysqlKullanicibilgileri, KullaniciBilgileri);
            MySqlDataReader rdrKullaniciBilgileri = cmdkullanicibilgileri.ExecuteReader();

            while (rdrKullaniciBilgileri.Read())
            {
                if (rdrKullaniciBilgileri["kullaniciadi"].ToString() == txtKullaniciAdi.Text)
                {
                    if(rdrKullaniciBilgileri["sifre"].ToString() == txtSifre.Text)
                    {
                        flag = 1;
                        continue;
                    }
                    else
                    {
                        error.SetError(txtSifre, "Şifre ile kullanıcı adı uyuşmamaktadır. ");
                        txtSifre.Clear();
                        flag = 0;
                    }
                }
            }
            return flag;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YöneticiPaneli Yonetici = new YöneticiPaneli();
            Yonetici.Show();
            this.Hide();
        }
    }
}
