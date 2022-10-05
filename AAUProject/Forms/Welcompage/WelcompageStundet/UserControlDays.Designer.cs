namespace AAUProject.Forms.Welcompage.WelcompageStundet
{
    partial class UserControlDays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDays));
            this.lbdays = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AllowParentOverrides = false;
            this.lbdays.AutoEllipsis = false;
            this.lbdays.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbdays.Font = new System.Drawing.Font("Barlow Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lbdays.Location = new System.Drawing.Point(13, 12);
            this.lbdays.Name = "lbdays";
            this.lbdays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbdays.Size = new System.Drawing.Size(20, 22);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            this.lbdays.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbdays.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(120, 85);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbdays;
    }
}
