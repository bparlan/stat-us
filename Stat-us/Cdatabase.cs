using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;


//sadece bağlantıyı kurmak için kullanılacak
namespace Stat_us
{
    class Cdatabase
    {
        public OleDbConnection connection = new OleDbConnection();
        public OleDbCommand command = new OleDbCommand();

        public void Connect() {
            try
            {
                this.connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stats.MDB";
                this.connection.Open();
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