using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Management;
using System.Diagnostics;
using Microsoft.Win32;
using System.Windows.Forms;


namespace Stat_us
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }




        public void Control_Load_1(object sender, EventArgs e)
        {
            
            DataTable dbPrograms = new DataTable();
            dbPrograms = Cprograms.getAllUnconfirmed();
            lstApplications.DataSource = dbPrograms.AsEnumerable()
                           .Select(r => r.Field<string>("exe"))
                           .ToList();
        }


        // TRACK IT BUTTON CLICK

        public void button_trackit_Click(object sender, EventArgs e)
        {
            //Cstatus stat = new Cstatus();

            String programName = lstApplications.SelectedItem.ToString();

            frmAddTracker frm = new frmAddTracker();
            frm.programName = programName;
            frm.ShowDialog();
            


            

        }

    }
}
