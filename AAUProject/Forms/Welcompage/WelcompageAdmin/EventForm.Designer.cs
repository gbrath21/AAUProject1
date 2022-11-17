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
            this.components = new System.ComponentModel.Container();
            this.Savebtn = new System.Windows.Forms.Button();
            this.txcoursename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txhomework = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.course_idbox = new System.Windows.Forms.ComboBox();
            this.starttime = new System.Windows.Forms.Label();
            this.endtime = new System.Windows.Forms.Label();
            this.Starttimebox = new System.Windows.Forms.ComboBox();
            this.Endtimebox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.Savebtn.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(241, 397);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(88, 28);
            this.Savebtn.TabIndex = 17;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click_1);
            // 
            // txcoursename
            // 
            this.txcoursename.Location = new System.Drawing.Point(50, 110);
            this.txcoursename.Multiline = true;
            this.txcoursename.Name = "txcoursename";
            this.txcoursename.Size = new System.Drawing.Size(265, 39);
            this.txcoursename.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(50, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Course name";
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
            // txhomework
            // 
            this.txhomework.Location = new System.Drawing.Point(50, 181);
            this.txhomework.Multiline = true;
            this.txhomework.Name = "txhomework";
            this.txhomework.Size = new System.Drawing.Size(265, 39);
            this.txhomework.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(47, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Homework";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(50, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Course ";
            // 
            // course_idbox
            // 
            this.course_idbox.FormattingEnabled = true;
            this.course_idbox.Location = new System.Drawing.Point(50, 265);
            this.course_idbox.Name = "course_idbox";
            this.course_idbox.Size = new System.Drawing.Size(265, 21);
            this.course_idbox.TabIndex = 27;
            // 
            // starttime
            // 
            this.starttime.AutoSize = true;
            this.starttime.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.starttime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.starttime.Location = new System.Drawing.Point(50, 299);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(62, 16);
            this.starttime.TabIndex = 28;
            this.starttime.Text = "Start time";
            // 
            // endtime
            // 
            this.endtime.AutoSize = true;
            this.endtime.Font = new System.Drawing.Font("Barlow", 9F, System.Drawing.FontStyle.Bold);
            this.endtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.endtime.Location = new System.Drawing.Point(191, 299);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(53, 16);
            this.endtime.TabIndex = 29;
            this.endtime.Text = "Endtime";
            // 
            // Starttimebox
            // 
            this.Starttimebox.FormattingEnabled = true;
            this.Starttimebox.Location = new System.Drawing.Point(50, 318);
            this.Starttimebox.Name = "Starttimebox";
            this.Starttimebox.Size = new System.Drawing.Size(121, 21);
            this.Starttimebox.TabIndex = 30;
            // 
            // Endtimebox
            // 
            this.Endtimebox.FormattingEnabled = true;
            this.Endtimebox.Location = new System.Drawing.Point(194, 318);
            this.Endtimebox.Name = "Endtimebox";
            this.Endtimebox.Size = new System.Drawing.Size(121, 21);
            this.Endtimebox.TabIndex = 31;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 438);
            this.Controls.Add(this.Endtimebox);
            this.Controls.Add(this.Starttimebox);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.course_idbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txhomework);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txcoursename);
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
        private System.Windows.Forms.TextBox txcoursename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txhomework;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox course_idbox;
        private System.Windows.Forms.Label starttime;
        private System.Windows.Forms.Label endtime;
        private System.Windows.Forms.ComboBox Starttimebox;
        private System.Windows.Forms.ComboBox Endtimebox;
        private System.Windows.Forms.Timer timer1;
    }
}