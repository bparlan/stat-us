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
    public partial class frmIgnoring : Form
    {
        public frmIgnoring()
        {
            InitializeComponent();
        }

        private void frmIgnoring_Load(object sender, EventArgs e)
        {
            fillList();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            String programName = lstIgnored.SelectedItem.ToString();
            Cprograms.track(programName);
            fillList();
        }

        private void fillList() {
            DataTable dbPrograms = new DataTable();
            dbPrograms = Cprograms.getAllIgnored();
            lstIgnored.DataSource = dbPrograms.AsEnumerable()
                           .Select(r => r.Field<string>("exe"))
                           .ToList();
        }
    }
}
