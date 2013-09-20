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
    public partial class AddTracker : Form
    {

        public AddTracker()
        {
            InitializeComponent();
        }

        
        string secili_program_exe;
        string secili_program_path;
        int newprogramid;
        string newprogramname;

        private void AddTracker_Load(object sender, EventArgs e)
        {
            Control cForm = new Control();
            cForm.secili_program_exe = this.secili_program_exe;
            cForm.secili_program_path = this.secili_program_path;
            cForm.newprogramid = this.newprogramid;
            cForm.newprogramname = this.newprogramname;

            addtracker_label3.Text = secili_program_exe;

            /*
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stats.MDB";


            OleDbCommand command = new OleDbCommand();
            
            command.CommandText = @"insert into programs ([programid], [name], [exe], [categorid], [path]) VALUES (?,?,?,?,?)";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("programid",  newprogramid);
            command.Parameters.AddWithValue("name", newprogramname);
            command.Parameters.AddWithValue("exe", newprogramname);
            command.Parameters.AddWithValue("categorid", newprogramid);
            command.Parameters.AddWithValue("path", newprogramname);

            command.Connection = connection;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            */

        }

    }
}
