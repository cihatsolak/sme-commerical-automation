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
    public partial class FormRehber : Form
    {
        public FormRehber()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();
        
        //FORM LOAD
        private void formRehber_Load(object sender, EventArgs e)
        {
            //Müşteri Bilgileri
            SqlDataAdapter musteriVeri = new SqlDataAdapter("SELECT AD,SOYAD,TELEFON,TELEFON2,MAIL FROM TBLMUSTERILER", database.baglanti());
            DataTable tablo = new DataTable();
            musteriVeri.Fill(tablo);
            rehberMusteriler.DataSource = tablo;

            //Firma Bilgileri
            SqlDataAdapter firmaVeri = new SqlDataAdapter("SELECT AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX FROM TBLFIRMALAR", database.baglanti());
            DataTable tablo2 = new DataTable();
            firmaVeri.Fill(tablo2);
            rehberFirmalar.DataSource = tablo2;

            //Gridview üzerinde oynanmasın
            rehberFirmalar1.OptionsBehavior.Editable = false;
            rehberMusteriler1.OptionsBehavior.Editable = false;
        }

        //Müşterilerde gridview'a çift tıkladığında oluşacak olay
        private void rehberMusteriler1_DoubleClick(object sender, EventArgs e)
        {
            FormEmail emailForm = new FormEmail();
            DataRow satir = rehberMusteriler1.GetDataRow(rehberMusteriler1.FocusedRowHandle);
            
            //Yani satıra tıklanmışsa, satir değişkeni boş değilse
            if (satir != null)
            {
                emailForm.mailAdresi = satir["MAIL"].ToString();
            }
            emailForm.Show();
        }

        //Firmalarda gridview'a çift tıkladığında oluşacak olay
        private void rehberFirmalar1_DoubleClick(object sender, EventArgs e)
        {
            FormEmail emailForm = new FormEmail();
            DataRow satir = rehberFirmalar1.GetDataRow(rehberFirmalar1.FocusedRowHandle);

            //Yani satıra tıklanmışsa, satir değişkeni boş değilse
            if (satir != null)
            {
                emailForm.mailAdresi = satir["MAIL"].ToString();
            }
            emailForm.Show();
        }
    }
}
