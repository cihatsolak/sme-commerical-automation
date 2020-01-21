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
using DevExpress.XtraPrinting;

namespace kobiTicariOtomasyon
{
    public partial class FormFaturaDetay : Form
    {
        public FormFaturaDetay()
        {
            InitializeComponent();
        }
        //FORM LOAD
        sqlBaglantisi database = new sqlBaglantisi();
        public string id,isim;

        //Veri Listeleme
        public void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT FATURAURUNID, URUNAD, MIKTAR,FIYAT,TUTAR,ALICI FROM TBLFATURADETAY inner join TBLFATURABILGI on TBLFATURABILGI.FATURABILGIID=TBLFATURADETAY.FATURAID WHERE TBLFATURABILGI.FATURABILGIID='"+id+"'", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridFaturaDetay.DataSource = tablo;
        }

        //FORM LOAD
        private void FormFaturaDetay_Load(object sender, EventArgs e)
        {
            listele();
            this.Text = isim+" FATURA DETAYI";
            gridFaturaDetay1.OptionsBehavior.Editable = false;
            gridFaturaDetay1.Columns["FATURAURUNID"].Visible = false;
        }

        //Form'a çift tıklayınca
        private void gridFaturaDetay1_DoubleClick(object sender, EventArgs e)
        {
            FormFaturaDetayDuzenleme detayDuzenleme = new FormFaturaDetayDuzenleme();
            DataRow satir = gridFaturaDetay1.GetDataRow(gridFaturaDetay1.FocusedRowHandle);
            if (satir!=null)
            {
                detayDuzenleme.id = satir["FATURAURUNID"].ToString();
            }
            detayDuzenleme.Show();
        }

        //YAZDIRMA
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintableComponentLink yazdir = new PrintableComponentLink(new PrintingSystem());
            yazdir.Component = gridFaturaDetay;
            yazdir.CreateDocument();
            PrintTool printTool = new PrintTool(yazdir.PrintingSystemBase);
            yazdir.ShowPreviewDialog();
        }

        //EXCEL'E AKTARMA
        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = isim + " alıcısına ait fatura (" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ")";
            saveFileDialog1.Filter = "XLS Dosyaları (*.xls)|*.xls";

            saveFileDialog1.InitialDirectory = "c:";

            //eğer saveFileDiaolog1 açıldığında Evet’e tıklanırsa

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                DevExpress.XtraPrinting.XlsExportOptions _Options = new DevExpress.XtraPrinting.XlsExportOptions();

                _Options.SheetName = isim+" alıcısına ait fatura (" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ")";

                gridFaturaDetay.ExportToXls(saveFileDialog1.FileName, _Options);

                if (MessageBox.Show("Aktarılan dosyayı şimdi görmek ister misiniz?", "Excel dosyası", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Kaydedilen Excel Dosyasını açar.

                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                }

            }
        }
    }
}
