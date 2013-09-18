using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;


//sadece bağlantıyı kurmak için kullanılacak
namespace Stat_us
{
    class Cdatabase
    {
        public OleDbConnection connection = null;
        public OleDbCommand command = null;

        public void Connect() {
            try
            {
                this.connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stats.mdb;Persist Security Info=False;";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
                return;
            }
        }
        public void Disconnect()
        {
            connection.Close();
        }
    }
}
