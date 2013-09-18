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
        public Control()
        {
            InitializeComponent();
        }

        private void Control_Load_1(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetApplications();
            lstApplications.DataSource = programs;

            // TEST CONNECTION

        }

        public void DataRead()
        {
            try
            {

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
