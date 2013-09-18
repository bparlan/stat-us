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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 form_about = new AboutBox1();
            form_about.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Control form_control = new Control();
            form_control.ShowDialog();


        }
    }
}
