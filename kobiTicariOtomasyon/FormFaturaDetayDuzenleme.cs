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
    public partial class FormFaturaDetayDuzenleme : Form
    {
        public FormFaturaDetayDuzenleme()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();
        public string id;

        //FORM LOAD
        private void FormFaturaDetayDuzenleme_Load(object sender, EventArgs e)
        {
            TxtUrunId.Text = id;

            SqlCommand getir = new SqlCommand("SELECT * FROM TBLFATURADETAY WHERE FATURAURUNID=@p1", database.baglanti());
            getir.Parameters.AddWithValue("@p1", id);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                TxtUrunAd.Text = oku["URUNAD"].ToString();
                TxtAdet.Text = oku["MIKTAR"].ToString();
                TxtFiyat.Text = oku["FIYAT"].ToString();
                TxtTutar.Text = oku["TUTAR"].ToString();
            }
        }

        //Ürün Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Belirtilen ürün güncelleniyor, emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                SqlCommand UrunGuncelle = new SqlCommand("UPDATE TBLFATURADETAY SET URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4 WHERE FATURAURUNID=@p5", database.baglanti());
                UrunGuncelle.Parameters.AddWithValue("@p1", TxtUrunAd.Text.ToUpper());
                UrunGuncelle.Parameters.AddWithValue("@p2", TxtAdet.Text);
                UrunGuncelle.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                UrunGuncelle.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                UrunGuncelle.Parameters.AddWithValue("@p5", TxtUrunId.Text);
                try
                {
                    UrunGuncelle.ExecuteNonQuery();
                    MessageBox.Show("Ürün güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    database.baglanti().Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Ürün GÜNCELLENEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    database.baglanti().Close();
                }
            }
        }

        //Buton Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Belirtilen ürün siliniyor, emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                SqlCommand UrunSil = new SqlCommand("DELETE FROM TBLFATURADETAY WHERE FATURAURUNID=@p1", database.baglanti());
                UrunSil.Parameters.AddWithValue("@p1", TxtUrunId.Text);
                try
                {
                    UrunSil.ExecuteNonQuery();
                    MessageBox.Show("Ürün silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    database.baglanti().Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Ürün SİLİNEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    database.baglanti().Close();
                }
            }
        }

        //Form Kapatılınca
        private void FormFaturaDetayDuzenleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormFaturaDetay detayform = (FormFaturaDetay)Application.OpenForms["FormFaturaDetay"];
            detayform.listele();
        }
    }
}
