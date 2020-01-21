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
    public partial class FormGiderler : Form
    {
        public FormGiderler()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Combobox'lara içinde bulunan ay ve yil'i çekme
        void zaman()
        {
            DateTime Tarih = DateTime.Today;
            cmbBoxYIL.Text = Tarih.Year.ToString();
            string tarih = DateTime.Now.ToString("MMMM");
            cmbBoxAY.Text = tarih.ToUpper();
        }

        //Form Kontrollerini Temizleme
        void temizle()
        {
            zaman();
            this.ActiveControl = txtElektrik;
            txtId.Text = ""; txtDogalgaz.Text = ""; txtEkstra.Text = ""; txtElektrik.Text = ""; txtInternet.Text = "";
            txtMaaslar.Text = ""; txtNotlar.Text = ""; txtSu.Text = "";
        }
        //giderleri listeleme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM TBLGIDERLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridGiderler.DataSource = tablo;
        }
        
        //GridView'dan kontrollere veri taşıma
        private void gridGiderler1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridGiderler1.GetDataRow(gridGiderler1.FocusedRowHandle);
            if (satir!=null)
            {
                txtId.Text = satir["ID"].ToString();
                cmbBoxAY.Text = satir["AY"].ToString();
                cmbBoxYIL.Text = satir["YIL"].ToString();
                txtElektrik.Text = satir["ELEKTRIK"].ToString();
                txtSu.Text = satir["SU"].ToString();
                txtDogalgaz.Text = satir["DOGALGAZ"].ToString();
                txtInternet.Text = satir["INTERNET"].ToString();
                txtMaaslar.Text = satir["MAASLAR"].ToString();
                txtEkstra.Text = satir["EKSTRA"].ToString();
                txtNotlar.Text = satir["NOTLAR"].ToString();
            }
        }

        //FORM LOAD
        private void formGiderler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            gridGiderler1.OptionsBehavior.Editable = false;
            gridGiderler1.Columns["ID"].Visible = false;
        }

        //Form kontrolleri temizleme
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        //GİDER EKLEME
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtElektrik.Text != "" && txtSu.Text != "" && txtDogalgaz.Text != "")
            {
                SqlCommand giderEkle = new SqlCommand("INSERT INTO TBLGIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", database.baglanti());
                giderEkle.Parameters.AddWithValue("@p1", cmbBoxAY.Text);
                giderEkle.Parameters.AddWithValue("@p2", cmbBoxYIL.Text);
                giderEkle.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
                giderEkle.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
                giderEkle.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
                giderEkle.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
                giderEkle.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
                giderEkle.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
                giderEkle.Parameters.AddWithValue("@p9", txtNotlar.Text.ToUpper());
                try
                {
                    giderEkle.ExecuteNonQuery();
                    listele();
                    temizle();
                    database.baglanti().Close();
                    MessageBox.Show("Gider bilgileri kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hata ** Gider EKLENEMEDİ!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Lütfen eklemek istediğiniz giderin bilgilerini boş bırakmayınız!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Gider silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult cevap = MessageBox.Show("Belirtilen gider silinsin mi?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand giderSil = new SqlCommand("DELETE FROM TBLGIDERLER WHERE ID=@p1", database.baglanti());
                    giderSil.Parameters.AddWithValue("@p1", txtId.Text);
                    try
                    {
                        giderSil.ExecuteNonQuery();
                        listele();
                        temizle();
                        database.baglanti().Close();
                        MessageBox.Show("Gider silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Gider SİLİNEMEDİ!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Lütfen silmek istediğiniz gideri seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Gider güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Belirtilen gider güncellensin mi?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand giderGuncelle = new SqlCommand("UPDATE TBLGIDERLER SET AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 WHERE ID=@p10",database.baglanti());
                    giderGuncelle.Parameters.AddWithValue("@p1",cmbBoxAY.Text);
                    giderGuncelle.Parameters.AddWithValue("@p2",cmbBoxYIL.Text);
                    giderGuncelle.Parameters.AddWithValue("@p3",decimal.Parse(txtElektrik.Text));
                    giderGuncelle.Parameters.AddWithValue("@p4",decimal.Parse(txtSu.Text));
                    giderGuncelle.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
                    giderGuncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
                    giderGuncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
                    giderGuncelle.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
                    giderGuncelle.Parameters.AddWithValue("@p9",txtNotlar.Text.ToUpper());
                    giderGuncelle.Parameters.AddWithValue("@p10",txtId.Text);

                    try
                    {
                        giderGuncelle.ExecuteNonQuery();
                        listele();
                        temizle();
                        database.baglanti().Close();
                        MessageBox.Show("Gider güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Gider GÜNCELLENEMEDİ!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Lütfen güncellemek istediğiniz gideri seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
