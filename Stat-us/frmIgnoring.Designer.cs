namespace Stat_us
{
    partial class frmIgnoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIgnoring));
            this.btnTrack = new System.Windows.Forms.Button();
            this.lstIgnored = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTrack
            // 
            resources.ApplyResources(this.btnTrack, "btnTrack");
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // lstIgnored
            // 
            resources.ApplyResources(this.lstIgnored, "lstIgnored");
            this.lstIgnored.FormattingEnabled = true;
            this.lstIgnored.Name = "lstIgnored";
            // 
            // frmIgnoring
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.lstIgnored);
            this.Name = "frmIgnoring";
            this.Load += new System.EventHandler(this.frmIgnoring_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.ListBox lstIgnored;
    }
}