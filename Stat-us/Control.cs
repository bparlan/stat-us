using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Stat_us
{
    public partial class Control : Form
    {
        private OleDbConnection bookConn;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        private String connParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stats.MDB";
 

        public Control()
        {
            bookConn = new OleDbConnection(connParam);
            InitializeComponent();
        }

        public void Control_Load_1(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetApplications();
            lstApplications.DataSource = programs;

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter("select * from categories", connParam);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            DataTable dataTable = new DataTable();

            DataSet ds = new DataSet();

            dAdapter.Fill(dataTable);

            //MessageBox.Show("" + dataTable.Rows.Count);
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1]);
            }
            
        }
          

        /*
         * Load Programs To List Stuff

        private void btnShowApps_Click(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetApplications();
            lstApplications.DataSource = programs;
        }
        private void btnShowProcess_Click(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetProcesses();
            lstApplications.DataSource = programs;
        }
        private void btnShowInstalled_Click(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetInstalled2();
            lstApplications.DataSource = programs;
        }
         * 
         * */
    }
}
