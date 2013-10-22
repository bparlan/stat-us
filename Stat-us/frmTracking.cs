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
    public partial class frmTracking : Form
    {
        public frmTracking()
        {
            InitializeComponent();
        }

        private void frmTracking_Load(object sender, EventArgs e)
        {
            fillList();
        }

        private void btnUntrack_Click(object sender, EventArgs e)
        {
            String programName = lstTracked.SelectedItem.ToString();
            Cprograms.hide(programName);
            fillList();

        }

        private void fillList() {
            DataTable dbPrograms = new DataTable();
            dbPrograms = Cprograms.getAllTracked();
            lstTracked.DataSource = dbPrograms.AsEnumerable()
                           .Select(r => r.Field<string>("exe"))
                           .ToList();
        }
    }
}
