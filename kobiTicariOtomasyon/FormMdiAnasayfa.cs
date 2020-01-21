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
using System.Xml;

namespace kobiTicariOtomasyon
{
    public partial class FormMdiAnasayfa : Form
    {
        public FormMdiAnasayfa()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();
        internetBaglantisi dataConnection = new internetBaglantisi();

        //Kalan stoğu grid'e çekme
        void kalanStok()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT URUNAD AS 'STOK ADI', SUM(ADET) AS 'KALAN ADET' FROM TBLURUNLER GROUP BY URUNAD HAVING SUM(ADET) <= 10 ORDER BY SUM(ADET)", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridKalanStoklar.DataSource = tablo;
        }

        //Beklemede olan notları grid'e çekme
        void beklemedeNotlar()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT TARIH, BASLIK, DETAY FROM TBLNOTLAR WHERE DURUM=0", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridAjanda.DataSource = tablo;
        }

        //Void son 10 hareketleri grid'e çekme
        void sonHareketler()
        {
            SqlDataAdapter veri = new SqlDataAdapter("EXECUTE SONFIRMAHAREKETLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridSonHareketler.DataSource = tablo;
        }

        //Void fihrist
        void fihrist()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT AD AS 'FIRMA', YETKILIADSOYAD AS 'YETKILI', TELEFON1 AS 'TELEFON'  FROM TBLFIRMALAR", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridFihrist.DataSource = tablo;
        }

        void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name=="title")
                {
                    haberListesi.Items.Add(xmloku.ReadString());
                }
            }
            haberListesi.Items.RemoveAt(0);
            haberListesi.Items.RemoveAt(1);
        }

        //FORM LOAD
        private void FormMdiAnasayfa_Load(object sender, EventArgs e)
        {
            if (dataConnection.internet())
            {
                //kurlar
                tarayici.Navigate("http://www.tcmb.gov.tr/kurlar/today.xml");

                //haberler
                haberler();
            }
            else
                tarayici.Visible = false;

            kalanStok();
            beklemedeNotlar();
            sonHareketler();
            fihrist();
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;
            gridView3.OptionsBehavior.Editable = false;
            gridView4.OptionsBehavior.Editable = false;
        }
    }
}
