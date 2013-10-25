namespace Stat_us
{
    partial class frmTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTracking));
            this.btnUntrack = new System.Windows.Forms.Button();
            this.lstTracked = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUntrack
            // 
            resources.ApplyResources(this.btnUntrack, "btnUntrack");
            this.btnUntrack.Name = "btnUntrack";
            this.btnUntrack.UseVisualStyleBackColor = true;
            this.btnUntrack.Click += new System.EventHandler(this.btnUntrack_Click);
            // 
            // lstTracked
            // 
            resources.ApplyResources(this.lstTracked, "lstTracked");
            this.lstTracked.FormattingEnabled = true;
            this.lstTracked.Name = "lstTracked";
            // 
            // frmTracking
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUntrack);
            this.Controls.Add(this.lstTracked);
            this.Name = "frmTracking";
            this.Load += new System.EventHandler(this.frmTracking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUntrack;
        private System.Windows.Forms.ListBox lstTracked;
    }
}