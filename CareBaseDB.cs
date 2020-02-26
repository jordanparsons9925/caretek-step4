using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Step4Prototype
{
    class CareBaseDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=DESKTOP-EIONKSD\SQLEXPRESS;Initial Catalog=CareBase;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

