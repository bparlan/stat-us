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
    {/*
        public static void GetDB()
        {

            // Set Access connection and select strings.
            // The path to BugTypes.MDB must be changed if you build 
            // the sample from the command line:
#if USINGPROJECTSYSTEM
        string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\stat-us.git\\Stat-us\\stats.MDB";
#else
            string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stats.MDB";
#endif
            string strAccessSelect = "SELECT * FROM Categories";

            // Create the dataset and add the Categories table to it:
            DataSet myDataSet = new DataSet();
            OleDbConnection myAccessConn = null;

            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
                return;
            }

            try
            {
                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                myAccessConn.Open();
                myDataAdapter.Fill(myDataSet, "Categories");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return;
            }
            finally
            {
                myAccessConn.Close();
            }

            


            
            // A dataset can contain multiple tables, so let's get them
            // all into an array:
            DataTableCollection dta = myDataSet.Tables;
            foreach (DataTable dt in dta)
            {
                System.Diagnostics.Debug.WriteLine("Found data table {0}", dt.TableName);
            }

            

            // The next two lines show two different ways you can get the
            // count of tables in a dataset:
            System.Diagnostics.Debug.WriteLine("{0} tables in data set", myDataSet.Tables.Count);
            System.Diagnostics.Debug.WriteLine("{0} tables in data set", dta.Count);
            // The next several lines show how to get information on
            // a specific table by name from the dataset:
            System.Diagnostics.Debug.WriteLine("{0} rows in Categories table", myDataSet.Tables["Categories"].Rows.Count);
            // The column info is automatically fetched from the database,
            // so we can read it here:
            System.Diagnostics.Debug.WriteLine("{0} columns in Categories table", myDataSet.Tables["Categories"].Columns.Count);
            DataColumnCollection drc = myDataSet.Tables["Categories"].Columns;
            int i = 0;
            foreach (DataColumn dc in drc)
            {
                // Print the column subscript, then the column's name
                // and its data type:
                System.Diagnostics.Debug.WriteLine("Column name[{0}] is {1}, of type {2}", i++, dc.ColumnName, dc.DataType);
            }
            DataRowCollection dra = myDataSet.Tables["Categories"].Rows;
            foreach (DataRow dr in dra)
            {
                // Print the CategoryID as a subscript, then the CategoryName:
                System.Diagnostics.Debug.WriteLine("CategoryName[{0}] is {1}", dr[0], dr[1]);
            }
        }


        
         * CENGIZ DB PART
         * 
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
        }*/
         
    }
}