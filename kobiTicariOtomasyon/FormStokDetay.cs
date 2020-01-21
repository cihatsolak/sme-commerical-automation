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
    public partial class FormStokDetay : Form
    {
        public FormStokDetay()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        public string urunAd;
        sqlBaglantisi database = new sqlBaglantisi();

        //Verileri Listele
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT URUNAD AS 'URUN ADI',MARKA,MODEL,YIL,ADET,ALISFIYAT AS 'ALIS FIYATI'," +
                "SATISFIYAT AS 'SATIS FIYATI',DETAY FROM TBLURUNLER WHERE URUNAD='" + urunAd + "'", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridStokDetay.DataSource = tablo;
        }

        private void FormStokDetay_Load(object sender, EventArgs e)
        {
            listele();
            gridView1.OptionsBehavior.Editable = false;
        }
    }
}
