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
using DevExpress.Charts;

namespace kobiTicariOtomasyon
{
    public partial class FormKasa : Form
    {
        public FormKasa()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();
        public string isim;

        //Müsterileri Grid'e çekme
        void musteri()
        {
            SqlDataAdapter veri = new SqlDataAdapter("EXECUTE MUSTERIHAREKETLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridMusteriler.DataSource = tablo;
        }

        //Firmaları Grid'e Çekme
        void firmalar()
        {
            SqlDataAdapter veri = new SqlDataAdapter("EXECUTE FIRMAHAREKETLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridFirmalar.DataSource = tablo;
        }

        //Giderleri Grid'e çekme
        void giderler()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT AY, YIL, ELEKTRIK, SU, DOGALGAZ, INTERNET, MAASLAR, EKSTRA, NOTLAR FROM TBLGIDERLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridGiderler.DataSource = tablo;
        }

        private void FormKasa_Load(object sender, EventArgs e)
        {
            musteri();
            firmalar();
            giderler();
            gridGirisKasa1.OptionsBehavior.Editable = false;
            gridFirmalar1.OptionsBehavior.Editable = false;
            
            //isim çekme
            lblKullanici.Text = isim.ToUpper();

            //Toplam Tutar
            SqlCommand tplTutar = new SqlCommand("SELECT SUM(TUTAR) FROM TBLFATURADETAY", database.baglanti());
            int toplamTutar = Convert.ToInt32(tplTutar.ExecuteScalar());
            lblToplamTutar.Text = toplamTutar.ToString() + " ₺";

            //Son Ayın Toplam Faturası
            SqlCommand sonAyOdeme = new SqlCommand("SELECT (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA),AY FROM TBLGIDERLER ORDER BY ID ASC", database.baglanti());
            SqlDataReader oku2 = sonAyOdeme.ExecuteReader();
            while (oku2.Read())
            {
                lblOdemeler.Text = oku2[0].ToString() + " ₺";
                lblOdemelerAy.Text = oku2[1].ToString() + " AYI";
            }
            database.baglanti().Close();

            //Son ay toplam personel maaşı
            SqlCommand sonAyMaas = new SqlCommand("SELECT MAASLAR,AY FROM TBLGIDERLER ORDER BY ID ASC", database.baglanti());
            SqlDataReader oku3 = sonAyMaas.ExecuteReader();
            while (oku3.Read())
            {
                lblPersonelMaas.Text = oku3[0].ToString() + " ₺";
                lblpersonelAy.Text = oku3[1].ToString() + " AYI";
            }
            database.baglanti().Close();

            //toplam müşteri
            SqlCommand tplmusteri = new SqlCommand("SELECT COUNT(*) FROM TBLMUSTERILER", database.baglanti());
            int toplamMusteri = Convert.ToInt32(tplmusteri.ExecuteScalar());
            lblMusteriSayisi.Text = toplamMusteri.ToString() + " Kişi";

            //toplam firma
            SqlCommand tplfirma = new SqlCommand("SELECT COUNT(*) FROM TBLFIRMALAR", database.baglanti());
            int toplamFirma = Convert.ToInt32(tplfirma.ExecuteScalar());
            lblFirmaSayisi.Text = toplamFirma.ToString() + " Firma";

            //toplam farklı şehir sayısı
            SqlCommand farkliMusteri = new SqlCommand("SELECT COUNT(DISTINCT IL) FROM TBLMUSTERILER", database.baglanti());
            int musteriSayisi = Convert.ToInt32(farkliMusteri.ExecuteScalar());
            SqlCommand farkliFirma = new SqlCommand("SELECT COUNT(DISTINCT IL) FROM TBLFIRMALAR ", database.baglanti());
            int firmaSayisi = Convert.ToInt32(farkliFirma.ExecuteScalar());
            lblSehirSayisi.Text = (musteriSayisi + firmaSayisi).ToString() + " Şehir";

            //toplam personel sayısı
            SqlCommand tplPersonel = new SqlCommand("SELECT COUNT(*) FROM TBLPERSONELLER", database.baglanti());
            int toplamPersonel = Convert.ToInt32(tplPersonel.ExecuteScalar());
            lblPersonelSayisi.Text = toplamPersonel.ToString() + " Kişi";

            //toplam stok sayısı
            SqlCommand tplUrunler = new SqlCommand("SELECT SUM(ADET) FROM TBLURUNLER", database.baglanti());
            int toplamUrunler = Convert.ToInt32(tplUrunler.ExecuteScalar());
            lblStokSayisi.Text = toplamUrunler.ToString() + " Adet";     
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        int sayac = 0;
        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                //grafik 1 | son 6 ay elektrik faturası
                lblGrafikKontrol.Text = "SON 6 AY ELEKTRİK FATURASI";
                SqlCommand grafikKomut = new SqlCommand("SELECT TOP 6 AY, ELEKTRIK FROM TBLGIDERLER ORDER BY ID DESC", database.baglanti());
                SqlDataReader oku4 = grafikKomut.ExecuteReader();
                while (oku4.Read())
                {
                    grafikKontrol.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(oku4[0], oku4[1]));
                }
                database.baglanti().Close();

                //grafik 2 | son 6 ay dogalgaz faturası
                lblGrafikKontrol2.Text = "SON 6 AY DOGALGAZ FATURASI";
                SqlCommand grafikKomut2 = new SqlCommand("SELECT TOP 6 AY, DOGALGAZ FROM TBLGIDERLER ORDER BY ID DESC", database.baglanti());
                SqlDataReader oku5 = grafikKomut2.ExecuteReader();
                while (oku5.Read())
                {
                    grafikKontrol2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(oku5[0], oku5[1]));
                }
                database.baglanti().Close();


            }
            else if (sayac > 5 && sayac <= 10)
            {
                grafikKontrol.Series["AYLAR"].Points.Clear();
                grafikKontrol2.Series["AYLAR"].Points.Clear();
                lblGrafikKontrol.Text = "SON 6 AY SU FATURASI";
                lblGrafikKontrol2.Text = "SON 6 AY EKSTRA HARCAMALAR";

                //grafik 2 | son 6 ay su faturası
                SqlCommand grafikKomut3 = new SqlCommand("SELECT TOP 6 AY, SU FROM TBLGIDERLER ORDER BY ID DESC", database.baglanti());
                SqlDataReader oku6 = grafikKomut3.ExecuteReader();
                while (oku6.Read())
                {
                    grafikKontrol.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(oku6[0], oku6[1]));
                }
                database.baglanti().Close();

                //grafik 2 | son 6 ay su faturası
                SqlCommand grafikKomut4 = new SqlCommand("SELECT TOP 6 AY, EKSTRA FROM TBLGIDERLER ORDER BY ID DESC", database.baglanti());
                SqlDataReader oku7 = grafikKomut4.ExecuteReader();
                while (oku7.Read())
                {
                    grafikKontrol2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(oku7[0], oku7[1]));
                }
                database.baglanti().Close();
            }
            else if (sayac == 11)
                sayac = 0;
        }
    }
}
