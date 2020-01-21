using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kobiTicariOtomasyon
{
    public partial class FormStoklar : Form
    {
        public FormStoklar()
        {
            InitializeComponent();
        }
        //Global Alan
        sqlBaglantisi database = new sqlBaglantisi();

        //veri listeleme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("Execute STOKTAKIBI", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            stokControl.DataSource = tablo;
        }

        //ürün miktari CHART
        void pastaDilimi()
        {
            SqlCommand veri = new SqlCommand("Execute STOKTAKIBI", database.baglanti());
            SqlDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                grafikKontrol.Series["pastaDilimi"].Points.AddPoint(Convert.ToString(oku[0]), int.Parse(oku[1].ToString()));
            }
            database.baglanti().Close();
        }

        //Firma-Şehir Miktarı
        void sehirDilimi()
        {
            SqlCommand veri = new SqlCommand("Execute SEHIRTAKIBI", database.baglanti());
            SqlDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                sehirGrafikKontrol.Series["sehirDilimi"].Points.AddPoint(Convert.ToString(oku[0]), int.Parse(oku[1].ToString()));
            }
            database.baglanti().Close();
        }

        //Form Load
        private void FormStoklar_Load(object sender, EventArgs e)
        {
            listele();
            pastaDilimi();
            sehirDilimi();
            stokControl1.OptionsBehavior.Editable = false;
        }

        //Grid'e çift tıklanınca detayı görüntüleme
        private void stokControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow satir = stokControl1.GetDataRow(stokControl1.FocusedRowHandle);
            FormStokDetay stokDetay = new FormStokDetay();
            if (satir != null)
            {
                stokDetay.urunAd = satir["URUN ADI"].ToString();
            }
            stokDetay.Text = "DİĞER " + satir["URUN ADI"].ToString() + " ÜRÜNLERİ";
            stokDetay.Show();
        }
    }
}
