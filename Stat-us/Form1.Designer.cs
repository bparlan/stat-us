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
            this.btnShowApps = new System.Windows.Forms.Button();
            this.btnShowInstalled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(23, 31);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(130, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Processes";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstApplications
            // 
            this.lstApplications.FormattingEnabled = true;
            this.lstApplications.Location = new System.Drawing.Point(23, 101);
            this.lstApplications.Name = "lstApplications";
            this.lstApplications.Size = new System.Drawing.Size(481, 264);
            this.lstApplications.TabIndex = 1;
            // 
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 392);
            this.Controls.Add(this.btnShowInstalled);
            this.Controls.Add(this.btnShowApps);
            this.Controls.Add(this.lstApplications);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstApplications;
        private System.Windows.Forms.Button btnShowApps;
        private System.Windows.Forms.Button btnShowInstalled;
    }
}

