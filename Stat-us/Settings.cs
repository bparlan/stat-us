using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Stat_us
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnTracking_Click(object sender, EventArgs e)
        {
            frmTracking frm = new frmTracking();
            frm.ShowDialog();
        }

        private void btnIgnoring_Click(object sender, EventArgs e)
        {
            frmIgnoring frm = new frmIgnoring();
            frm.ShowDialog();
        }

        private void btnUnconfirmed_Click(object sender, EventArgs e)
        {
            frmUnconfirmed frm = new frmUnconfirmed();
            frm.ShowDialog();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            setStartup();
        }

           
        private void setStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (chkStartup.Checked)
                rk.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
            else
                rk.DeleteValue(Application.ProductName, false);            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.btnApply_Click(null, null);
            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            
            String value = (String)rk.GetValue(Application.ProductName);
            if (value == Application.ExecutablePath.ToString()) {
                chkStartup.Checked = true;
            }
        }
    }
}
