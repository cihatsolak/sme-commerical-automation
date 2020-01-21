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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();
        FormAnasayfa anaForm = new FormAnasayfa();

        //FORM LOAD
        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand veri = new SqlCommand("SELECT * FROM TBLGIRISBILGILERI WHERE KULLANICIADI=@p1 AND SIFRE=@p2", database.baglanti());
            veri.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            veri.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = veri.ExecuteReader();
            if (oku.Read())
            {
                anaForm.KullAdi = txtKullaniciAdi.Text;
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgiler yanlış!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSifreHatirlatma formHatirlat = new FormSifreHatirlatma();
            formHatirlat.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
