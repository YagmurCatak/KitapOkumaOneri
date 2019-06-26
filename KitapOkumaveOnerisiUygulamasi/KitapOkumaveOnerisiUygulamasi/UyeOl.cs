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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        public string baglanti = "Server=localhost;Database=booksdatabase;port=3306;persistsecurityinfo=True;SslMode=none;Uid=root;Pwd='1234';";
        public static int gonderilecekveri;

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            int Kontrol = 0;
            Kontrol = BosAlanKontrol();
            int kullaniciKontrol = kullaniciAdiKontrol();

            //eğer boş olan yoksa ve kullanıcı adı daha önce oluşturulmadıysa üyelik sağlanacak. 
            if (Kontrol != 1  && kullaniciKontrol == 1)
            {
                //kullanıcı bilgilerinin tablolara eklenmesini sağlanır. 
                int id = KullanicibilgileridatabaseEkle();
                BXUsersdataEkle(id);

                //kitapların listelenip oylama yapılacağı sayfaya yönlendirir. 
                gonderilecekveri = id;
                KitapOylama kitap = new KitapOylama();
                kitap.Show();
                this.Hide();
            }
        }
        
        private int kullaniciAdiKontrol()
        {
            //Bu metot oluşturulan kulanıcı adının daha önce varolup olmadığını kontrol eder. 
            
            //kullanıcıbiglileri tablosu okunacak. 
            //textbox taki kullanıcı adı ile kullanıcıbilgilerindeki kullanıcı adı eşitse uyarı verilecek ve 0 değerini döndürecek. 
            // eşit değilse 1 değeri döndirecek. 

            MySqlConnection KullaniciBilgileri = new MySqlConnection(baglanti);
            KullaniciBilgileri.Open();

            //kullanici bilgileri tablosunu okuyarak kullanici ile şifresinin aynı olup olmadığının kontrolü yapılır
            string mysqlKullanicibilgileri = "SELECT * FROM `Tbl_kullanicibilgileri`";
            MySqlCommand cmdkullanicibilgileri = new MySqlCommand(mysqlKullanicibilgileri, KullaniciBilgileri);
            MySqlDataReader rdrKullaniciBilgileri = cmdkullanicibilgileri.ExecuteReader();

            while (rdrKullaniciBilgileri.Read())
            {
                if (rdrKullaniciBilgileri["kullaniciadi"].ToString() == txtKulaniciAdiUye.Text)
                {
                    errorUye.SetError(txtKulaniciAdiUye, "Bu kullanıcı adı kullanılamaz.");
                    return 0;
                }
            }
            return 1;
        }
        public int BosAlanKontrol()
        {
            //Formda yer alan textboxların boş olup olmadığının kontrolünü yapan metottur. 

            int Flag = 0;
            if (txtKulaniciAdiUye.Text == "")
            {
                errorUye.SetError(txtKulaniciAdiUye, "Bir deger girmek zorundasiniz");
                Flag = 1;
            }
            if (txtKonum.Text == "")
            {
                errorUye.SetError(txtKonum, "Bir deger girmek zorundasiniz");
                Flag = 1;
            }
            if (txtYas.Text == "")
            {
                errorUye.SetError(txtYas, "Bir deger girmek zorundasiniz");
                Flag = 1;
            }
            if (txtSifre.Text == "")
            {
                errorUye.SetError(txtSifre, "Bir deger girmek zorundasiniz");
                Flag = 1;
            }
                
            return Flag;
        }

        public int KullanicibilgileridatabaseEkle()
        {
            //yeni üyenin bilgilerini kullanicibileri tablosuna ekleme işlemini yapar. 
            //kullanici bilgilerine şifre ve kullanıcı adı eklenir. 
            //kullanıcnın id bilgisisini döndürerek bxusers tablosuna yas ve konum bilgilerini ekelemek için kullanılacak.  

            int KullaniciId = 0;
            string kulanicibilgileri = " ";
            MySqlConnection KullaniciBilgileri = new MySqlConnection(baglanti);
            KullaniciBilgileri.Open();

            kulanicibilgileri = "insert into tbl_kullanicibilgileri(sifre,kullaniciadi) values('" + txtSifre.Text + "','" + txtKulaniciAdiUye.Text + "')";
            MySqlCommand kullaniciBlg = new MySqlCommand(kulanicibilgileri, KullaniciBilgileri);
            kullaniciBlg.ExecuteNonQuery();
            
            //Eklenen kullanici adının idsini bxusers tablosunda ilgili veriye eklemek için kullanici bilgileri tablosunu okunur. 
            string mysqlKullanicibilgileri = "SELECT * FROM `Tbl_kullanicibilgileri`";
            MySqlCommand cmdkullanicibilgileri = new MySqlCommand(mysqlKullanicibilgileri, KullaniciBilgileri);
            MySqlDataReader rdrKullaniciBilgileri = cmdkullanicibilgileri.ExecuteReader();

            while (rdrKullaniciBilgileri.Read())
            {
                if (rdrKullaniciBilgileri["kullaniciadi"].ToString() == txtKulaniciAdiUye.Text)
                {
                    KullaniciId = Convert.ToInt32(rdrKullaniciBilgileri["KullaniciID"].ToString());
                    continue;
                }
            }
            return KullaniciId;
        }
        
        public void BXUsersdataEkle(int id)
        {
            //kullanıcının id sini alarak bxusers tablosunda konum yas bilgilerini ekler. 

            string BXUsers1 = " ";
            MySqlConnection BXUsers = new MySqlConnection(baglanti);
            BXUsers.Open();
           
            BXUsers1 = "insert into tbl_bxusers(konum,yas,kullanicibilgileriID) values('" + txtKonum.Text + "','" + txtYas.Text + "' , '" + id + "')";
            MySqlCommand BXUsersBlg = new MySqlCommand(BXUsers1, BXUsers);
            BXUsersBlg.ExecuteNonQuery();

            string mysqlBXUser = "SELECT * FROM `tbl_bxusers`";
            MySqlCommand cmdbxusers = new MySqlCommand(mysqlBXUser, BXUsers);
            MySqlDataReader rdrbxusers = cmdbxusers.ExecuteReader();

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void txtYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //yas texboxına karakter girilmesini önler. 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
          
        }

       
    }
}
