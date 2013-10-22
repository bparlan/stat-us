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
    public partial class frmUnconfirmed : Form
    {
        public frmUnconfirmed()
        {
            InitializeComponent();
        }

        private void frmUnconfirmed_Load(object sender, EventArgs e)
        {
            fillList();
        }

        private void fillList()
        {
            DataTable dbPrograms = new DataTable();
            dbPrograms = Cprograms.getAllUnconfirmed();
            lstUnconfirmed.DataSource = dbPrograms.AsEnumerable()
                           .Select(r => r.Field<string>("exe"))
                           .ToList();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            String programName = lstUnconfirmed.SelectedItem.ToString();
            Cprograms.hide(programName);
            fillList();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            String programName = lstUnconfirmed.SelectedItem.ToString();
            Cprograms.track(programName);
            fillList();
        }
    }
}
