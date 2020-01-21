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
    public partial class FormHareketler : Form
    {
        public FormHareketler()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Firma hareketleri
        void firmaHareketListele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("Execute FIRMAHAREKETLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            hareketFirmalar.DataSource = tablo;
        }

        //Musteri hareketleri
        void musteriHareketListele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("Execute MUSTERIHAREKETLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            hareketMusteriler.DataSource = tablo;
        }

        //FORM LOAD
        private void FormHareketler_Load(object sender, EventArgs e)
        {
            firmaHareketListele();
            musteriHareketListele();
            hareketFirmalar1.OptionsBehavior.Editable = false;
            hareketMusteriler1.OptionsBehavior.Editable = false;
            hareketStoklar1.OptionsBehavior.Editable = false;
        }
    }
}
