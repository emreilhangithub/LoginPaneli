using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginPaneli
{
    public partial class FrmGiris : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        Kullanici yonetim = new Kullanici();
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var result = new List<Kullanici>(); //liste oluşturduk         

            SqlCommand cmd = new SqlCommand("select KullaniciAd,Sifre from Tbl_Yonetici", bgl.baglanti());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            result = dt.AsEnumerable().Select(s => new Kullanici
            {
                 KullaniciAd = s.Field<string>("KullaniciAd"),
                 Sifre = s.Field<string>("Sifre")
            }).ToList();

            var user = result.FirstOrDefault(x => x.KullaniciAd == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text);
            if (user != null)
            {
                MessageBox.Show("Giriş başarılı Ana Sayfaya Hoş Geldiniz");
                Global.KullaniciAd = txtKullaniciAdi.Text;//kullanıcı adını set ettik
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz Giriş, lütfen kullanıcı adı ve şifreyi kontrol edin");
            }
        }
    }
}
