using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginPaneli
{
    public partial class FrmAnaForm : Form
    {
        SqlBaglanti bgl = new  SqlBaglanti();

        public FrmAnaForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblKullaniciAdi.Text = Global.KullaniciAd; //kullanıcı adını get ettik


            var result = new List<Kullanici>(); //liste oluşturduk         

            SqlCommand komut = new SqlCommand("select * from Tbl_Yonetici where KullaniciAd=@KullaniciAd", bgl.baglanti());
            komut.Parameters.AddWithValue("KullaniciAd", Global.KullaniciAd);

            SqlDataAdapter dataadap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            dataadap.Fill(tablo);

            result = tablo.AsEnumerable().Select(s => new Kullanici
            {                
                KullaniciAd = s.Field<string>("KullaniciAd"),
                KullaniciId = s.Field<int>("KullaniciId"),
                Sifre = s.Field<string>("Sifre"),
            }).ToList();

            var test = result.FirstOrDefault();

            lblKullaniciId.Text = test.KullaniciId.ToString();
            lblKullaniciSifre.Text = test.Sifre;
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
