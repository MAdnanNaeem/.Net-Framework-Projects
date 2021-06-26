using Banking_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System.DL
{
   public class ClientDL
    {

        DBConnections dbConnections;


       public ClientDL()
        {
            dbConnections = new DBConnections();
        }

    
        public DataTable GetClientDataDL(ClientDTO dTO)
        {
           

            try
            {
                DataTable dataTable = new DataTable();
                dbConnections.sqlconnection.Open();

                string queryread = "SELECT Client.AccountNo, Client.ClientName, ClientRecord.Debit, ClientRecord.Credit, ClientRecord.TotalAmount  FROM Client, ClientRecord Where Client.AccountNo = @AccountNo AND ClientRecord.AccountNo = @AccountNo ";
                SqlCommand command = new SqlCommand(queryread, dbConnections.sqlconnection);
                command.Parameters.AddWithValue("@AccountNo", dTO.AccountNo);
                SqlDataReader dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
                return dataTable;


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                
            }

        }
    
    
    
         public ClientDTO LoginDL(ClientDTO clientDTO)
        {
            ClientDTO dTO = new ClientDTO();

            try
            {     
                  
                dbConnections.sqlconnection.Open();

                string queryString = "SELECT * FROM Client WHERE AccountNo = @AccountNo AND ClientPassword = @ClientPassword ";
                SqlCommand sqlCommand = new SqlCommand(queryString, dbConnections.sqlconnection);
                sqlCommand.Parameters.AddWithValue("@AccountNo",clientDTO.AccountNo);
                sqlCommand.Parameters.AddWithValue("@ClientPassword",clientDTO.ClientPassword);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    
                    dTO.AccountNo = sqlDataReader["AccountNo"].ToString();
                    dTO.ClientPassword = sqlDataReader["ClientPassword"].ToString();
                    return dTO;    
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

                dbConnections.sqlconnection.Close();
            }

            return null;
        }
    
    }



}
