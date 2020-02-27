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
                "Data Source=JORDAN-PC\\SQLEXPRESS;AttachDbFilename=C:\\Users\\explo\\source\\repos\\CareTek Capstone\\caretek-step4\\CareBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

