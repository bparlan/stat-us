using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Stat_us
{
    class Ccategories
    {
        public Cdatabase db = new Cdatabase();
       
        public DataTable getAll()
        {
            
            DataTable dataTable = new DataTable();

            OleDbCommand command = new OleDbCommand("select * from categories", db.connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);

            this.db.Connect();
            dataAdapter.Fill(dataTable);
            this.db.Disconnect();
            return dataTable;
        }

    }
}
