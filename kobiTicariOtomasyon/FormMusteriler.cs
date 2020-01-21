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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Verileri dataGrid'e çekme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM TBLMUSTERILER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridMusteriler.DataSource = tablo;
        }
        
        //Form araçları temizleme
        void temizle()
        {
            txtId.Text = ""; txtAd.Text = ""; txtSoyad.Text = ""; txtTC.Text = "";
            txtTelefon1.Text = ""; txtTelefon2.Text = ""; txtEmail.Text = "";
            cmbBoxIL.Text = ""; cmbBoxILCE.Text = ""; txtAdres.Text = ""; txtVergiDaire.Text = "";
            this.ActiveControl = txtAd;
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
        private void cmbBoxIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxILCE.Properties.Items.Clear();
            //İl combobox'ında secilen index değerine göre ilceleri getir.
            SqlCommand ilceCek = new SqlCommand("SELECT ILCE FROM TBLILCELER WHERE SEHIR=@p1", database.baglanti());
            ilceCek.Parameters.AddWithValue("@p1", cmbBoxIL.SelectedIndex+1);
            SqlDataReader oku = ilceCek.ExecuteReader();
            while (oku.Read())
            {
                cmbBoxILCE.Properties.Items.Add(oku[0]);
            }
            database.baglanti().Close();
        }
        
        //FORM LOAD
        private void formMusteriler_Load(object sender, EventArgs e)
        {
            il();
            listele();
            temizle();
            gridMusteriler1.OptionsBehavior.Editable = false;
            gridMusteriler1.Columns["ID"].Visible = false;
            gridMusteriler1.Columns["TELEFON2"].Visible = false;
            gridMusteriler1.Columns["ILCE"].Visible = false;
        }

        //Gridview'da tıklanan satır'ı kontrollere aktarma
        private void gridMusteriler1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridMusteriler1.GetDataRow(gridMusteriler1.FocusedRowHandle);
            if (satir!=null)
            {
                txtId.Text = satir[0].ToString();
                txtAd.Text = satir[1].ToString();
                txtSoyad.Text = satir[2].ToString();
                txtTelefon1.Text = satir[3].ToString();
                txtTelefon2.Text = satir[4].ToString();
                txtTC.Text = satir[5].ToString();
                txtEmail.Text = satir[6].ToString();
                cmbBoxIL.Text = satir[7].ToString();
                cmbBoxILCE.Text = satir[8].ToString();
                txtAdres.Text = satir[9].ToString();
                txtVergiDaire.Text = satir[10].ToString();
            }
        }

        //Müşteri Kaydetme
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtTC.Text != "" && txtTelefon1.Text != "")
            {
                SqlCommand musteriEkle = new SqlCommand("INSERT INTO TBLMUSTERILER(AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", database.baglanti());
                musteriEkle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                musteriEkle.Parameters.AddWithValue("@p2", txtSoyad.Text.ToUpper());
                musteriEkle.Parameters.AddWithValue("@p3", txtTelefon1.Text);
                musteriEkle.Parameters.AddWithValue("@p4", txtTelefon2.Text);
                musteriEkle.Parameters.AddWithValue("@p5", txtTC.Text);
                musteriEkle.Parameters.AddWithValue("@p6", txtEmail.Text.ToLower());
                musteriEkle.Parameters.AddWithValue("@p7", cmbBoxIL.Text);
                musteriEkle.Parameters.AddWithValue("@p8", cmbBoxILCE.Text);
                musteriEkle.Parameters.AddWithValue("@p9", txtAdres.Text.ToUpper());
                musteriEkle.Parameters.AddWithValue("@p10", txtVergiDaire.Text.ToUpper());
                try
                {
                    musteriEkle.ExecuteNonQuery();
                    database.baglanti().Close();
                    temizle();
                    MessageBox.Show("Müşteri sisteme kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Müşteri KAYDEDİLEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Eklemek istediğiniz müşterinin bilgilerini boş bırakmayınız!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Müşteri Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Belirtilen müşteri siliniyor, emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand musteriSil = new SqlCommand("DELETE FROM TBLMUSTERILER WHERE ID=@p1", database.baglanti());
                    musteriSil.Parameters.AddWithValue("@p1", txtId.Text);
                    try
                    {
                        musteriSil.ExecuteNonQuery();
                        database.baglanti().Close();
                        listele();
                        temizle();
                        MessageBox.Show("Müşteri sistemden silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Müşteri SİLİNEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Silmek istediğiniz müşteriyi seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Müşteri Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Müşteri bilgileri güncelleniyor, emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand guncelle = new SqlCommand("UPDATE TBLMUSTERILER SET AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,VERGIDAIRE=@p9,ADRES=@p10 WHERE ID=@p11", database.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                    guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text.ToUpper());
                    guncelle.Parameters.AddWithValue("@p3", txtTelefon1.Text);
                    guncelle.Parameters.AddWithValue("@p4", txtTelefon2.Text);
                    guncelle.Parameters.AddWithValue("@p5", txtTC.Text);
                    guncelle.Parameters.AddWithValue("@p6", txtEmail.Text.ToLower());
                    guncelle.Parameters.AddWithValue("@p7", cmbBoxIL.Text);
                    guncelle.Parameters.AddWithValue("@p8", cmbBoxILCE.Text);
                    guncelle.Parameters.AddWithValue("@p9", txtAdres.Text.ToUpper());
                    guncelle.Parameters.AddWithValue("@p10", txtVergiDaire.Text.ToUpper());
                    guncelle.Parameters.AddWithValue("@p11", txtId.Text);
                    try
                    {
                        guncelle.ExecuteNonQuery();
                        database.baglanti().Close();
                        listele();
                        temizle();
                        MessageBox.Show("Müşteri bilgileri güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Müşteri bilgileri GÜNCELLENEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Güncellemek istediğiniz müşteriyi seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Form kontrolleri temizleme
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}