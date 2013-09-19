namespace Stat_us
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button_help = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_programcontrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(13, 56);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(85, 23);
            this.button_help.TabIndex = 1;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(12, 85);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(86, 23);
            this.button_about.TabIndex = 2;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_programcontrol
            // 
            this.button_programcontrol.Location = new System.Drawing.Point(13, 13);
            this.button_programcontrol.Name = "button_programcontrol";
            this.button_programcontrol.Size = new System.Drawing.Size(85, 37);
            this.button_programcontrol.TabIndex = 3;
            this.button_programcontrol.Text = "Program Control";
            this.button_programcontrol.UseVisualStyleBackColor = true;
            this.button_programcontrol.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Time on PC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top 3 Programs:";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 144);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(86, 23);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(12, 115);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(86, 23);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button5_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 179);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_programcontrol);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Stat.us | Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_programcontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button_close;

        
    }
}