using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kobiTicariOtomasyon
{
    class sqlBaglantisi
    {
        //SQL BAGLANTISI
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=HPPROBOOK;Initial Catalog=dbTicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan; 
        }
    }
}
