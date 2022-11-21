namespace AAUProject.Controllers
{
    partial class HomeworkControl
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
            this.course_name = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.homework = new System.Windows.Forms.TextBox();
            this.time2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // course_name
            // 
            this.course_name.AutoSize = true;
            this.course_name.Location = new System.Drawing.Point(20, 15);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(142, 25);
            this.course_name.TabIndex = 0;
            this.course_name.Text = "course_name";
            this.course_name.Click += new System.EventHandler(this.course_name_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(20, 60);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(52, 25);
            this.time.TabIndex = 1;
            this.time.Text = "time";
            // 
            // homework
            // 
            this.homework.Location = new System.Drawing.Point(3, 116);
            this.homework.Multiline = true;
            this.homework.Name = "homework";
            this.homework.Size = new System.Drawing.Size(235, 190);
            this.homework.TabIndex = 2;
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(97, 60);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(70, 25);
            this.time2.TabIndex = 3;
            this.time2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomeworkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.homework);
            this.Controls.Add(this.time);
            this.Controls.Add(this.course_name);
            this.Name = "HomeworkControl";
            this.Size = new System.Drawing.Size(241, 307);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label course_name;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox homework;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label label1;
    }
}
