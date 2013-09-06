using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
           
        }
    }
}
