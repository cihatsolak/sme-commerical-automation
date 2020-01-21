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
    public partial class FormFirmalar : Form
    {
        public FormFirmalar()
        {
            InitializeComponent();
        }

        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Verileri gridView'a çekme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM TBLFIRMALAR",database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridFirmalar.DataSource = tablo;
        }

        //Il verilerini combobox'a çekme
        void il()
        {
            SqlCommand ilCek = new SqlCommand("SELECT SEHIR FROM TBLILLER", database.baglanti());
            SqlDataReader oku = ilCek.ExecuteReader();
            while (oku.Read())
            {
                cmbBoxIL.Properties.Items.Add(oku[0]);
            }
            database.baglanti().Close();
        }

        //İlceler combobox'ı için: "il combobox'ında herhangi bir değişiklik olduğunda
        private void cmbBoxIL_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbBoxILCE.Properties.Items.Clear();
            //İl combobox'ında secilen index değerine göre ilceleri getir.
            SqlCommand ilceCek = new SqlCommand("SELECT ILCE FROM TBLILCELER WHERE SEHIR=@p1", database.baglanti());
            ilceCek.Parameters.AddWithValue("@p1", cmbBoxIL.SelectedIndex + 1);
            SqlDataReader oku = ilceCek.ExecuteReader();
            while (oku.Read())
            {
                cmbBoxILCE.Properties.Items.Add(oku[0]);
            }
            database.baglanti().Close();
        }
       
        //formdaki kontrolleri temizleme
        void temizle()
        {
            txtAd.Text = ""; txtStatu.Text = ""; txtYetkiliAd.Text = ""; txtTC.Text = ""; txtSektor.Text = ""; txtVergiDairesi.Text = ""; txtAdres.Text = ""; txtOzelKod2.Text = ""; txtId.Text = "";
            txtTelefon1.Text = ""; txtTelefon2.Text = ""; txtTelefon3.Text = ""; txtMail.Text = ""; cmbBoxIL.Text = ""; cmbBoxILCE.Text = "";  txtOzelKod1.Text = ""; txtOzelKod3.Text = ""; txtFax.Text = "";
            this.ActiveControl = txtAd;
        }

        //Özel kodları çağırma
        void carikodaciklamalar()
        {
            SqlCommand cagir = new SqlCommand("SELECT * FROM TBLKODLAR", database.baglanti());
            SqlDataReader oku = cagir.ExecuteReader();
            while (oku.Read())
            {
                richTxt1.Text = oku[0].ToString();
                richTxt2.Text = oku[1].ToString();
                richTxt3.Text = oku[2].ToString();
            }
            database.baglanti().Close();
        }

        //FORM LOAD 
        private void formFirmalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            il();
            carikodaciklamalar();
   
            //Grid Özellikleri sütun kapatma
            gridFirmalar1.OptionsBehavior.Editable = false;
            gridFirmalar1.Columns["ID"].Visible = false;
            gridFirmalar1.Columns["YETKILITC"].Visible = false;
            gridFirmalar1.Columns["SEKTOR"].Visible = false;
            gridFirmalar1.Columns["TELEFON2"].Visible = false;
            gridFirmalar1.Columns["TELEFON3"].Visible = false;
            gridFirmalar1.Columns["FAX"].Visible = false;
            gridFirmalar1.Columns["ILCE"].Visible = false;
            gridFirmalar1.Columns["OZELKOD1"].Visible = false;
            gridFirmalar1.Columns["OZELKOD2"].Visible = false;
            gridFirmalar1.Columns["OZELKOD3"].Visible = false;
        }

        //Gridview'daki veriyi kontrollere çekmes
        private void gridFirmalar1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridFirmalar1.GetDataRow(gridFirmalar1.FocusedRowHandle);
            if (satir != null)
            {
                txtId.Text = satir["ID"].ToString();
                txtAd.Text= satir["AD"].ToString();
                txtSektor.Text= satir["SEKTOR"].ToString();
                txtYetkiliAd.Text= satir["YETKILIADSOYAD"].ToString();
                txtTC.Text = satir["YETKILITC"].ToString();
                txtStatu.Text= satir["YETKILISTATU"].ToString();
                txtTelefon1.Text= satir["TELEFON1"].ToString();
                txtTelefon2.Text= satir["TELEFON2"].ToString();
                txtTelefon3.Text= satir["TELEFON3"].ToString();
                txtFax.Text= satir["FAX"].ToString();
                txtMail.Text = satir["MAIL"].ToString();
                cmbBoxIL.Text= satir["IL"].ToString();
                cmbBoxILCE.Text= satir["ILCE"].ToString();
                txtVergiDairesi.Text= satir["VERGIDAIRE"].ToString();
                txtAdres.Text= satir["ADRES"].ToString();
                txtOzelKod1.Text= satir["OZELKOD1"].ToString();
                txtOzelKod2.Text= satir["OZELKOD2"].ToString();
                txtOzelKod3.Text= satir["OZELKOD3"].ToString();
            }
        }

        //Firma kaydetme
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtTC.Text != "" && txtVergiDairesi.Text != "")
            {
                SqlCommand kayitEkle = new SqlCommand("INSERT INTO TBLFIRMALAR(AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", database.baglanti());
                kayitEkle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                kayitEkle.Parameters.AddWithValue("@p2", txtStatu.Text.ToUpper());
                kayitEkle.Parameters.AddWithValue("@p3", txtYetkiliAd.Text.ToUpper());
                kayitEkle.Parameters.AddWithValue("@p4", txtTC.Text);
                kayitEkle.Parameters.AddWithValue("@p5", txtSektor.Text.ToUpper());
                kayitEkle.Parameters.AddWithValue("@p6", txtTelefon1.Text);
                kayitEkle.Parameters.AddWithValue("@p7", txtTelefon2.Text);
                kayitEkle.Parameters.AddWithValue("@p8", txtTelefon3.Text);
                kayitEkle.Parameters.AddWithValue("@p9", txtMail.Text.ToLower());
                kayitEkle.Parameters.AddWithValue("@p10", txtFax.Text);
                kayitEkle.Parameters.AddWithValue("@p11", cmbBoxIL.Text);
                kayitEkle.Parameters.AddWithValue("@p12", cmbBoxILCE.Text);
                kayitEkle.Parameters.AddWithValue("@p13", txtVergiDairesi.Text.ToUpper());
                kayitEkle.Parameters.AddWithValue("@p14", txtAdres.Text.ToUpper());
                kayitEkle.Parameters.AddWithValue("@p15", txtOzelKod1.Text.ToUpper());
                kayitEkle.Parameters.AddWithValue("@p16", txtOzelKod2.Text.ToUpper());
                kayitEkle.Parameters.AddWithValue("@p17", txtOzelKod3.Text.ToUpper());
                try
                {
                    kayitEkle.ExecuteNonQuery();
                    database.baglanti().Close();
                    listele();
                    temizle();
                    MessageBox.Show("Firma bilgileri kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Firma bilgileri KAYDEDİLEMEDİ!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Eklemek istediğiniz firma bilgilerini boş bırakmayınız!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        //Firma Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Seçilen firma bilgilerini silmek istiyor musunuz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                SqlCommand kayitSil = new SqlCommand("DELETE FROM TBLFIRMALAR WHERE ID=@p1", database.baglanti());
                kayitSil.Parameters.AddWithValue("@p1", txtId.Text);
                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        kayitSil.ExecuteNonQuery();
                        listele();
                        MessageBox.Show("Firma bilgileri silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        database.baglanti().Close();
                        temizle();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Firma bilgileri SİLİNEMEDİ.", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Silmek istediğiniz firmayı seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Firma Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Seçilen firma bilgilerini güncellemek istiyor musunuz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                SqlCommand kayitGuncelle = new SqlCommand("UPDATE TBLFIRMALAR SET AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,IL=@p10,ILCE=@p11,FAX=@p12,VERGIDAIRE=@p13,ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 WHERE ID=@p18 ", database.baglanti());
                kayitGuncelle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p2", txtStatu.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p3", txtYetkiliAd.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p4", txtTC.Text);
                kayitGuncelle.Parameters.AddWithValue("@p5", txtSektor.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p6", txtTelefon1.Text);
                kayitGuncelle.Parameters.AddWithValue("@p7", txtTelefon2.Text);
                kayitGuncelle.Parameters.AddWithValue("@p8", txtTelefon3.Text);
                kayitGuncelle.Parameters.AddWithValue("@p9", txtMail.Text.ToLower());
                kayitGuncelle.Parameters.AddWithValue("@p10", cmbBoxIL.Text);
                kayitGuncelle.Parameters.AddWithValue("@p11", cmbBoxILCE.Text);
                kayitGuncelle.Parameters.AddWithValue("@p12", txtFax.Text);
                kayitGuncelle.Parameters.AddWithValue("@p13", txtVergiDairesi.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p14", txtAdres.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p15", txtOzelKod1.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p16", txtOzelKod2.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p17", txtOzelKod3.Text.ToUpper());
                kayitGuncelle.Parameters.AddWithValue("@p18", txtId.Text);
                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        kayitGuncelle.ExecuteNonQuery();
                        temizle();
                        listele();
                        MessageBox.Show("Firma bilgileri güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        database.baglanti().Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Firma bilgileri GÜNCELLENEMEDİ!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Güncellemek istediğiniz firmayı seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Buton Temizle
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
