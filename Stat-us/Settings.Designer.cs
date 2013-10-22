namespace Stat_us
{
    partial class frmSettings
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
            this.btnTracking = new System.Windows.Forms.Button();
            this.btnIgnoring = new System.Windows.Forms.Button();
            this.btnUnconfirmed = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTracking
            // 
            this.btnTracking.Location = new System.Drawing.Point(12, 12);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(75, 41);
            this.btnTracking.TabIndex = 0;
            this.btnTracking.Text = "Tracking";
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // btnIgnoring
            // 
            this.btnIgnoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIgnoring.Location = new System.Drawing.Point(12, 59);
            this.btnIgnoring.Name = "btnIgnoring";
            this.btnIgnoring.Size = new System.Drawing.Size(75, 41);
            this.btnIgnoring.TabIndex = 1;
            this.btnIgnoring.Text = "Ingnoring";
            this.btnIgnoring.UseVisualStyleBackColor = true;
            this.btnIgnoring.Click += new System.EventHandler(this.btnIgnoring_Click);
            // 
            // btnUnconfirmed
            // 
            this.btnUnconfirmed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnconfirmed.Location = new System.Drawing.Point(12, 106);
            this.btnUnconfirmed.Name = "btnUnconfirmed";
            this.btnUnconfirmed.Size = new System.Drawing.Size(75, 41);
            this.btnUnconfirmed.TabIndex = 2;
            this.btnUnconfirmed.Text = "Unconfirmed";
            this.btnUnconfirmed.UseVisualStyleBackColor = true;
            this.btnUnconfirmed.Click += new System.EventHandler(this.btnUnconfirmed_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.Location = new System.Drawing.Point(12, 153);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 41);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(208, 25);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(109, 17);
            this.chkStartup.TabIndex = 4;
            this.chkStartup.Text = "Launch at startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 44);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(248, 15);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(86, 15);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUnconfirmed);
            this.Controls.Add(this.btnIgnoring);
            this.Controls.Add(this.btnTracking);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTracking;
        private System.Windows.Forms.Button btnIgnoring;
        private System.Windows.Forms.Button btnUnconfirmed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}