namespace AAUProject.Controllers
{
    partial class UserControlAppointment
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
            this.Homeworktxt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Homeworktxt
            // 
            this.Homeworktxt.FormattingEnabled = true;
            this.Homeworktxt.Location = new System.Drawing.Point(3, 0);
            this.Homeworktxt.Name = "Homeworktxt";
            this.Homeworktxt.Size = new System.Drawing.Size(97, 108);
            this.Homeworktxt.TabIndex = 0;
            // 
            // UserControlAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Homeworktxt);
            this.Name = "UserControlAppointment";
            this.Size = new System.Drawing.Size(100, 262);
            this.Load += new System.EventHandler(this.UserControlAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Homeworktxt;
    }
}
