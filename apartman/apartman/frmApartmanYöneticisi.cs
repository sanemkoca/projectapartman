/****************************************************************************
**                           SAKARYA ÜNİVERSİTESİ
**                 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                   BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                     NESNEYE DAYALI PROGRAMLAMA DERSİ
**                           2019-2020 BAHAR DÖNEMİ
**
**                  ÖDEV NUMARASI..........: B191200302
**                  ÖĞRENCİ ADI............: SANEM KOCA
**                  ÖĞRENCİ NUMARASI.......: B191200302
**          
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql servver veri tabanı bağlantısı
using System.Data.Sql; //sql server veri tabanı bağlantısı

namespace apartman
{
    public partial class frmApartmanYöneticisi : Form
    {
        public frmApartmanYöneticisi()
        {
            InitializeComponent();
        }

        static string conString = "Server=.; Database=apartman;";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.

        public SqlConnection baglanti = new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //PROGRAM BAŞLANGICINDA BÜTÜN GROUPBOX VE PANELLER KAPALI OLACAK. BUTONLARA BASILDIKÇA GÖZÜKECEKLER...

            grpYeniGelir.Visible = false;
            grpYeniGider.Visible = false;
            grpBorclandir.Visible = false;
            grpDuyurular.Visible = false;
            grpKullanici.Visible = false;

            pnlGelirler.Hide();
            pnlGiderler.Hide();
            pnlBorclar.Hide();
            pnlDuyurular.Hide();
            pnlKullanicilar.Hide();

            griddoldur();
        }

        public SqlConnection cnn;
        public SqlCommand cmd;

        public SqlDataAdapter Gelir_Tanimi;
        public SqlDataAdapter Gider_Tanimi;
        public SqlDataAdapter Borc_Islemleri;
        public SqlDataAdapter Duyuru_Panosu;
        public SqlDataAdapter Kullanici_Yonetimi;

        public DataSet ds;

        void griddoldur() //DataGridViewda bilgilerin görüntülenmesi için açılan metod.
        {
            cnn = new SqlConnection("server=.; Initial Catalog=apartman; Integrated Security=SSPI");

            Gelir_Tanimi = new SqlDataAdapter("Select * From Gelirler", cnn);
            Gider_Tanimi = new SqlDataAdapter("Select * From Giderler", cnn);
            Borc_Islemleri = new SqlDataAdapter("Select * From Borc_İslemleri", cnn);
            Duyuru_Panosu = new SqlDataAdapter("Select * From Duyuru", cnn);
            Kullanici_Yonetimi = new SqlDataAdapter("Select * From Kullanicilar", cnn);

            ds = new DataSet();
            cnn.Open();

            Gelir_Tanimi.Fill(ds, "Gelirler");
            dtgGelirler.DataSource = ds.Tables["Gelirler"];

            Gider_Tanimi.Fill(ds, "Giderler");
            dtgGiderler.DataSource = ds.Tables["Giderler"];

            Borc_Islemleri.Fill(ds, "Borc_İslemleri");
            dtgBorcListesi.DataSource = ds.Tables["Borc_İslemleri"];

            Duyuru_Panosu.Fill(ds, "Duyuru");
            dtgDuyurular.DataSource = ds.Tables["Duyuru"];

            Kullanici_Yonetimi.Fill(ds, "Kullanicilar");
            dtgKullanicilar.DataSource = ds.Tables["Kullanicilar"];

            cnn.Close();
        }

        private void btnYeniGelir_Click(object sender, EventArgs e)
        {
            pnlGelirler.Hide();
            grpYeniGelir.Visible = true;            
        }
        
        private void btnGelirler_Click(object sender, EventArgs e)
        {
            grpYeniGelir.Visible = false;
            pnlGelirler.Show();
        }

        private void btnYeniGider_Click(object sender, EventArgs e)
        {
            pnlGiderler.Hide();
            grpYeniGider.Visible = true;
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            grpYeniGider.Visible = false;
            pnlGiderler.Show();
        }

        private void btnBorclandir_Click(object sender, EventArgs e)
        {
            pnlBorclar.Hide();
            grpBorclandir.Visible = true;
        }

        private void btnBorcListesi_Click(object sender, EventArgs e)
        {
            grpBorclandir.Visible = false;
            pnlBorclar.Show();
        }

        private void btnYeniDuyuru_Click(object sender, EventArgs e)
        {
            pnlDuyurular.Hide();
            grpDuyurular.Visible = true;
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            grpDuyurular.Visible = false;
            pnlDuyurular.Show();
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            pnlKullanicilar.Hide();
            grpKullanici.Visible = true;
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            grpKullanici.Visible = false;
            pnlKullanicilar.Show();
        }

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            //Veri tabanına bağlantıyı bu metod içerisinde yapıyorum.
            cnn = new SqlConnection("server=.; Initial Catalog=apartman; Integrated Security=SSPI");
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Gelirler_Ekle"; //Stored Procedure'ümüzün ismi

            //Stored procedure deki parametrelere textboxlardan değerleri alıyoruz.
            cmd.Parameters.Add("Gelir_Kategori", SqlDbType.NVarChar, 50).Value = txtGelirKategori.Text; 
            cmd.Parameters.Add("Tutar", SqlDbType.Money).Value = txtGelirTutar.Text; 
            cmd.Parameters.Add("Aciklama", SqlDbType.NVarChar, 50).Value = rtxtGelirAciklama.Text;
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            //Veri tabanına bağlantıyı bu metod içerisinde yapıyorum.
            cnn = new SqlConnection("server=.; Initial Catalog=apartman; Integrated Security=SSPI");
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Giderler_Ekle"; //Stored Procedure'ümüzün ismi

            //Stored procedure deki parametrelere textboxlardan değerleri alıyoruz.
            cmd.Parameters.Add("Gider_Kategori", SqlDbType.NVarChar, 50).Value = txtGiderKategori.Text; 
            cmd.Parameters.Add("Tutar", SqlDbType.Money).Value = txtGiderTutar.Text; 
            cmd.Parameters.Add("Aciklama", SqlDbType.NVarChar, 50).Value = rtxtGiderAciklama.Text;
        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            //Veri tabanına bağlantıyı bu metod içerisinde yapıyorum.
            cnn = new SqlConnection("server=.; Initial Catalog=apartman; Integrated Security=SSPI");
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Borcİslemleri_Ekle"; //Stored Procedure'ümüzün ismi

            //Stored procedure deki parametrelere textboxlardan değerleri alıyoruz.
            cmd.Parameters.Add("Borc_Kategori", SqlDbType.NVarChar, 50).Value = txtBorcKategori.Text; 
            cmd.Parameters.Add("Kullanici", SqlDbType.Money).Value = cmbBorcKisi.Text; 
            cmd.Parameters.Add("Tutar", SqlDbType.Money).Value = txtBorcTutar.Text;
            cmd.Parameters.Add("Aciklama", SqlDbType.NVarChar, 50).Value = rtxtBorcAciklama.Text;
        }

        private void btnDuyuruEkle_Click(object sender, EventArgs e)
        {
            //Veri tabanına bağlantıyı bu metod içerisinde yapıyorum.
            cnn = new SqlConnection("server=.; Initial Catalog=apartman; Integrated Security=SSPI");
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Duyuru_Ekle"; //Stored Procedure'ümüzün ismi

            //Stored procedure deki parametrelere textboxlardan değerleri alıyoruz.
            cmd.Parameters.Add("Konu_Basligi", SqlDbType.NVarChar, 50).Value = txtKonuBasligi.Text; 
            cmd.Parameters.Add("Aciklama", SqlDbType.Money).Value = txtKonu.Text;
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            //Veri tabanına bağlantıyı bu metod içerisinde yapıyorum.
            cnn = new SqlConnection("server=.; Initial Catalog=apartman; Integrated Security=SSPI");
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Kullanicilar_Ekle"; //Stored Procedure'ümüzün ismi

            //Stored procedure deki parametrelere textboxlardan değerleri alıyoruz.
            cmd.Parameters.Add("TcNo", SqlDbType.BigInt).Value = Convert.ToInt32(txtKullaniciTc.Text); 
            cmd.Parameters.Add("Ad", SqlDbType.NVarChar, 50).Value = txtKullaniciAd.Text; 
            cmd.Parameters.Add("Soyad", SqlDbType.NVarChar, 50).Value = txtKullaniciSoyad.Text;
            cmd.Parameters.Add("Email", SqlDbType.NVarChar, 50).Value = txtEmail.Text;
            cmd.Parameters.Add("Telefon", SqlDbType.Int).Value = Convert.ToInt32(txtTelefonNo.Text);
            cmd.Parameters.Add("Daire_No", SqlDbType.Int).Value = Convert.ToInt32(txtDaireNo.Text);
            cmd.Parameters.Add("Ev_Durumu", SqlDbType.NVarChar, 50).Value = txtRol.Text;
            cmd.Parameters.Add("OgrSifre", SqlDbType.NVarChar, 50).Value = txtKullaniciSifre.Text;
        }

        private void tbGiderler_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.Close(); //Açık olan form sayfası kapatılır.

                frmApartmanGiris frm = new frmApartmanGiris(); 
                frm.Show(); //Yeni form sayfasını göster.
            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }  
        }

        private void frmApartmanYöneticisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Burada yapmak istediğimiz formumuz kapatdan (x tuşudan) kapattığımızda Uygulamamız kapansın diyoruz 
            Application.Exit();
        }
        
    }
}
