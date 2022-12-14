namespace AAUProject.Forms.Welcompage.WelcompageAdmin
{
    partial class UpdateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernames = new System.Windows.Forms.ComboBox();
            this.passwords = new System.Windows.Forms.TextBox();
            this.user_types = new System.Windows.Forms.ComboBox();
            this.semester = new System.Windows.Forms.ComboBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            // 
            // usernames
            // 
            this.usernames.FormattingEnabled = true;
            this.usernames.Location = new System.Drawing.Point(70, 100);
            this.usernames.Name = "usernames";
            this.usernames.Size = new System.Drawing.Size(327, 33);
            this.usernames.TabIndex = 4;
            this.usernames.SelectedIndexChanged += new System.EventHandler(this.usernames_SelectedIndexChanged);
            // 
            // passwords
            // 
            this.passwords.Location = new System.Drawing.Point(70, 207);
            this.passwords.Multiline = true;
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(327, 31);
            this.passwords.TabIndex = 5;
            // 
            // user_types
            // 
            this.user_types.FormattingEnabled = true;
            this.user_types.Items.AddRange(new object[] {
            "Teacher",
            "Student",
            "Admin"});
            this.user_types.Location = new System.Drawing.Point(70, 349);
            this.user_types.Name = "user_types";
            this.user_types.Size = new System.Drawing.Size(327, 33);
            this.user_types.TabIndex = 6;
            // 
            // semester
            // 
            this.semester.FormattingEnabled = true;
            this.semester.Location = new System.Drawing.Point(70, 482);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(327, 33);
            this.semester.TabIndex = 7;
            this.semester.SelectedIndexChanged += new System.EventHandler(this.semester_SelectedIndexChanged);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Green;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatebtn.Location = new System.Drawing.Point(480, 636);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(192, 63);
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebtn.Location = new System.Drawing.Point(70, 636);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(192, 63);
            this.deletebtn.TabIndex = 9;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 827);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.user_types);
            this.Controls.Add(this.passwords);
            this.Controls.Add(this.usernames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateUser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox usernames;
        private System.Windows.Forms.TextBox passwords;
        private System.Windows.Forms.ComboBox user_types;
        private System.Windows.Forms.ComboBox semester;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
    }
}