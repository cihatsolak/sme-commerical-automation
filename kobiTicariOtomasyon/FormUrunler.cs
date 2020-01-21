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
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }

        //Global alan
        sqlBaglantisi database = new sqlBaglantisi();

        //Verileri listele
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM TBLURUNLER", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridUrunler.DataSource = tablo;
        }

        //Grupbox içindeki ögeleri temizleme
        void temizle()
        {
            txtId.Text = ""; txtAd.Text = ""; txtMarka.Text = ""; txtModel.Text = ""; txtYil.Text = "";
            numericAdet.Value = 0; txtAlisFiyat.Text = ""; txtSatisFiyat.Text = ""; txtDetay.Text = "";
            this.ActiveControl = txtAd;
        }

        //FORM LOAD
        private void formUrunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            gridUrunler1.OptionsBehavior.Editable = false;
            gridUrunler1.Columns["ID"].Visible = false;
        }

        //Gridview'dan textboxlara veri çekmek için
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridUrunler1.GetDataRow(gridUrunler1.FocusedRowHandle);
            if (satir != null)
            {
                txtId.Text = satir["ID"].ToString();
                txtAd.Text = satir["URUNAD"].ToString();
                txtMarka.Text = satir["MARKA"].ToString();
                txtModel.Text = satir["MODEL"].ToString();
                txtYil.Text = satir["YIL"].ToString();
                numericAdet.Value = int.Parse(satir["ADET"].ToString());
                txtAlisFiyat.Text = satir["ALISFIYAT"].ToString();
                txtSatisFiyat.Text = satir["SATISFIYAT"].ToString();
                txtDetay.Text = satir["DETAY"].ToString();
            }
        }

        //Ürün Kaydetme
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtAlisFiyat.Text != "" && txtSatisFiyat.Text != "")
            {
                SqlCommand kaydet = new SqlCommand("INSERT INTO TBLURUNLER(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", database.baglanti());
                kaydet.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", txtMarka.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p3", txtModel.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p4", txtYil.Text);
                kaydet.Parameters.AddWithValue("@p5", int.Parse((numericAdet.Value).ToString()));
                kaydet.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
                kaydet.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
                kaydet.Parameters.AddWithValue("@p8", txtDetay.Text.ToUpper());
                try
                {
                    kaydet.ExecuteNonQuery();
                    database.baglanti().Close();
                    listele();
                    temizle();
                    MessageBox.Show("Ürün sisteme eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Ürün EKLENEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Eklemek istediğiniz ürüne ait bilgileri boş bırakmayınız!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Ürün Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Seçilen ürün siliniyor, emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand sil = new SqlCommand("DELETE FROM TBLURUNLER WHERE ID=@p1", database.baglanti());
                        sil.Parameters.AddWithValue("@p1", txtId.Text);
                        sil.ExecuteNonQuery();
                        database.baglanti().Close();
                        listele();
                        temizle();
                        MessageBox.Show("Ürün silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Ürün SİLİNEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Silmek istediğiniz ürünü seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Ürün Güncelleme İşlemi
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Ürün güncelleniyor, emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand guncelle = new SqlCommand("UPDATE TBLURUNLER SET URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 WHERE ID=@p9", database.baglanti());
                        guncelle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                        guncelle.Parameters.AddWithValue("@p2", txtMarka.Text.ToUpper());
                        guncelle.Parameters.AddWithValue("@p3", txtModel.Text.ToUpper());
                        guncelle.Parameters.AddWithValue("@p4", txtYil.Text);
                        guncelle.Parameters.AddWithValue("@p5", int.Parse((numericAdet.Value).ToString()));
                        guncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
                        guncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
                        guncelle.Parameters.AddWithValue("@p8", txtDetay.Text.ToUpper());
                        guncelle.Parameters.AddWithValue("@p9", txtId.Text);
                        guncelle.ExecuteNonQuery();
                        database.baglanti().Close();
                        listele();
                        temizle();
                        MessageBox.Show("Ürün güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Ürün GÜNCELLENEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Güncellemek istediğiniz ürünü seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Form Temizleme
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
