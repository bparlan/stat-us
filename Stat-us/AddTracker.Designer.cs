namespace Stat_us
{
    partial class frmAddTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTracker));
            this.addtracker_label1 = new System.Windows.Forms.Label();
            this.lblProgramExe = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statsDataSet = new Stat_us.statsDataSet();
            this.addtracker_label2 = new System.Windows.Forms.Label();
            this.rdTrack = new System.Windows.Forms.RadioButton();
            this.rdHide = new System.Windows.Forms.RadioButton();
            this.btnSaveProgram = new System.Windows.Forms.Button();
            this.categoriesTableAdapter = new Stat_us.statsDataSetTableAdapters.categoriesTableAdapter();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.programsTableAdapter = new Stat_us.statsDataSetTableAdapters.programsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addtracker_label1
            // 
            this.addtracker_label1.AutoSize = true;
            this.addtracker_label1.Location = new System.Drawing.Point(13, 13);
            this.addtracker_label1.Name = "addtracker_label1";
            this.addtracker_label1.Size = new System.Drawing.Size(73, 13);
            this.addtracker_label1.TabIndex = 0;
            this.addtracker_label1.Text = "Program Exe: ";
            // 
            // lblProgramExe
            // 
            this.lblProgramExe.AutoSize = true;
            this.lblProgramExe.Location = new System.Drawing.Point(93, 13);
            this.lblProgramExe.Name = "lblProgramExe";
            this.lblProgramExe.Size = new System.Drawing.Size(0, 13);
            this.lblProgramExe.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = this.categoriesBindingSource;
            this.cmbCategory.DisplayMember = "name";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(95, 35);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(146, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.ValueMember = "categoryid";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.statsDataSet;
            // 
            // statsDataSet
            // 
            this.statsDataSet.DataSetName = "statsDataSet";
            this.statsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addtracker_label2
            // 
            this.addtracker_label2.AutoSize = true;
            this.addtracker_label2.Location = new System.Drawing.Point(34, 38);
            this.addtracker_label2.Name = "addtracker_label2";
            this.addtracker_label2.Size = new System.Drawing.Size(52, 13);
            this.addtracker_label2.TabIndex = 0;
            this.addtracker_label2.Text = "Category:";
            // 
            // rdTrack
            // 
            this.rdTrack.AutoSize = true;
            this.rdTrack.Checked = true;
            this.rdTrack.Location = new System.Drawing.Point(95, 65);
            this.rdTrack.Name = "rdTrack";
            this.rdTrack.Size = new System.Drawing.Size(62, 17);
            this.rdTrack.TabIndex = 2;
            this.rdTrack.TabStop = true;
            this.rdTrack.Text = "Track It";
            this.rdTrack.UseVisualStyleBackColor = true;
            // 
            // rdHide
            // 
            this.rdHide.AutoSize = true;
            this.rdHide.Location = new System.Drawing.Point(183, 65);
            this.rdHide.Name = "rdHide";
            this.rdHide.Size = new System.Drawing.Size(56, 17);
            this.rdHide.TabIndex = 2;
            this.rdHide.Text = "Hide It";
            this.rdHide.UseVisualStyleBackColor = true;
            // 
            // btnSaveProgram
            // 
            this.btnSaveProgram.Location = new System.Drawing.Point(12, 134);
            this.btnSaveProgram.Name = "btnSaveProgram";
            this.btnSaveProgram.Size = new System.Drawing.Size(228, 23);
            this.btnSaveProgram.TabIndex = 3;
            this.btnSaveProgram.Text = "Save";
            this.btnSaveProgram.UseVisualStyleBackColor = true;
            this.btnSaveProgram.Click += new System.EventHandler(this.btnSaveProgram_Click);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(95, 104);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(144, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title:";
            // 
            // programsTableAdapter
            // 
            this.programsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSaveProgram);
            this.Controls.Add(this.rdHide);
            this.Controls.Add(this.rdTrack);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblProgramExe);
            this.Controls.Add(this.addtracker_label2);
            this.Controls.Add(this.addtracker_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddTracker";
            this.Text = "Stat.us | Add Program";
            this.Load += new System.EventHandler(this.AddTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addtracker_label1;
        private System.Windows.Forms.Label lblProgramExe;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label addtracker_label2;
        private System.Windows.Forms.RadioButton rdTrack;
        private System.Windows.Forms.RadioButton rdHide;
        private System.Windows.Forms.Button btnSaveProgram;
        private statsDataSet statsDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private statsDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private statsDataSetTableAdapters.programsTableAdapter programsTableAdapter;
    }
}