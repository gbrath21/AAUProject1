namespace AAUProject.Forms.Welcompage.WelcompageStundet
{
    partial class UserControlDays
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbdays = new System.Windows.Forms.Label();
            this.dispanel = new System.Windows.Forms.Panel();
            this.coursedis = new System.Windows.Forms.ListBox();
            this.dispanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Barlow Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lbdays.Location = new System.Drawing.Point(3, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(30, 22);
            this.lbdays.TabIndex = 2;
            this.lbdays.Text = "00";
            // 
            // dispanel
            // 
            this.dispanel.Controls.Add(this.coursedis);
            this.dispanel.Font = new System.Drawing.Font("Barlow SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.dispanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.dispanel.Location = new System.Drawing.Point(3, 20);
            this.dispanel.Name = "dispanel";
            this.dispanel.Size = new System.Drawing.Size(114, 47);
            this.dispanel.TabIndex = 3;
            this.dispanel.Click += new System.EventHandler(this.UserControlDays_Click);
            // 
            // coursedis
            // 
            this.coursedis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursedis.FormattingEnabled = true;
            this.coursedis.ItemHeight = 16;
            this.coursedis.Location = new System.Drawing.Point(4, 4);
            this.coursedis.Name = "coursedis";
            this.coursedis.Size = new System.Drawing.Size(107, 48);
            this.coursedis.TabIndex = 0;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dispanel);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(120, 70);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.dispanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Panel dispanel;
        private System.Windows.Forms.ListBox coursedis;
    }
}
