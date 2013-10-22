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
            this.btnTrack = new System.Windows.Forms.Button();
            this.lstIgnored = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(12, 346);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(209, 27);
            this.btnTrack.TabIndex = 15;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // lstIgnored
            // 
            this.lstIgnored.FormattingEnabled = true;
            this.lstIgnored.Location = new System.Drawing.Point(12, 12);
            this.lstIgnored.Name = "lstIgnored";
            this.lstIgnored.Size = new System.Drawing.Size(209, 329);
            this.lstIgnored.TabIndex = 14;
            // 
            // frmIgnoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 396);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.lstIgnored);
            this.Name = "frmIgnoring";
            this.Text = "Ignoring";
            this.Load += new System.EventHandler(this.frmIgnoring_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.ListBox lstIgnored;
    }
}