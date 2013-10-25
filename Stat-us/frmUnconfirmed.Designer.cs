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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnconfirmed));
            this.btnTrack = new System.Windows.Forms.Button();
            this.lstUnconfirmed = new System.Windows.Forms.ListBox();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrack
            // 
            resources.ApplyResources(this.btnTrack, "btnTrack");
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // lstUnconfirmed
            // 
            resources.ApplyResources(this.lstUnconfirmed, "lstUnconfirmed");
            this.lstUnconfirmed.FormattingEnabled = true;
            this.lstUnconfirmed.Name = "lstUnconfirmed";
            // 
            // btnIgnore
            // 
            resources.ApplyResources(this.btnIgnore, "btnIgnore");
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.UseVisualStyleBackColor = true;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // frmUnconfirmed
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.lstUnconfirmed);
            this.Name = "frmUnconfirmed";
            this.Load += new System.EventHandler(this.frmUnconfirmed_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.ListBox lstUnconfirmed;
        private System.Windows.Forms.Button btnIgnore;
    }
}