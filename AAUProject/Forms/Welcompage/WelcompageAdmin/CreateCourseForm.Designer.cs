namespace AAUProject.Forms.Welcompage.WelcompageAdmin
{
    partial class CreateCourseForm
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
            this.Coursenametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateCourseBTN = new System.Windows.Forms.Button();
            this.ActivitycomboBox = new System.Windows.Forms.ComboBox();
            this.AvailabilitycomboBox = new System.Windows.Forms.ComboBox();
            this.CourseIdtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Coursenametxt
            // 
            this.Coursenametxt.Location = new System.Drawing.Point(46, 113);
            this.Coursenametxt.MaxLength = 45;
            this.Coursenametxt.Name = "Coursenametxt";
            this.Coursenametxt.Size = new System.Drawing.Size(121, 20);
            this.Coursenametxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Availability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Activity(1 is active and 0 is not active)";
            // 
            // CreateCourseBTN
            // 
            this.CreateCourseBTN.Location = new System.Drawing.Point(198, 291);
            this.CreateCourseBTN.Name = "CreateCourseBTN";
            this.CreateCourseBTN.Size = new System.Drawing.Size(100, 34);
            this.CreateCourseBTN.TabIndex = 10;
            this.CreateCourseBTN.Text = "Create Course";
            this.CreateCourseBTN.UseVisualStyleBackColor = true;
            this.CreateCourseBTN.Click += new System.EventHandler(this.CreateCourseBTN_Click);
            // 
            // ActivitycomboBox
            // 
            this.ActivitycomboBox.FormattingEnabled = true;
            this.ActivitycomboBox.Items.AddRange(new object[] {
            "1",
            "0"});
            this.ActivitycomboBox.Location = new System.Drawing.Point(46, 228);
            this.ActivitycomboBox.Name = "ActivitycomboBox";
            this.ActivitycomboBox.Size = new System.Drawing.Size(121, 21);
            this.ActivitycomboBox.TabIndex = 11;
            // 
            // AvailabilitycomboBox
            // 
            this.AvailabilitycomboBox.FormattingEnabled = true;
            this.AvailabilitycomboBox.Location = new System.Drawing.Point(46, 170);
            this.AvailabilitycomboBox.Name = "AvailabilitycomboBox";
            this.AvailabilitycomboBox.Size = new System.Drawing.Size(121, 21);
            this.AvailabilitycomboBox.TabIndex = 12;
            // 
            // CourseIdtxt
            // 
            this.CourseIdtxt.Location = new System.Drawing.Point(46, 55);
            this.CourseIdtxt.MaxLength = 8;
            this.CourseIdtxt.Name = "CourseIdtxt";
            this.CourseIdtxt.Size = new System.Drawing.Size(121, 20);
            this.CourseIdtxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Course Id";
            // 
            // CreateCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 337);
            this.Controls.Add(this.CourseIdtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AvailabilitycomboBox);
            this.Controls.Add(this.ActivitycomboBox);
            this.Controls.Add(this.CreateCourseBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Coursenametxt);
            this.Controls.Add(this.label2);
            this.Name = "CreateCourseForm";
            this.Text = "CreateCourseForm";
            this.Load += new System.EventHandler(this.CreateCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Coursenametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateCourseBTN;
        private System.Windows.Forms.ComboBox ActivitycomboBox;
        private System.Windows.Forms.ComboBox AvailabilitycomboBox;
        private System.Windows.Forms.TextBox CourseIdtxt;
        private System.Windows.Forms.Label label4;
    }
}