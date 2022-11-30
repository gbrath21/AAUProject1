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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // info_headline
            // 
            this.info_headline.AutoSize = true;
            this.info_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_headline.Location = new System.Drawing.Point(22, 21);
            this.info_headline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info_headline.Name = "info_headline";
            this.info_headline.Size = new System.Drawing.Size(201, 33);
            this.info_headline.TabIndex = 0;
            this.info_headline.Text = "info_headline";
            // 
            // dato_fullview
            // 
            this.dato_fullview.AutoSize = true;
            this.dato_fullview.Location = new System.Drawing.Point(23, 90);
            this.dato_fullview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dato_fullview.Name = "dato_fullview";
            this.dato_fullview.Size = new System.Drawing.Size(57, 25);
            this.dato_fullview.TabIndex = 1;
            this.dato_fullview.Text = "Dato";
            // 
            // hwtext
            // 
            this.hwtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwtext.Location = new System.Drawing.Point(281, 21);
            this.hwtext.Margin = new System.Windows.Forms.Padding(4);
            this.hwtext.Multiline = true;
            this.hwtext.Name = "hwtext";
            this.hwtext.ReadOnly = true;
            this.hwtext.Size = new System.Drawing.Size(1062, 356);
            this.hwtext.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1412, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 12);
            this.panel1.TabIndex = 3;
            // 
            // Full_course_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hwtext);
            this.Controls.Add(this.dato_fullview);
            this.Controls.Add(this.info_headline);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Full_course_view";
            this.Size = new System.Drawing.Size(1700, 421);
            this.Load += new System.EventHandler(this.Full_course_view_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_headline;
        private System.Windows.Forms.Label dato_fullview;
        private System.Windows.Forms.TextBox hwtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}
