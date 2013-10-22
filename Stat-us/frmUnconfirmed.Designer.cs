namespace Stat_us
{
    partial class frmUnconfirmed
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
            this.lstUnconfirmed = new System.Windows.Forms.ListBox();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(12, 346);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(209, 27);
            this.btnTrack.TabIndex = 17;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // lstUnconfirmed
            // 
            this.lstUnconfirmed.FormattingEnabled = true;
            this.lstUnconfirmed.Location = new System.Drawing.Point(12, 12);
            this.lstUnconfirmed.Name = "lstUnconfirmed";
            this.lstUnconfirmed.Size = new System.Drawing.Size(209, 329);
            this.lstUnconfirmed.TabIndex = 16;
            // 
            // btnIgnore
            // 
            this.btnIgnore.Location = new System.Drawing.Point(12, 379);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(209, 27);
            this.btnIgnore.TabIndex = 18;
            this.btnIgnore.Text = "Ignore";
            this.btnIgnore.UseVisualStyleBackColor = true;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // frmUnconfirmed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 428);
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.lstUnconfirmed);
            this.Name = "frmUnconfirmed";
            this.Text = "Unconfirmed";
            this.Load += new System.EventHandler(this.frmUnconfirmed_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.ListBox lstUnconfirmed;
        private System.Windows.Forms.Button btnIgnore;
    }
}