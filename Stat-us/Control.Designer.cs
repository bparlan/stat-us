namespace Stat_us
{
    partial class Control
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.lstApplications = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_trackit = new System.Windows.Forms.Button();
            this.statsDataSet = new Stat_us.statsDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new Stat_us.statsDataSetTableAdapters.categoriesTableAdapter();
            this.lstTracked = new System.Windows.Forms.ListBox();
            this.lstUntracked = new System.Windows.Forms.ListBox();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnUntrack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstApplications
            // 
            this.lstApplications.FormattingEnabled = true;
            this.lstApplications.Location = new System.Drawing.Point(15, 25);
            this.lstApplications.Name = "lstApplications";
            this.lstApplications.Size = new System.Drawing.Size(209, 264);
            this.lstApplications.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unconfirmed Program List";
            // 
            // button_trackit
            // 
            this.button_trackit.Location = new System.Drawing.Point(15, 295);
            this.button_trackit.Name = "button_trackit";
            this.button_trackit.Size = new System.Drawing.Size(209, 23);
            this.button_trackit.TabIndex = 7;
            this.button_trackit.Text = "Track It";
            this.button_trackit.UseVisualStyleBackColor = true;
            this.button_trackit.Click += new System.EventHandler(this.button_trackit_Click);
            // 
            // statsDataSet
            // 
            this.statsDataSet.DataSetName = "statsDataSet";
            this.statsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.statsDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // lstTracked
            // 
            this.lstTracked.FormattingEnabled = true;
            this.lstTracked.Location = new System.Drawing.Point(444, 25);
            this.lstTracked.Name = "lstTracked";
            this.lstTracked.Size = new System.Drawing.Size(209, 264);
            this.lstTracked.TabIndex = 8;
            // 
            // lstUntracked
            // 
            this.lstUntracked.FormattingEnabled = true;
            this.lstUntracked.Location = new System.Drawing.Point(230, 25);
            this.lstUntracked.Name = "lstUntracked";
            this.lstUntracked.Size = new System.Drawing.Size(209, 264);
            this.lstUntracked.TabIndex = 9;
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(230, 295);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(209, 23);
            this.btnTrack.TabIndex = 10;
            this.btnTrack.Text = "Track It";
            this.btnTrack.UseVisualStyleBackColor = true;
            // 
            // btnUntrack
            // 
            this.btnUntrack.Location = new System.Drawing.Point(445, 295);
            this.btnUntrack.Name = "btnUntrack";
            this.btnUntrack.Size = new System.Drawing.Size(209, 23);
            this.btnUntrack.TabIndex = 11;
            this.btnUntrack.Text = "Ignore";
            this.btnUntrack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ignore";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUntrack);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.lstUntracked);
            this.Controls.Add(this.lstTracked);
            this.Controls.Add(this.button_trackit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstApplications);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Control";
            this.Text = "Stat.us | Control Center";
            this.Load += new System.EventHandler(this.Control_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.statsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_trackit;
        private statsDataSet statsDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private statsDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.ListBox lstTracked;
        private System.Windows.Forms.ListBox lstUntracked;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnUntrack;
        private System.Windows.Forms.Button button1;

    }
}

