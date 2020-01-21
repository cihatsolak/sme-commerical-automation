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
    public partial class FormNotlar : Form
    {
        public FormNotlar()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Not Durumu
        bool durum()
        {
            if (radioBeklemede.Checked == true)
                return false;
            else if (radioGerceklesti.Checked == true)
                return true;
            else if (radioBeklemede.Checked == false)
                return true;
            else if (radioGerceklesti.Checked == false)
                return false;
            else
                return false;
        }

        //Form Temizleme
        void temizle()
        {
            txtBaslik.Text = ""; txtDetay.Text = ""; txtHitap.Text = ""; txtOlusturan.Text = ""; txtSaat.Text = ""; txtTarih.Text = ""; txtId.Text = ""; this.ActiveControl = txtBaslik;
        }

        //Gridview'daki verileri listeleme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM TBLNOTLAR", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridNotlar.DataSource = tablo;
        }

        //FORM LOAD
        private void FormNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            gridNotlar1.OptionsBehavior.Editable = false;
            gridNotlar1.Columns["ID"].Visible = false;
        }

        //Form Temizleme
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        //Not Ekleme
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBaslik.Text != "" && txtTarih.Text != "")
            {
                SqlCommand notKaydet = new SqlCommand("INSERT INTO TBLNOTLAR(TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP,DURUM) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", database.baglanti());
                notKaydet.Parameters.AddWithValue("@p1", txtTarih.Text);
                notKaydet.Parameters.AddWithValue("@p2", txtSaat.Text);
                notKaydet.Parameters.AddWithValue("@p3", txtBaslik.Text.ToUpper());
                notKaydet.Parameters.AddWithValue("@p4", txtDetay.Text.ToUpper());
                notKaydet.Parameters.AddWithValue("@p5", txtOlusturan.Text.ToUpper());
                notKaydet.Parameters.AddWithValue("@p6", txtHitap.Text.ToUpper());
                notKaydet.Parameters.AddWithValue("@p7", durum());
                try
                {
                    notKaydet.ExecuteNonQuery();
                    listele();
                    temizle();
                    database.baglanti().Close();
                    MessageBox.Show("Not başarıyla eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Not belirlenemeyen bir sebeple, eklenemedi!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridNotlar1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridNotlar1.GetDataRow(gridNotlar1.FocusedRowHandle);
            if (satir != null)
            {
                txtId.Text = satir["ID"].ToString();
                txtTarih.Text = satir["TARIH"].ToString();
                txtSaat.Text = satir["SAAT"].ToString();
                txtBaslik.Text = satir["BASLIK"].ToString();
                txtDetay.Text = satir["DETAY"].ToString();
                txtOlusturan.Text = satir["OLUSTURAN"].ToString();
                txtHitap.Text = satir["HITAP"].ToString();
                if (bool.Parse(satir["DURUM"].ToString()) == true)
                    radioGerceklesti.Checked = true;
                else
                    radioBeklemede.Checked = true;
            }
        }

        //Not Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult cevap = MessageBox.Show("Belirtilen not silinsin mi?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand notSil = new SqlCommand("DELETE FROM TBLNOTLAR WHERE ID='" + txtId.Text + "'", database.baglanti());
                    try
                    {
                        notSil.ExecuteNonQuery();
                        listele();
                        temizle();
                        database.baglanti().Close();
                        MessageBox.Show("Not Silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Belirlenemeyen bir sebeple, Not Silinemedi!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
                MessageBox.Show("Silmek istediğiniz notu seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Not Güncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult cevap = MessageBox.Show("Belirtilen not güncellensin mi?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand notGuncelle = new SqlCommand("UPDATE TBLNOTLAR SET TARIH=@p1,SAAT=@p2,BASLIK=@p3,DETAY=@p4,OLUSTURAN=@p5,HITAP=@p6,DURUM=@p7 WHERE ID=@p8", database.baglanti());
                    notGuncelle.Parameters.AddWithValue("@p1", txtTarih.Text);
                    notGuncelle.Parameters.AddWithValue("@p2", txtSaat.Text);
                    notGuncelle.Parameters.AddWithValue("@p3", txtBaslik.Text.ToUpper());
                    notGuncelle.Parameters.AddWithValue("@p4", txtDetay.Text.ToUpper());
                    notGuncelle.Parameters.AddWithValue("@p5", txtOlusturan.Text.ToUpper());
                    notGuncelle.Parameters.AddWithValue("@p6", txtHitap.Text.ToUpper());
                    notGuncelle.Parameters.AddWithValue("@p7", durum());
                    notGuncelle.Parameters.AddWithValue("@p8", txtId.Text);
                    try
                    {
                        notGuncelle.ExecuteNonQuery();
                        listele();
                        temizle();
                        database.baglanti().Close();
                        MessageBox.Show("Not Güncellendi!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Belirlenemeyen bir sebeple, Not güncelllenemedi!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
                MessageBox.Show("Güncellemek istediğiniz notu seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Grid'e çift tıklanınca oluşacak değer
        private void gridNotlar1_DoubleClick(object sender, EventArgs e)
        {
            DataRow satir = gridNotlar1.GetDataRow(gridNotlar1.FocusedRowHandle);
            if (satir!=null)
            {
                FormNotlarDetay detay = new FormNotlarDetay();
                detay.id = satir["ID"].ToString();
                detay.Show();
            }
        }
    }
}
