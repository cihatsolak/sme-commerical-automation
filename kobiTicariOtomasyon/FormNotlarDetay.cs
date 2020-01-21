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
    public partial class FormNotlarDetay : Form
    {
        public FormNotlarDetay()
        {
            InitializeComponent();
        }

        //GLOBAL ALAN
        public string id;
        sqlBaglantisi database = new sqlBaglantisi();

        //Form Load
        private void FormNotlarDetay_Load(object sender, EventArgs e)
        {
            SqlCommand veri = new SqlCommand("SELECT DETAY FROM TBLNOTLAR WHERE ID='" + id + "'", database.baglanti());
            SqlDataReader oku = veri.ExecuteReader();
            if (oku.Read())
            {
                txtDetay.Text = oku[0].ToString();
            }
        }
    }
}
