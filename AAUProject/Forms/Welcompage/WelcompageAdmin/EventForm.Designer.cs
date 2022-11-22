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
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(482, 763);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(176, 54);
            this.Savebtn.TabIndex = 17;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click_1);
            // 
            // txcoursename
            // 
            this.txcoursename.Location = new System.Drawing.Point(100, 212);
            this.txcoursename.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txcoursename.Multiline = true;
            this.txcoursename.Name = "txcoursename";
            this.txcoursename.Size = new System.Drawing.Size(526, 71);
            this.txcoursename.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(100, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Course name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(100, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date";
            // 
            // txhomework
            // 
            this.txhomework.Location = new System.Drawing.Point(100, 348);
            this.txhomework.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txhomework.Multiline = true;
            this.txhomework.Name = "txhomework";
            this.txhomework.Size = new System.Drawing.Size(526, 71);
            this.txhomework.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(94, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Homework";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 106);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(526, 31);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(100, 452);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Course ";
            // 
            // course_idbox
            // 
            this.course_idbox.FormattingEnabled = true;
            this.course_idbox.Location = new System.Drawing.Point(100, 510);
            this.course_idbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.course_idbox.Name = "course_idbox";
            this.course_idbox.Size = new System.Drawing.Size(526, 33);
            this.course_idbox.TabIndex = 27;
            // 
            // starttime
            // 
            this.starttime.AutoSize = true;
            this.starttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.starttime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.starttime.Location = new System.Drawing.Point(100, 575);
            this.starttime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(124, 29);
            this.starttime.TabIndex = 28;
            this.starttime.Text = "Start time";
            // 
            // endtime
            // 
            this.endtime.AutoSize = true;
            this.endtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.endtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.endtime.Location = new System.Drawing.Point(382, 575);
            this.endtime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(109, 29);
            this.endtime.TabIndex = 29;
            this.endtime.Text = "Endtime";
            // 
            // Starttimebox
            // 
            this.Starttimebox.FormattingEnabled = true;
            this.Starttimebox.Location = new System.Drawing.Point(100, 612);
            this.Starttimebox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Starttimebox.Name = "Starttimebox";
            this.Starttimebox.Size = new System.Drawing.Size(238, 33);
            this.Starttimebox.TabIndex = 30;
            // 
            // Endtimebox
            // 
            this.Endtimebox.FormattingEnabled = true;
            this.Endtimebox.Location = new System.Drawing.Point(388, 612);
            this.Endtimebox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Endtimebox.Name = "Endtimebox";
            this.Endtimebox.Size = new System.Drawing.Size(238, 33);
            this.Endtimebox.TabIndex = 31;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(71, 763);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(6);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(176, 54);
            this.updatebtn.TabIndex = 32;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Visible = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(280, 763);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(6);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(176, 54);
            this.deletebtn.TabIndex = 33;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Visible = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 842);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
    }
}