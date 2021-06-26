using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System.DL
{
   public class DBConnections
    {
        private SqlConnection sqlConnection;
        public DBConnections()
        {
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string Connectionstring = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"BankDB.mdf ;  Integrated Security=True";
            sqlConnection = new SqlConnection(Connectionstring);
        }

        public SqlConnection sqlconnection { get => sqlConnection; }
    }
}

