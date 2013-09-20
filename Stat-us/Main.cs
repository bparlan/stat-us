using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            this.SizeChanged += new EventHandler(form1_sizeeventhandler);
        }

        //About Button
        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 form_about = new AboutBox1();
            form_about.Show();
        }

        //Program Control Button
        private void button4_Click(object sender, EventArgs e)
        {
            Control form_control = new Control();
            form_control.ShowDialog();
        }


        //Exit Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Size Event Handler
        private void form1_sizeeventhandler(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "I'm Here!";
            notifyIcon1.BalloonTipText = "I'll keep tracking from here without bothering you... Enjoy!";

            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                // handle it
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }


        //Close Button
        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
