using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Step4Prototype
{
    class ClientProxyDB
    {
        public static ClientProxy getClientProxy(string username)
        {
            SqlConnection connection = CareBaseDB.GetConnection();
            string selectStatement
                = "SELECT Username, FirstName, LastName, Address, City, PostalCode, HomePhone, CellPhone, SIN, DoB, RegionID, Physician, Payment, Status, ResidenceID, ProxyID "
                + "FROM Client "
                + "WHERE Username = @username";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@username", username);
            try
            {
                connection.Open();
                SqlDataReader clientReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (clientReader.Read())
                {
                    ClientProxy client = new ClientProxy();
                    client.physician = (string)clientReader["Physician"];
                    client.residenceType = (string)clientReader["ResidenceID"];
                    client.payment = (string)clientReader["Payment"];
                    client.proxyFirstName = (string)clientReader["FirstName"];
                    client.proxyLastName = (string)clientReader["LastName"];
                    client.proxyAddress = (string)clientReader["Address"];
                    client.proxyCity = (string)clientReader["City"];
                    client.proxyHomePhone = (string)clientReader["HomePhone"];
                    client.proxyCell = (string)clientReader["CellPhone"];
                    client.status = (string)clientReader["Status"];
                    return client;
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

        public static List<ClientProxy> getClientProxies()
        {
            List<ClientProxy> allClient = new List<ClientProxy>();
            SqlConnection connection = CareBaseDB.GetConnection();
            string selectStatement
                = "SELECT Username, FirstName, LastName, Address, City, PostalCode, HomePhone, CellPhone, SIN, DoB, RegionID, Physician, Payment, Status, ResidenceID, ProxyID "
                + "FROM Client";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader clientReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleResult);
                while (clientReader.Read())
                {
                    ClientProxy client = new ClientProxy();
                    client.userName = (string)clientReader["username"];
                    client.firstName = clientReader["FirstName"].ToString();
                    client.lastName = clientReader["LastName"].ToString();
                    client.Address = clientReader["Address"].ToString();
                    client.City = clientReader["City"].ToString();
                    client.postalCode = clientReader["PostalCode"].ToString();
                    client.physician = (string)clientReader["Physician"];
                    client.residenceType = clientReader["ResidenceID"].ToString();
                    client.payment = (string)clientReader["Payment"];
                    client.proxyFirstName = (string)clientReader["FirstName"];
                    client.proxyLastName = (string)clientReader["LastName"];
                    client.proxyAddress = (string)clientReader["Address"];
                    client.proxyCity = (string)clientReader["City"];
                    client.proxyHomePhone = (string)clientReader["HomePhone"];
                    client.proxyCell = (string)clientReader["CellPhone"];
                    client.status = (string)clientReader["Status"];
                    allClient.Add(client);
                }

                return allClient;
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
