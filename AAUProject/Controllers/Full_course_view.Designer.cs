namespace AAUProject.Controllers
{
    partial class Full_course_view
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
            this.info_headline = new System.Windows.Forms.Label();
            this.dato_fullview = new System.Windows.Forms.Label();
            this.hwtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // info_headline
            // 
            this.info_headline.AutoSize = true;
            this.info_headline.Location = new System.Drawing.Point(97, 22);
            this.info_headline.Name = "info_headline";
            this.info_headline.Size = new System.Drawing.Size(141, 25);
            this.info_headline.TabIndex = 0;
            this.info_headline.Text = "info_headline";
            // 
            // dato_fullview
            // 
            this.dato_fullview.AutoSize = true;
            this.dato_fullview.Location = new System.Drawing.Point(97, 90);
            this.dato_fullview.Name = "dato_fullview";
            this.dato_fullview.Size = new System.Drawing.Size(57, 25);
            this.dato_fullview.TabIndex = 1;
            this.dato_fullview.Text = "Dato";
            // 
            // hwtext
            // 
            this.hwtext.Location = new System.Drawing.Point(282, 87);
            this.hwtext.Multiline = true;
            this.hwtext.Name = "hwtext";
            this.hwtext.Size = new System.Drawing.Size(1608, 299);
            this.hwtext.TabIndex = 0;
            // 
            // Full_course_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hwtext);
            this.Controls.Add(this.dato_fullview);
            this.Controls.Add(this.info_headline);
            this.Name = "Full_course_view";
            this.Size = new System.Drawing.Size(1940, 421);
            this.Load += new System.EventHandler(this.Full_course_view_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_headline;
        private System.Windows.Forms.Label dato_fullview;
        private System.Windows.Forms.TextBox hwtext;
    }
}
