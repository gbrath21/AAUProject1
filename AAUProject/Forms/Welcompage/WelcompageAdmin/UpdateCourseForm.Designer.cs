namespace AAUProject.Forms.Welcompage.WelcompageAdmin
{
    partial class UpdateCourseForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.AvailabilitycomboBox = new System.Windows.Forms.ComboBox();
            this.ActivitycomboBox = new System.Windows.Forms.ComboBox();
            this.UpdateCourseBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Coursenametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CourseIDcomboBox = new System.Windows.Forms.ComboBox();
            this.DeleteCourseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Course Id";
            // 
            // AvailabilitycomboBox
            // 
            this.AvailabilitycomboBox.FormattingEnabled = true;
            this.AvailabilitycomboBox.Location = new System.Drawing.Point(38, 155);
            this.AvailabilitycomboBox.Name = "AvailabilitycomboBox";
            this.AvailabilitycomboBox.Size = new System.Drawing.Size(121, 21);
            this.AvailabilitycomboBox.TabIndex = 21;
            // 
            // ActivitycomboBox
            // 
            this.ActivitycomboBox.FormattingEnabled = true;
            this.ActivitycomboBox.Items.AddRange(new object[] {
            "1",
            "0"});
            this.ActivitycomboBox.Location = new System.Drawing.Point(38, 213);
            this.ActivitycomboBox.Name = "ActivitycomboBox";
            this.ActivitycomboBox.Size = new System.Drawing.Size(121, 21);
            this.ActivitycomboBox.TabIndex = 20;
            // 
            // UpdateCourseBTN
            // 
            this.UpdateCourseBTN.Location = new System.Drawing.Point(190, 276);
            this.UpdateCourseBTN.Name = "UpdateCourseBTN";
            this.UpdateCourseBTN.Size = new System.Drawing.Size(100, 34);
            this.UpdateCourseBTN.TabIndex = 19;
            this.UpdateCourseBTN.Text = "Update Course";
            this.UpdateCourseBTN.UseVisualStyleBackColor = true;
            this.UpdateCourseBTN.Click += new System.EventHandler(this.UpdateCourseBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Activity(1 is active and 0 is not active)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Availability";
            // 
            // Coursenametxt
            // 
            this.Coursenametxt.Location = new System.Drawing.Point(38, 98);
            this.Coursenametxt.MaxLength = 45;
            this.Coursenametxt.Name = "Coursenametxt";
            this.Coursenametxt.Size = new System.Drawing.Size(121, 20);
            this.Coursenametxt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Course Name";
            // 
            // CourseIDcomboBox
            // 
            this.CourseIDcomboBox.FormattingEnabled = true;
            this.CourseIDcomboBox.Location = new System.Drawing.Point(38, 40);
            this.CourseIDcomboBox.Name = "CourseIDcomboBox";
            this.CourseIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CourseIDcomboBox.TabIndex = 23;
            this.CourseIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.CourseIDcomboBox_SelectedIndexChanged);
            // 
            // DeleteCourseBTN
            // 
            this.DeleteCourseBTN.Location = new System.Drawing.Point(26, 276);
            this.DeleteCourseBTN.Name = "DeleteCourseBTN";
            this.DeleteCourseBTN.Size = new System.Drawing.Size(100, 34);
            this.DeleteCourseBTN.TabIndex = 24;
            this.DeleteCourseBTN.Text = "Delete Course";
            this.DeleteCourseBTN.UseVisualStyleBackColor = true;
            this.DeleteCourseBTN.Click += new System.EventHandler(this.DeleteCourseBTN_Click);
            // 
            // UpdateCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 337);
            this.Controls.Add(this.DeleteCourseBTN);
            this.Controls.Add(this.CourseIDcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AvailabilitycomboBox);
            this.Controls.Add(this.ActivitycomboBox);
            this.Controls.Add(this.UpdateCourseBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Coursenametxt);
            this.Controls.Add(this.label2);
            this.Name = "UpdateCourseForm";
            this.Text = "UpdateCourseForm";
            this.Load += new System.EventHandler(this.UpdateCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AvailabilitycomboBox;
        private System.Windows.Forms.ComboBox ActivitycomboBox;
        private System.Windows.Forms.Button UpdateCourseBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Coursenametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CourseIDcomboBox;
        private System.Windows.Forms.Button DeleteCourseBTN;
    }
}