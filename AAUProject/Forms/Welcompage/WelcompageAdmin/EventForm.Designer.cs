namespace AAUProject.Forms.Welcompage.WelcompageStundet
{
    partial class EventForm
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
            this.Savebtn = new System.Windows.Forms.Button();
            this.txdate = new System.Windows.Forms.TextBox();
            this.txcourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.Savebtn.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(222, 210);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(88, 28);
            this.Savebtn.TabIndex = 17;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click_1);
            // 
            // txdate
            // 
            this.txdate.Location = new System.Drawing.Point(50, 49);
            this.txdate.Multiline = true;
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(260, 39);
            this.txdate.TabIndex = 18;
            this.txdate.TextChanged += new System.EventHandler(this.txdate_TextChanged);
            // 
            // txcourse
            // 
            this.txcourse.Location = new System.Drawing.Point(50, 133);
            this.txcourse.Multiline = true;
            this.txcourse.Name = "txcourse";
            this.txcourse.Size = new System.Drawing.Size(260, 39);
            this.txcourse.TabIndex = 19;
            this.txcourse.TextChanged += new System.EventHandler(this.txcourse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(50, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(50, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txcourse);
            this.Controls.Add(this.txdate);
            this.Controls.Add(this.Savebtn);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.TextBox txcourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}