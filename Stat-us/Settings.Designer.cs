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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnTracking = new System.Windows.Forms.Button();
            this.btnIgnoring = new System.Windows.Forms.Button();
            this.btnUnconfirmed = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTracking
            // 
            resources.ApplyResources(this.btnTracking, "btnTracking");
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // btnIgnoring
            // 
            resources.ApplyResources(this.btnIgnoring, "btnIgnoring");
            this.btnIgnoring.Name = "btnIgnoring";
            this.btnIgnoring.UseVisualStyleBackColor = true;
            this.btnIgnoring.Click += new System.EventHandler(this.btnIgnoring_Click);
            // 
            // btnUnconfirmed
            // 
            resources.ApplyResources(this.btnUnconfirmed, "btnUnconfirmed");
            this.btnUnconfirmed.Name = "btnUnconfirmed";
            this.btnUnconfirmed.UseVisualStyleBackColor = true;
            this.btnUnconfirmed.Click += new System.EventHandler(this.btnUnconfirmed_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // chkStartup
            // 
            resources.ApplyResources(this.chkStartup, "chkStartup");
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUnconfirmed);
            this.Controls.Add(this.btnIgnoring);
            this.Controls.Add(this.btnTracking);
            this.Name = "frmSettings";
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