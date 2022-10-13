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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDays));
            this.lbdays = new Bunifu.UI.WinForms.BunifuLabel();
            this.dispnl = new Bunifu.UI.WinForms.BunifuLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AllowParentOverrides = false;
            this.lbdays.AutoEllipsis = false;
            this.lbdays.Cursor = System.Windows.Forms.Cursors.Default;
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
            // dispnl
            // 
            this.dispnl.AllowParentOverrides = false;
            this.dispnl.AutoEllipsis = false;
            this.dispnl.AutoSize = false;
            this.dispnl.Cursor = System.Windows.Forms.Cursors.Default;
            this.dispnl.CursorType = System.Windows.Forms.Cursors.Default;
            this.dispnl.Font = new System.Drawing.Font("Barlow SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.dispnl.Location = new System.Drawing.Point(3, 40);
            this.dispnl.Name = "dispnl";
            this.dispnl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dispnl.Size = new System.Drawing.Size(114, 27);
            this.dispnl.TabIndex = 1;
            this.dispnl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dispnl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dispnl);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(120, 70);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbdays;
        private Bunifu.UI.WinForms.BunifuLabel dispnl;
        private System.Windows.Forms.Timer timer1;
    }
}
