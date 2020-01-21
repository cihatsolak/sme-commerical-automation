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
    public partial class FormAyarlar : Form
    {
        public FormAyarlar()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Form temizleme
        void temizle()
        {
            txtKullanici.Text = "";
            txtSifre.Text= "";
            txtKod.Text = "";
            this.ActiveControl = txtKullanici;
            btnIslem.Text = "Kaydet";
        }

        //Kullanıcıları Listeleme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM TBLGIRISBILGILERI", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridKullanicilar.DataSource = tablo;
        }

        //Datagrid'e tıklandığı zaman
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridKullanicilar1.GetDataRow(gridKullanicilar1.FocusedRowHandle);
            if (satir!=null)
            {
                txtId.Text = satir["ID"].ToString();
                txtKullanici.Text = satir["KULLANICIADI"].ToString();
                txtSifre.Text = satir["SIFRE"].ToString();
                txtKod.Text = satir["GUVENLIKKODU"].ToString();
                btnIslem.Text = "Güncelle";
            }
        }

        //FORM LOAD
        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            gridKullanicilar1.OptionsBehavior.Editable = false;
            gridKullanicilar1.Columns["ID"].Visible = false;

        }

        private void txtKullanici_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSifre_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if(txtKullanici.Text!="" && txtSifre.Text != "" && txtKod.Text!="")
            {
                if (btnIslem.Text=="Kaydet")
                {
                    DialogResult cevap = MessageBox.Show("Kullanıcıyı eklemek istiyor musunuz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        SqlCommand kullaniciEkle = new SqlCommand("INSERT INTO TBLGIRISBILGILERI(KULLANICIADI,SIFRE,GUVENLIKKODU) VALUES (@p1,@p2,@p3)", database.baglanti());
                        kullaniciEkle.Parameters.AddWithValue("@p1", txtKullanici.Text);
                        kullaniciEkle.Parameters.AddWithValue("@p2", txtSifre.Text);
                        kullaniciEkle.Parameters.AddWithValue("@p3", txtKod.Text);
                        try
                        {
                            kullaniciEkle.ExecuteNonQuery();
                            listele();
                            temizle();
                            database.baglanti().Close();
                            MessageBox.Show("Kullanıcı kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hata ** Kullanici KAYDEDİLEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult cevap = MessageBox.Show("Kullanıcıyı güncellemek istiyor musunuz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        SqlCommand kullaniciGuncelle = new SqlCommand("UPDATE TBLGIRISBILGILERI SET KULLANICIADI=@p1, SIFRE=@p2, GUVENLIKKODU=@p3 WHERE ID=@p4", database.baglanti());
                        kullaniciGuncelle.Parameters.AddWithValue("@p1", txtKullanici.Text);
                        kullaniciGuncelle.Parameters.AddWithValue("@p2", txtSifre.Text);
                        kullaniciGuncelle.Parameters.AddWithValue("@p3", txtKod.Text);
                        kullaniciGuncelle.Parameters.AddWithValue("@p4", txtId.Text);
                        try
                        {
                            kullaniciGuncelle.ExecuteNonQuery();
                            listele();
                            temizle();
                            database.baglanti().Close();
                            MessageBox.Show("Kullanıcı güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hata ** Kullanici GÜNCELLENEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Boş alan bırakmayınız!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
