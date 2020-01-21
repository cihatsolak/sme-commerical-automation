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
    public partial class FormPersoneller : Form
    {
        public FormPersoneller()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Veritabanından veri çekme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM TBLPERSONELLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridPersonel.DataSource = tablo;
        }
        
        //form kontrollerini temizleme
        void temizle()
        {
            txtId.Text = ""; txtAd.Text = ""; txtSoyad.Text = ""; txtTelefon.Text = ""; txtTc.Text = "";
            txtMail.Text = ""; cmbBoxIL.Text = ""; cmbBoxILCE.Text = ""; txtAdres.Text = ""; txtGorev.Text = "";
            this.ActiveControl = txtAd;
        }
        
        //combobox'a il çekme
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

        //İl'e göre combobox'a ilçe çekme
        private void cmbBoxIL_SelectedIndexChanged(object sender, EventArgs e)
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

        //Gridview'dan kontrollere veri çekme
        private void gridPersoneller1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridPersoneller1.GetDataRow(gridPersoneller1.FocusedRowHandle);
            if (satir!=null)
            {
                txtId.Text = satir[0].ToString();
                txtAd.Text = satir[1].ToString();
                txtSoyad.Text = satir[2].ToString();
                txtTelefon.Text = satir[3].ToString();
                txtTc.Text = satir[4].ToString();
                txtMail.Text = satir[5].ToString();
                cmbBoxIL.Text = satir[6].ToString();
                cmbBoxILCE.Text = satir[7].ToString();
                txtAdres.Text = satir[8].ToString();
                txtGorev.Text = satir[9].ToString();
            }
        }

        //FORM LOAD
        private void formPersoneller_Load(object sender, EventArgs e)
        {
            listele();
            il();
            temizle();
            gridPersoneller1.OptionsBehavior.Editable = false;
            gridPersoneller1.Columns["ID"].Visible = false;
        }

        //Personel ekleme
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtTc.Text != "")
            {
                SqlCommand personelEkle = new SqlCommand("INSERT INTO TBLPERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", database.baglanti());
                personelEkle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                personelEkle.Parameters.AddWithValue("@p2", txtSoyad.Text.ToUpper());
                personelEkle.Parameters.AddWithValue("@p3", txtTelefon.Text);
                personelEkle.Parameters.AddWithValue("@p4", txtTc.Text);
                personelEkle.Parameters.AddWithValue("@p5", txtMail.Text.ToLower());
                personelEkle.Parameters.AddWithValue("@p6", cmbBoxIL.Text);
                personelEkle.Parameters.AddWithValue("@p7", cmbBoxILCE.Text);
                personelEkle.Parameters.AddWithValue("@p8", txtAdres.Text.ToUpper());
                personelEkle.Parameters.AddWithValue("@p9", txtGorev.Text.ToUpper());
                try
                {
                    personelEkle.ExecuteNonQuery();
                    listele();
                    temizle();
                    database.baglanti().Close();
                    MessageBox.Show("Personel kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Personel KAYDEDİLEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Eklemek istediğiniz personelin bilgilerini boş bırakmayınız!");
        }
        
        //Kontrolleri temizleme
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        //Personel Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Belirtilen personel siliniyor, emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand personelSil = new SqlCommand("DELETE FROM TBLPERSONELLER WHERE ID=@p1", database.baglanti());
                    personelSil.Parameters.AddWithValue("@p1", txtId.Text);
                    try
                    {
                        personelSil.ExecuteNonQuery();
                        database.baglanti().Close();
                        listele();
                        temizle();
                        MessageBox.Show("Personel silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Personel SİLİNEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Silmek istediğiniz personeli seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Personel Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Personel bilgileri güncelleniyor, emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand personelGuncelle = new SqlCommand("UPDATE TBLPERSONELLER SET AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GOREV=@p9 WHERE ID=@p10", database.baglanti());
                    personelGuncelle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                    personelGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text.ToUpper());
                    personelGuncelle.Parameters.AddWithValue("@p3", txtTelefon.Text);
                    personelGuncelle.Parameters.AddWithValue("@p4", txtTc.Text);
                    personelGuncelle.Parameters.AddWithValue("@p5", txtMail.Text.ToLower());
                    personelGuncelle.Parameters.AddWithValue("@p6", cmbBoxIL.Text);
                    personelGuncelle.Parameters.AddWithValue("@p7", cmbBoxILCE.Text);
                    personelGuncelle.Parameters.AddWithValue("@p8", txtAdres.Text.ToUpper());
                    personelGuncelle.Parameters.AddWithValue("@p9", txtGorev.Text.ToUpper());
                    personelGuncelle.Parameters.AddWithValue("@p10", txtId.Text);
                    try
                    {
                        personelGuncelle.ExecuteNonQuery();
                        listele();
                        temizle();
                        database.baglanti().Close();
                        MessageBox.Show("Personel bilgileri güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Personel bilgileri GÜNCELLENEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            MessageBox.Show("Güncellemek istediğiniz personeli seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
