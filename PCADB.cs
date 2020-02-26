using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Step4Prototype
{
    class PCADB
    {
        public static PCA GetPCA(string username)
        {
            SqlConnection connection = CareBaseDB.GetConnection();
            string selectStatement
                = "SELECT Username, FirstName, FirstName, Address, City, State, PostalCode, PositionID "
                + "FROM Employees "
                + "WHERE username = @username";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();
                SqlDataReader PCAReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (pcaReader.Read())
                {
                    PCA pca = new PCA();
                    pca.username = (string)pcaReader["username"];
                    pca.FirstName = pcaReader["FirstName"].ToString();
                    pca.LastName = pcaReader["LastName"].ToString();
                    pca.Address = pcaReader["Address"].ToString();
                    pca.City = pcaReader["City"].ToString();
                    pca.PostalCode = pcaReader["PostalCode"].ToString();
                    pca.PositionID = pcaReader["PositionID"].ToString();
                    return pca;
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
