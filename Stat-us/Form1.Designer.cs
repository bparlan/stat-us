namespace Stat_us
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.lstApplications = new System.Windows.Forms.ListBox();
<<<<<<< HEAD
            this.lstApplications2 = new System.Windows.Forms.ListBox();
=======
            this.btnShowApps = new System.Windows.Forms.Button();
            this.btnShowInstalled = new System.Windows.Forms.Button();
>>>>>>> cd62b6f4f10155e96de8c29f21889f18c83f632a
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(23, 31);
            this.btnShow.Name = "btnShow";
<<<<<<< HEAD
            this.btnShow.Size = new System.Drawing.Size(111, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Applications";
=======
            this.btnShow.Size = new System.Drawing.Size(130, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Processes";
>>>>>>> cd62b6f4f10155e96de8c29f21889f18c83f632a
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstApplications
            // 
            this.lstApplications.FormattingEnabled = true;
            this.lstApplications.Location = new System.Drawing.Point(23, 101);
            this.lstApplications.Name = "lstApplications";
            this.lstApplications.Size = new System.Drawing.Size(256, 264);
            this.lstApplications.TabIndex = 1;
            // 
<<<<<<< HEAD
            // lstApplications2
            // 
            this.lstApplications2.FormattingEnabled = true;
            this.lstApplications2.Location = new System.Drawing.Point(285, 101);
            this.lstApplications2.Name = "lstApplications2";
            this.lstApplications2.Size = new System.Drawing.Size(219, 264);
            this.lstApplications2.TabIndex = 2;
            this.lstApplications2.UseTabStops = false;
=======
            // btnShowApps
            // 
            this.btnShowApps.Location = new System.Drawing.Point(189, 31);
            this.btnShowApps.Name = "btnShowApps";
            this.btnShowApps.Size = new System.Drawing.Size(130, 23);
            this.btnShowApps.TabIndex = 2;
            this.btnShowApps.Text = "Show applications";
            this.btnShowApps.UseVisualStyleBackColor = true;
            this.btnShowApps.Click += new System.EventHandler(this.btnShowApps_Click);
            // 
            // btnShowInstalled
            // 
            this.btnShowInstalled.Location = new System.Drawing.Point(357, 31);
            this.btnShowInstalled.Name = "btnShowInstalled";
            this.btnShowInstalled.Size = new System.Drawing.Size(130, 23);
            this.btnShowInstalled.TabIndex = 3;
            this.btnShowInstalled.Text = "Show  installed";
            this.btnShowInstalled.UseVisualStyleBackColor = true;
            this.btnShowInstalled.Click += new System.EventHandler(this.btnShowInstalled_Click);
>>>>>>> cd62b6f4f10155e96de8c29f21889f18c83f632a
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 392);
<<<<<<< HEAD
            this.Controls.Add(this.lstApplications2);
=======
            this.Controls.Add(this.btnShowInstalled);
            this.Controls.Add(this.btnShowApps);
>>>>>>> cd62b6f4f10155e96de8c29f21889f18c83f632a
            this.Controls.Add(this.lstApplications);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "stat.us";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstApplications;
<<<<<<< HEAD
        private System.Windows.Forms.ListBox lstApplications2;
=======
        private System.Windows.Forms.Button btnShowApps;
        private System.Windows.Forms.Button btnShowInstalled;
>>>>>>> cd62b6f4f10155e96de8c29f21889f18c83f632a
    }
}

