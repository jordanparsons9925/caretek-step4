using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Step4Prototype
{
    class ShiftDB
    {
        public static PCA GetShift()
        {
            SqlConnection connection = CareBaseDB.GetConnection();
            string selectStatement
                = "SELECT  "
                + "FROM Shifts "
                + "WHERE ";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@", );

            try
            {
                connection.Open();
                SqlDataReader PCAReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (pcaReader.Read())
                {
                    Shift shift = new Shift();
                    //Shift stuff
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
