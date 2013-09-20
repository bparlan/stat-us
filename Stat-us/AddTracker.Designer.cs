namespace Stat_us
{
    partial class AddTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTracker));
            this.addtracker_label1 = new System.Windows.Forms.Label();
            this.addtracker_label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addtracker_label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button_addtrackersave = new System.Windows.Forms.Button();
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
            // addtracker_label3
            // 
            this.addtracker_label3.AutoSize = true;
            this.addtracker_label3.Location = new System.Drawing.Point(93, 13);
            this.addtracker_label3.Name = "addtracker_label3";
            this.addtracker_label3.Size = new System.Drawing.Size(73, 13);
            this.addtracker_label3.TabIndex = 0;
            this.addtracker_label3.Text = "Program Exe: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // addtracker_label2
            // 
            this.addtracker_label2.AutoSize = true;
            this.addtracker_label2.Location = new System.Drawing.Point(12, 38);
            this.addtracker_label2.Name = "addtracker_label2";
            this.addtracker_label2.Size = new System.Drawing.Size(52, 13);
            this.addtracker_label2.TabIndex = 0;
            this.addtracker_label2.Text = "Category:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Track It";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(154, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hide It";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button_addtrackersave
            // 
            this.button_addtrackersave.Location = new System.Drawing.Point(13, 92);
            this.button_addtrackersave.Name = "button_addtrackersave";
            this.button_addtrackersave.Size = new System.Drawing.Size(228, 23);
            this.button_addtrackersave.TabIndex = 3;
            this.button_addtrackersave.Text = "Save";
            this.button_addtrackersave.UseVisualStyleBackColor = true;
            // 
            // AddTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 128);
            this.Controls.Add(this.button_addtrackersave);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addtracker_label3);
            this.Controls.Add(this.addtracker_label2);
            this.Controls.Add(this.addtracker_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTracker";
            this.Text = "Stat.us | Add Program";
            this.Load += new System.EventHandler(this.AddTracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addtracker_label1;
        private System.Windows.Forms.Label addtracker_label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label addtracker_label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button_addtrackersave;
    }
}