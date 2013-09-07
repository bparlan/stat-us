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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string BaglantiMetni = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/stats.mdb";
            OleDbConnection yeniBaglanti = new OleDbConnection(BaglantiMetni);
            OleDbDataAdapter yeniDataAdapter = new OleDbDataAdapter("SELECT * FROM statsdb", BaglantiMetni);
            DataSet yeniDataSet = new DataSet();
            yeniDataAdapter.Fill(yeniDataSet);
            GridView1.DataSource = yeniDataSet;
            GridView1.DataMember = yeniDataSet.Tables[0].ToString();
        }

        private void btnShowProcess_Click(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetProcesses();
            lstApplications.DataSource = programs;
        }


        private void btnShowApps_Click(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetApplications();
            lstApplications.DataSource = programs;

        }

        private void btnShowInstalled_Click(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetInstalled2();
            lstApplications.DataSource = programs;
        }

        private void sqlkayit_Click(object sender, EventArgs e)
        {

            MessageBox.Show(lstApplications.SelectedItem.ToString() + "\n" + "deneme");
        }
    }
}
