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
    public partial class frmApplications : Form
    {
        public frmApplications()
        {
            InitializeComponent();
        }

        private void frmApplications_Load(object sender, EventArgs e)
        {
            DataTable dbCategories = new DataTable();
            dbCategories = Ccategories.getAll();
            cmbCategory.DataSource = dbCategories;
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "categoryid";

            fillList();
            lstTracked_Click(null, null);
        }

        private void fillList()
        {
            DataTable dbPrograms = new DataTable();
            dbPrograms = Cprograms.getAllTracked();
            
            

            lstTracked.DataSource = dbPrograms;
            lstTracked.DisplayMember = "exe";
            lstTracked.ValueMember = "programid";
            
            
        }

        private void lstTracked_Click(object sender, EventArgs e)
        {
            lblProgramExe.Text = lstTracked.Text;
            DataRowView program = (DataRowView)lstTracked.SelectedItem;

            Double dTime = Csessions.getTotalTime((int)program["programid"]);
            int started = Csessions.getTotalStart((int)program["programid"]);
            TimeSpan time = TimeSpan.FromSeconds(dTime);
            
                lblTotalTime.Text = time.Days.ToString() + " " + Strings.Day;
                lblTotalTime.Text += " " + time.Hours.ToString() + " " + Strings.Hour;
                lblTotalTime.Text += " " + time.Minutes.ToString() + " " + Strings.Minute;
                lblTotalTime.Text += " " + time.Seconds.ToString() + " " + Strings.Second;
                lblStarted.Text = started.ToString();
            
            cmbCategory.SelectedValue = (int)program["categoryid"];
            txtTitle.Text = program["name"].ToString().Trim();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Csessions.delete((int)lstTracked.SelectedValue);
            lstTracked_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRowView program = (DataRowView)lstTracked.SelectedItem;
            Cprograms.update((int)program["programid"], txtTitle.Text.Trim(), (int)cmbCategory.SelectedValue);
            program["name"] = txtTitle.Text.Trim();
            program["categoryid"] = (int)cmbCategory.SelectedValue;
            lstTracked.SelectedItem = program;
        }



        
    }
}
