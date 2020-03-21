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
using System.Data.SqlClient; //veri tabanı bağlantısı
using System.Data.Sql; //veri tabanı bağlantısı

namespace apartman
{
    public partial class frmApartmanSakini : Form
    {
        public frmApartmanSakini()
        {
            InitializeComponent();
        }

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
            dtgSakinGelirler.DataSource = ds.Tables["Gelirler"];

            Gider_Tanimi.Fill(ds, "Giderler");
            dtgSakinGiderler.DataSource = ds.Tables["Giderler"];

            Borc_Islemleri.Fill(ds, "Borc_İslemleri");
            dtgSakinBorcListesi.DataSource = ds.Tables["Borc_İslemleri"];

            Duyuru_Panosu.Fill(ds, "Duyuru");
            dtgSakinDuyurular.DataSource = ds.Tables["Duyuru"];

            cnn.Close();
        }
        public SqlConnection cnn;
        public SqlCommand cmd;

        private void frmApartmanSakini_Load(object sender, EventArgs e)
        {
            griddoldur();

            grpSakinDuyuru.Visible = false;
            pnlSakinDuyuru.Hide();
        }

        private void btnSakinDuyuruEkle_Click(object sender, EventArgs e)
        {
            grpSakinDuyuru.Visible = true;
        }

        private void btnSakinDuyurular_Click(object sender, EventArgs e)
        {
            grpSakinDuyuru.Visible = false;
            pnlSakinDuyuru.Show();
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

        private void btnSakinDuyuru_Click(object sender, EventArgs e)
        {
            //Veri tabanına bağlantıyı bu metod içerisinde yapıyorum.
            cnn = new SqlConnection("server=.; Initial Catalog=apartman; Integrated Security=SSPI");
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Duyuru_Ekle"; //Stored Procedure'ümüzün ismi

            //Stored procedure deki parametrelere textboxlardan değerleri alıyoruz.
            cmd.Parameters.Add("Konu_Basligi", SqlDbType.NVarChar, 50).Value = txtSakinKonuBasliği.Text;
            cmd.Parameters.Add("Aciklama", SqlDbType.Money).Value = txtSakinKonu.Text;
        }

        private void frmApartmanSakini_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Burada yapmak istediğimiz formumuz kapatdan (x tuşudan) kapattığımızda Uygulamamız kapansın diyoruz 
            Application.Exit();
        }
    }
}
