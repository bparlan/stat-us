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


        public string secili_program_exe;
        public string secili_program_path;
        public int newprogramid;
        public string newprogramname;

        public void Control_Load_1(object sender, EventArgs e)
        {
            Cstatus stat = new Cstatus();
            List<String> programs = stat.GetProcesses();
            lstApplications.DataSource = programs;

            Cprograms cprograms = new Cprograms();

            dataGridView1.DataSource = cprograms.getAll();
        }


        // TRACK IT BUTTON CLICK

        public void button_trackit_Click(object sender, EventArgs e)
        {
            //Cstatus stat = new Cstatus();

            secili_program_exe = lstApplications.SelectedItem.ToString();

            newprogramid = Convert.ToInt32(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value) + 1;
            newprogramname = lstApplications.SelectedValue.ToString();


            List<String> ProcessPath = GetProcessPath();
            secili_program_path = ProcessPath.ToString();

            AddTracker form_addtracker = new AddTracker();
            form_addtracker.ShowDialog();

        }



        public List<String> GetProcessPath()
        {
            //Eger ProgramDB'de benzeri varsa burada listelenmeyecek.
            //Eger BlackListDB'de benzeri varsa burada listelenmeyecek.
            //Eger Çift farsa temizlenecek.

            List<String> programNames = new List<string>();
            ManagementClass MgmtClass = new ManagementClass("Win32_Process");

            foreach (ManagementObject mo in MgmtClass.GetInstances())
            {
                string temp = Convert.ToString(mo["Name"]);

                if (secili_program_exe == temp)
                {
                    programNames.Add(mo["ExecutablePath"].ToString());
                }

            }

            return programNames;

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
