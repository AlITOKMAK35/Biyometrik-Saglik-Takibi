using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace process_işleme
{
    internal class asdfg
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CSING2L;Initial Catalog=process;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }

       
    }
}
