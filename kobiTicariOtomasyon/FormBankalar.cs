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
    public partial class FormBankalar : Form
    {
        public FormBankalar()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Gridview'daki verileri çekme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("EXECUTE BANKABILGILERI", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridBankalar.DataSource = tablo;
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

        //Firma adı'na göre id çekme
        void firmalistesi()
        {
            SqlDataAdapter firma = new SqlDataAdapter("SELECT ID,AD FROM TBLFIRMALAR", database.baglanti());
            DataTable tablo = new DataTable();
            firma.Fill(tablo);
            lookUpFirma.Properties.NullText = "Lütfen firma adı seçiniz.";
            lookUpFirma.Properties.ValueMember = "ID";
            lookUpFirma.Properties.DisplayMember = "AD";
            lookUpFirma.Properties.DataSource = tablo;
        }

        //Form kontrolleri temizleme
        void temizle()
        {
            txtId.Text = ""; cmbBankaAdi.Text = ""; cmbBoxIL.Text = ""; cmbBoxILCE.Text = ""; txtTarih.Text = ""; txtHesapTur.Text = ""; this.ActiveControl = txtSube;
            txtSube.Text = ""; txtIban.Text = ""; txtHesapNo.Text = ""; txtYetkili.Text = ""; txtTelefon.Text = ""; lookUpFirma.EditValue = null;
        }
        
        //Grid'deki verileri form kontrollerine çekme
        private void gridBankalar1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridBankalar1.GetDataRow(gridBankalar1.FocusedRowHandle);
            if (satir != null)
            {
                txtId.Text = satir[0].ToString();
                cmbBankaAdi.Text = satir[1].ToString();
                cmbBoxIL.Text = satir[2].ToString();
                cmbBoxILCE.Text = satir[3].ToString();
                txtSube.Text = satir[4].ToString();
                txtIban.Text = satir[5].ToString();
                txtHesapNo.Text = satir[6].ToString();
                txtYetkili.Text = satir[7].ToString();
                txtTelefon.Text = satir[8].ToString();
                txtTarih.Text = satir[9].ToString();
                txtHesapTur.Text = satir[10].ToString();
                lookUpFirma.Text = satir[11].ToString();
            }
        }

        //FORM LOAD
        private void formBankalar_Load(object sender, EventArgs e)
        {
            listele();
            il();
            firmalistesi();
            temizle();
            gridBankalar1.OptionsBehavior.Editable = false;
        }

        //Banka Kaydet
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtIban.Text != "" && txtYetkili.Text != "" && txtTarih.Text != "")
            {
                SqlCommand bankaKaydet = new SqlCommand("INSERT INTO TBLBANKALAR(BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) " +
                "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", database.baglanti());
                bankaKaydet.Parameters.AddWithValue("@p1", cmbBankaAdi.Text);
                bankaKaydet.Parameters.AddWithValue("@p2", cmbBoxIL.Text);
                bankaKaydet.Parameters.AddWithValue("@p3", cmbBoxILCE.Text);
                bankaKaydet.Parameters.AddWithValue("@p4", txtSube.Text.ToUpper());
                bankaKaydet.Parameters.AddWithValue("@p5", txtIban.Text);
                bankaKaydet.Parameters.AddWithValue("@p6", txtHesapNo.Text);
                bankaKaydet.Parameters.AddWithValue("@p7", txtYetkili.Text.ToUpper());
                bankaKaydet.Parameters.AddWithValue("@p8", txtTelefon.Text);
                bankaKaydet.Parameters.AddWithValue("@p9", txtTarih.Text);
                bankaKaydet.Parameters.AddWithValue("@p10", txtHesapTur.Text.ToUpper());
                bankaKaydet.Parameters.AddWithValue("@p11", lookUpFirma.EditValue);
                try
                {
                    bankaKaydet.ExecuteNonQuery();
                    listele();
                    temizle();
                    database.baglanti().Close();
                    MessageBox.Show("Banka bilgileri kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Banka bilgileri kaydedilemedi.", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Eklemek istediğiniz banka bilgilerini boş bırakmayınız!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Form temizle
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        //Banka Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult cevap = MessageBox.Show("Belirtilen banka bilgisi siliniyor, emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand bankaSil = new SqlCommand("DELETE FROM TBLBANKALAR WHERE ID=@p1", database.baglanti());
                    bankaSil.Parameters.AddWithValue("@p1", txtId.Text);
                    try
                    {
                        bankaSil.ExecuteNonQuery();
                        database.baglanti().Close();
                        listele();
                        temizle();
                        MessageBox.Show("Banka bilgisi silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Banka bilgileri SİLİNEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Lütfen silmek istediğiniz banka'yı seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Banka Güncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult cevap = MessageBox.Show("Banka bilgisi güncelleniyor, emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand bankaGuncelle = new SqlCommand("UPDATE TBLBANKALAR SET BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 WHERE ID=@p12", database.baglanti());
                    bankaGuncelle.Parameters.AddWithValue("@p1", cmbBankaAdi.Text);
                    bankaGuncelle.Parameters.AddWithValue("@p2", cmbBoxIL.Text);
                    bankaGuncelle.Parameters.AddWithValue("@p3", cmbBoxILCE.Text);
                    bankaGuncelle.Parameters.AddWithValue("@p4", txtSube.Text.ToUpper());
                    bankaGuncelle.Parameters.AddWithValue("@p5", txtIban.Text);
                    bankaGuncelle.Parameters.AddWithValue("@p6", txtHesapNo.Text);
                    bankaGuncelle.Parameters.AddWithValue("@p7", txtYetkili.Text.ToUpper());
                    bankaGuncelle.Parameters.AddWithValue("@p8", txtTelefon.Text);
                    bankaGuncelle.Parameters.AddWithValue("@p9", txtTarih.Text);
                    bankaGuncelle.Parameters.AddWithValue("@p10", txtHesapTur.Text.ToUpper());
                    bankaGuncelle.Parameters.AddWithValue("@p11", lookUpFirma.EditValue);
                    bankaGuncelle.Parameters.AddWithValue("@p12", txtId.Text);
                    try
                    {
                        bankaGuncelle.ExecuteNonQuery();
                        listele();
                        temizle();
                        database.baglanti().Close();
                        MessageBox.Show("Banka bilgileri güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Banka bilgileri GÜNCELLENEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Lütfen güncellemek istediğiniz banka'yı seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
