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
        public static Shift GetShift(string username)
        {
            SqlConnection connection = CareBaseDB.GetConnection();
            string selectStatement
                = "SELECT PCAUsername, StartTime, ClientUsername, ServiceID, ServiceDetail "
                + "FROM Shifts "
                + "WHERE PCAUsername = @username";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();
                SqlDataReader shiftReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (shiftReader.Read())
                {
                    Shift shift = new Shift();
                    shift.clientProxyUsername = (string)shiftReader["ClientUsername"];
                    shift.pcaUsername = (string)shiftReader["PCAUsername"];
                    shift.startTime = (DateTime)shiftReader["StartTime"];
                    shift.service = (string)shiftReader["ServiceID"];
                    shift.serviceDetail = (string)shiftReader["ServiceDetail"];
                    return shift;
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
