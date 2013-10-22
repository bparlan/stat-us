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
            this.btnUntrack = new System.Windows.Forms.Button();
            this.lstTracked = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUntrack
            // 
            this.btnUntrack.Location = new System.Drawing.Point(12, 346);
            this.btnUntrack.Name = "btnUntrack";
            this.btnUntrack.Size = new System.Drawing.Size(209, 27);
            this.btnUntrack.TabIndex = 13;
            this.btnUntrack.Text = "Ignore";
            this.btnUntrack.UseVisualStyleBackColor = true;
            this.btnUntrack.Click += new System.EventHandler(this.btnUntrack_Click);
            // 
            // lstTracked
            // 
            this.lstTracked.FormattingEnabled = true;
            this.lstTracked.Location = new System.Drawing.Point(12, 12);
            this.lstTracked.Name = "lstTracked";
            this.lstTracked.Size = new System.Drawing.Size(209, 329);
            this.lstTracked.TabIndex = 12;
            // 
            // frmTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 401);
            this.Controls.Add(this.btnUntrack);
            this.Controls.Add(this.lstTracked);
            this.Name = "frmTracking";
            this.Text = "Tracking Applications";
            this.Load += new System.EventHandler(this.frmTracking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUntrack;
        private System.Windows.Forms.ListBox lstTracked;
    }
}