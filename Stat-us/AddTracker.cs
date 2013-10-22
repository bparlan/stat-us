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
    public partial class frmAddTracker : Form
    {

        public String programName = "program name";
        public frmAddTracker()
        {
            InitializeComponent();
            lblProgramExe.Text = programName;
        }

        


        private void AddTracker_Load(object sender, EventArgs e)
        {
            lblProgramExe.Text = programName;
            this.categoriesTableAdapter.Fill(this.statsDataSet.categories);


        }

        private void btnSaveProgram_Click(object sender, EventArgs e)
        {
            
            Boolean isTracked = rdTrack.Checked;
            int categoryId = (int)cmbCategory.SelectedValue;
            Cprograms.insert(txtTitle.Text, this.programName, isTracked, "", categoryId, true);
            this.Close();

        }




    }
}
