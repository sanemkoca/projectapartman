
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
using System.Data.SqlClient;//Veri tabanı bağlantısı 
using System.Data.Sql; //veri tabanı bağlantısı 

namespace apartman
{
    public partial class frmApartmanGiris : Form
    {
        public frmApartmanGiris()
        {
            InitializeComponent();
        }

        static string conString = "Server=.; Database=apartman;";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.

        public SqlConnection baglanti = new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.

        private void btnGiris_Click(object sender, EventArgs e)
        {
           
            string YoneticiTc;
            string YoneticiSifre;

            YoneticiTc = txtKullanici.Text; //OgrtKullanici stringi oluşturup txtKullanici'e bağlamak için.
            YoneticiSifre = txtSifre.Text; //OgrtSifre stringi oluşturup txtSifre'e bağlamak için.

            if (YoneticiTc == "huseyinkoca" && YoneticiSifre == "1234") //eğer kullanıcı adı huseyinkoca, şifre 1234 ise.. 
            {
                this.Hide();//Bu form sayfasını gizle

                frmApartmanYöneticisi frm = new frmApartmanYöneticisi();
                frm.Show();//Yeni form sayfasını göster.
            }
            else if (YoneticiTc == "sanemkoca" && YoneticiSifre == "1234")
            {
                this.Hide();

                frmApartmanSakini frmSakin = new frmApartmanSakini();
                frmSakin.Show();
            }
            else//girilen değerler eşit değilse...
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ ! LÜTFEN BİLGİLERİNİZİ KONTROL EDİNİZ...", "!! UYARI !!");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmApartmanSistemGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Burada yapmak istediğimiz formumuz kapatdan (x tuşudan) kapattığımızda Uygulamamız kapansın diyoruz 
            Application.Exit();
        }
    }
}
