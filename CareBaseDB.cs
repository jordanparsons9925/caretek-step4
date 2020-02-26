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
                "Data Source=./SQLEXPRESS;AttachDbFilename=C:/Users/haing/Documents/CareTek/caretek-step4/CareBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

