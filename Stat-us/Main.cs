using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace Stat_us
{
     

    public partial class frmMain : Form
    {
        //timer instance
        private static System.Timers.Timer iTimer;
        private bool forceClose = false;

        public frmMain()
        {
            //10 saniyelik timer, 10 saniye olmak zorunda
            iTimer = new System.Timers.Timer(Properties.Settings.Default.loopTime);
            iTimer.Enabled = true;
            iTimer.Elapsed += new ElapsedEventHandler(timeLoop);
            
            //bütün sessionları kapat
            Csessions.closeAll();

            InitializeComponent();
            this.SizeChanged += new EventHandler(form1_sizeeventhandler);
        
        }

        //About Button
        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 form_about = new AboutBox1();
            form_about.Show();
        }

        //Program Control Button
        private void btnProgramControl_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }





        //Size Event Handler
        private void form1_sizeeventhandler(object sender, EventArgs e)
        {


                notifyIcon1.BalloonTipTitle = "I'm Here!";
                notifyIcon1.BalloonTipText = "I'll keep tracking from here without bothering you... Enjoy!";

                if (this.WindowState == FormWindowState.Minimized)
                {
                    notifyIcon1.Visible = true;
                    if (!Properties.Settings.Default.notificationShowed)
                    {
                        notifyIcon1.ShowBalloonTip(500);
                        Properties.Settings.Default.notificationShowed = true;
                        Properties.Settings.Default.Save();
                    }
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
        private void btnExit_click(object sender, EventArgs e)
        {
            this.forceClose = true;
            this.Close();
        }

        private void programsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.programsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statsDataSet);*/

        }

        private  void timeLoop(object source, ElapsedEventArgs e)
        {
            try
            {
                this.updateActiveSessions();
                this.closeInactiveSessions();
            }
            catch (Exception except) 
            {
 
            }
            

        }



        private void closeInactiveSessions() {
            Cstatus status = new Cstatus();

            List<String> systemPrograms = status.GetProcesses();
            //tüm takip edilenleri bul
            DataTable dbPrograms = Cprograms.getAllTracked();

            foreach (DataRow dbProgram in dbPrograms.Rows)
            {
                //eğer çalışmıyorsa 
                if (!systemPrograms.Contains((String)dbProgram["exe"]))
                {
                    //açık session(ları) ı kapat
                    Csessions.close((int)dbProgram["programid"]);

                    if (!(bool)dbProgram["is_confirmed"]) {
                        iTimer.Enabled = false;
                        DialogResult result = MessageBox.Show("We are tracking this program, should we?", (String)dbProgram["exe"], MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Cprograms.track((String)dbProgram["exe"]);
                        }
                        else if (result == DialogResult.No)
                        {
                            Cprograms.hide((String)dbProgram["exe"]);
                        }
                        iTimer.Enabled = true;
                    }
                }
            }
        }

        private void updateActiveSessions()
        {
            Cstatus status = new Cstatus();

            List<String> systemPrograms = status.GetProcesses();
            DataTable dbPrograms = new DataTable();
            dbPrograms = Cprograms.getAll();


            //sistemdeki tüm programları gez ve bağlı olarak sessionları oluştur veya update et
            foreach (String programExe in systemPrograms)
            {
                //program kayıtlı mı kontrol et
                var rows = dbPrograms.Select("exe = '" + programExe + "'");

                //eğer veri tabanında varsa
                if (rows.Length != 0)
                {
                    //ve eğer takip ediliyorsa
                    if ((bool)rows[0]["is_tracked"])
                    {
                        int programId = (int)rows[0]["programid"];
                        //programa ait açık sessionları bul
                        DataTable sessions = Csessions.getOpen(programId);

                        //eğer session varsa
                        if (sessions.Rows.Count > 0)
                        {
                            //her açık olan her sessionı update et (normalde birden fazla satır olmaması lazım ama yinede kontrol et)
                            foreach (DataRow session in sessions.Rows)
                            {
                                Csessions.update(programId, (Properties.Settings.Default.loopTime / 1000));
                            }
                        }
                        else
                        {
                            //açık session yok 
                            //session oluştur
                            Csessions.create(programId);
                        }
                    }
                } 
                else //veri tabanında kaydı yok ise
                { 
                    //programı kaydet ama sonra kullanıcıya sormak üzere işaretle
                    Cprograms.insert(null, programExe, true, null, 1, false);
                }
            } //end of for system programs
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmApplications frm = new frmApplications();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!forceClose)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
            
        }




    }
}
