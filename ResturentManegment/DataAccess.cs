using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ResturentManegment
{
    class DataAccess
    {
        public SqlConnection con;

        public DataAccess()
        {
            con = new SqlConnection(@"Data Source=SHAFAYET;Initial Catalog=Resturent;Integrated Security=True");
        }

        public static string type;

    }
}
