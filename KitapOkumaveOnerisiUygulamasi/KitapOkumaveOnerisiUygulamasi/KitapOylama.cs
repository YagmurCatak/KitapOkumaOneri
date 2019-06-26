using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapOkumaveOnerisiUygulamasi
{
    public partial class KitapOylama : Form
    {
        int deger;
        DataSet ds;
        MySqlDataAdapter da;

        public KitapOylama()
        {
            deger = 0;
            InitializeComponent();
            KitapListele();
            btnoylama.Visible = false;
        }

        public string baglanti = "Server=localhost;Database=booksdatabase;port=3306;persistsecurityinfo=True;SslMode=none;Uid=root;Pwd='1234';";
        public int sayac = 0;

        private void KitapListele()
        {
            DataGridViewTextBoxColumn Puan = new DataGridViewTextBoxColumn();
            grdKitapOyla.Columns.Add(Puan);
            Puan.HeaderText = "Puan";
          
            MySqlConnection kitapBaglanti = new MySqlConnection(baglanti);
            ds = new DataSet();
            string kitapadi = "select  *    from booksdatabase.tbl_bxbooks";
            kitapBaglanti.Open();
            da = new MySqlDataAdapter(kitapadi, kitapBaglanti);
            da.Fill(ds,deger,20, "booksdatabase.tbl_bxbooks");
            grdKitapOyla.DataSource = ds.Tables[0];

            kitapBaglanti.Close();
        }
        
        private string bxbookusersOku()
        {
            //uye olan kullanıcının kullanici idsini elde eder. 
            string userID = " ";
            MySqlConnection users = new MySqlConnection(baglanti);
            users.Open();

            //UyeOl sayfasından gelen verileri alıyoruz.
            int UyeOlKulaniciID = UyeOl.gonderilecekveri;

            string mysqlusers = "SELECT * FROM `tbl_bxusers`";
            MySqlCommand cmdusers = new MySqlCommand(mysqlusers, users);
            MySqlDataReader rdrusers = cmdusers.ExecuteReader();

            while (rdrusers.Read())
            {
                if (rdrusers["kullanicibilgileriID"].ToString() == UyeOlKulaniciID.ToString())
                {
                    userID = rdrusers["idKullanici"].ToString();
                }
            }
            return userID;

        }

        private void BXbookratingEkle(int puan)
        {
            string userID = bxbookusersOku();//elde edilen kullanıcı idsini rating datasına eklemek için değişkene atanır. 
            string bookrating = " ";
            MySqlConnection BXbookrating = new MySqlConnection(baglanti);
     
            BXbookrating.Open();
            bookrating = "insert into tbl_bxbookrating(userID,ısbn,rating) values('" + userID + "','" + grdKitapOyla.CurrentRow.Cells[4].Value.ToString() + "','" + puan + "')";

            MySqlCommand BxratingBlg = new MySqlCommand(bookrating, BXbookrating);
            BxratingBlg.ExecuteNonQuery();
            BXbookrating.Close();
        }

        public void btnoylama_Click(object sender, EventArgs e)
        {
            Kitaplar KitapListele = new Kitaplar();
            KitapListele.Show();
            this.Hide();
        }

        private void grdKitapOyla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //verilen puan değerini alıyorum. 
            int puan = Convert.ToInt32(grdKitapOyla.CurrentRow.Cells[0].Value.ToString());
            BXbookratingEkle(puan);
            sayac++;
            if (sayac >= 10)
            {
                //üyelik tamamlandı. 
                lblOyla.Text = "En az 10 oylama barajını tamamladınız kitap listesini görebilirsiniz.Devam etmek istemiyorsanız Oyla butonuna basınız";
                btnoylama.Visible = true;
            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            //http://bahadirsahin23.blogspot.com/2013/11/datagridview-da-sayfalama.html

            deger = deger - 20;
            if (deger <= 0)
            {
                deger = 0;
            }
            ds.Clear();
            da.Fill(ds,deger,20, "booksdatabase.tbl_bxbooks");
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            int toplam = toplamKitapAdedi();
            deger = deger + 20;

            if(deger >= toplam)
            {
                deger = toplam - 1; 
            }
            ds.Clear();
            da.Fill(ds, deger, 20, "booksdatabase.tbl_bxbooks");
        }

        public int toplamKitapAdedi()
        {
            //toplam kitap adedini bulur. 
            int toplam = 0;
            MySqlConnection kitaplar = new MySqlConnection(baglanti);
            kitaplar.Open();
            MySqlCommand toplamBaglanti = new MySqlCommand("SELECT count(ısbn) FROM tbl_bxbooks;", kitaplar);
            
            toplam = Convert.ToInt32(toplamBaglanti.ExecuteScalar());
            kitaplar.Close();
            return toplam;
        }
    }
}