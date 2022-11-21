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
            this.panel2 = new System.Windows.Forms.Panel();
            this.daglb = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Weekdaylb
            // 
            this.Weekdaylb.AutoSize = true;
            this.Weekdaylb.Font = new System.Drawing.Font("Barlow", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weekdaylb.ForeColor = System.Drawing.Color.White;
            this.Weekdaylb.Location = new System.Drawing.Point(3, 9);
            this.Weekdaylb.Name = "Weekdaylb";
            this.Weekdaylb.Size = new System.Drawing.Size(59, 17);
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
            this.Appointmentpanel.Location = new System.Drawing.Point(0, 51);
            this.Appointmentpanel.Name = "Appointmentpanel";
            this.Appointmentpanel.Size = new System.Drawing.Size(128, 587);
            this.Appointmentpanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.Weekdaylb);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 32);
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
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserControldayschedule";
            this.Size = new System.Drawing.Size(127, 637);
            this.Load += new System.EventHandler(this.UserControldayschedule_Load);
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
    }
}
