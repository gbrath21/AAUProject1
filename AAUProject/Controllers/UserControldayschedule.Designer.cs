namespace AAUProject.Controllers
{
    partial class UserControldayschedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Weekdaylb = new System.Windows.Forms.Label();
            this.Datelb = new System.Windows.Forms.Label();
            this.Appointmentpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hwpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.daglb = new System.Windows.Forms.Label();
            this.Appointmentpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Weekdaylb
            // 
            this.Weekdaylb.AutoSize = true;
            this.Weekdaylb.Location = new System.Drawing.Point(3, 9);
            this.Weekdaylb.Name = "Weekdaylb";
            this.Weekdaylb.Size = new System.Drawing.Size(53, 13);
            this.Weekdaylb.TabIndex = 0;
            this.Weekdaylb.Text = "Weekday";
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Location = new System.Drawing.Point(3, 35);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(0, 13);
            this.Datelb.TabIndex = 1;
            // 
            // Appointmentpanel
            // 
            this.Appointmentpanel.Controls.Add(this.hwpanel);
            this.Appointmentpanel.Location = new System.Drawing.Point(0, 51);
            this.Appointmentpanel.Name = "Appointmentpanel";
            this.Appointmentpanel.Size = new System.Drawing.Size(118, 587);
            this.Appointmentpanel.TabIndex = 2;
            // 
            // hwpanel
            // 
            this.hwpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.hwpanel.Location = new System.Drawing.Point(2, 2);
            this.hwpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hwpanel.Name = "hwpanel";
            this.hwpanel.Size = new System.Drawing.Size(100, 583);
            this.hwpanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.Weekdaylb);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 32);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // daglb
            // 
            this.daglb.AutoSize = true;
            this.daglb.Location = new System.Drawing.Point(62, 35);
            this.daglb.Name = "daglb";
            this.daglb.Size = new System.Drawing.Size(0, 13);
            this.daglb.TabIndex = 4;
            // 
            // UserControldayschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.daglb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Appointmentpanel);
            this.Controls.Add(this.Datelb);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "UserControldayschedule";
            this.Size = new System.Drawing.Size(120, 637);
            this.Load += new System.EventHandler(this.UserControldayschedule_Load);
            this.Appointmentpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Weekdaylb;
        private System.Windows.Forms.Label Datelb;
        private System.Windows.Forms.FlowLayoutPanel Appointmentpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label daglb;
        private System.Windows.Forms.FlowLayoutPanel hwpanel;
    }
}
