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
    public partial class FormSifreHatirlatma : Form
    {
        public FormSifreHatirlatma()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        void temizle()
        {
            txtKod.Text = "";
            txtKullanici.Text = "";
        }
        //Form Load
        private void FormSifreHatirlatma_Load(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSifreBul_Click(object sender, EventArgs e)
        {//&& txtKod.Text != ""
            if (txtKullanici.Text != "" )
            {
                SqlCommand kontrol = new SqlCommand("SELECT SIFRE FROM TBLGIRISBILGILERI WHERE KULLANICIADI=@p1 AND GUVENLIKKODU=@p2", database.baglanti());
                kontrol.Parameters.AddWithValue("@p1", txtKullanici.Text);
                kontrol.Parameters.AddWithValue("@p2", txtKod.Text);
                SqlDataReader oku = kontrol.ExecuteReader();
                if (oku.Read())
                {
                    temizle();
                    MessageBox.Show("Şifreniz: " + oku[0].ToString() + " | Bilgileri not ediniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Hatalı bilgi girişi vardır!","Bilgilendirme Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chcGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGoster.Checked==true)
            {
                txtKod.Properties.PasswordChar = '#';
            }
            else
                txtKod.Properties.PasswordChar = '\0';
        }
    }
}
