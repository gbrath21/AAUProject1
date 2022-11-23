namespace AAUProject.Forms.Welcompage.WelcompageAdmin
{
    partial class CreateUserForm
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
            this.usernametxt = new ReaLTaiizor.Controls.BigTextBox();
            this.passwordtxt = new ReaLTaiizor.Controls.BigTextBox();
            this.semestertxt = new ReaLTaiizor.Controls.AloneComboBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            this.usertypetxt = new ReaLTaiizor.Controls.AloneComboBox();
            this.createuser_button = new ReaLTaiizor.Controls.Button();
            this.compositeLayout1 = new MindFusion.Diagramming.Layout.CompositeLayout();
            this.SuspendLayout();
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.Transparent;
            this.usernametxt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.usernametxt.ForeColor = System.Drawing.Color.DimGray;
            this.usernametxt.Image = null;
            this.usernametxt.Location = new System.Drawing.Point(146, 138);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernametxt.MaxLength = 32767;
            this.usernametxt.Multiline = false;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.ReadOnly = false;
            this.usernametxt.Size = new System.Drawing.Size(418, 59);
            this.usernametxt.TabIndex = 11;
            this.usernametxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernametxt.UseSystemPasswordChar = false;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordtxt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.passwordtxt.ForeColor = System.Drawing.Color.DimGray;
            this.passwordtxt.Image = null;
            this.passwordtxt.Location = new System.Drawing.Point(146, 304);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordtxt.MaxLength = 32767;
            this.passwordtxt.Multiline = false;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.ReadOnly = false;
            this.passwordtxt.Size = new System.Drawing.Size(418, 59);
            this.passwordtxt.TabIndex = 12;
            this.passwordtxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordtxt.UseSystemPasswordChar = false;
            // 
            // semestertxt
            // 
            this.semestertxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.semestertxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.semestertxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestertxt.EnabledCalc = true;
            this.semestertxt.FormattingEnabled = true;
            this.semestertxt.ItemHeight = 20;
            this.semestertxt.Location = new System.Drawing.Point(146, 560);
            this.semestertxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.semestertxt.Name = "semestertxt";
            this.semestertxt.Size = new System.Drawing.Size(414, 26);
            this.semestertxt.TabIndex = 14;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(162, 96);
            this.dungeonLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(152, 41);
            this.dungeonLabel1.TabIndex = 15;
            this.dungeonLabel1.Text = "Username";
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(162, 262);
            this.dungeonLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(143, 41);
            this.dungeonLabel2.TabIndex = 16;
            this.dungeonLabel2.Text = "Password";
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(162, 412);
            this.dungeonLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(137, 41);
            this.dungeonLabel3.TabIndex = 17;
            this.dungeonLabel3.Text = "Usertype";
            // 
            // dungeonLabel4
            // 
            this.dungeonLabel4.AutoSize = true;
            this.dungeonLabel4.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel4.Location = new System.Drawing.Point(162, 517);
            this.dungeonLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonLabel4.Name = "dungeonLabel4";
            this.dungeonLabel4.Size = new System.Drawing.Size(141, 41);
            this.dungeonLabel4.TabIndex = 18;
            this.dungeonLabel4.Text = "Semester";
            // 
            // usertypetxt
            // 
            this.usertypetxt.BackColor = System.Drawing.SystemColors.Control;
            this.usertypetxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usertypetxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.usertypetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usertypetxt.EnabledCalc = true;
            this.usertypetxt.FormattingEnabled = true;
            this.usertypetxt.ItemHeight = 20;
            this.usertypetxt.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.usertypetxt.Location = new System.Drawing.Point(146, 454);
            this.usertypetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usertypetxt.Name = "usertypetxt";
            this.usertypetxt.Size = new System.Drawing.Size(418, 26);
            this.usertypetxt.TabIndex = 13;
            this.usertypetxt.SelectedIndexChanged += new System.EventHandler(this.usertypetxt_SelectedIndexChanged);
            // 
            // createuser_button
            // 
            this.createuser_button.BackColor = System.Drawing.Color.Transparent;
            this.createuser_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createuser_button.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.createuser_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createuser_button.Image = null;
            this.createuser_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createuser_button.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.createuser_button.Location = new System.Drawing.Point(336, 662);
            this.createuser_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createuser_button.Name = "createuser_button";
            this.createuser_button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.createuser_button.Size = new System.Drawing.Size(300, 67);
            this.createuser_button.TabIndex = 19;
            this.createuser_button.Text = "Create User";
            this.createuser_button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.createuser_button.Click += new System.EventHandler(this.createuser_button_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 865);
            this.Controls.Add(this.createuser_button);
            this.Controls.Add(this.dungeonLabel4);
            this.Controls.Add(this.dungeonLabel3);
            this.Controls.Add(this.dungeonLabel2);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.semestertxt);
            this.Controls.Add(this.usertypetxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.BigTextBox usernametxt;
        private ReaLTaiizor.Controls.BigTextBox passwordtxt;
        private ReaLTaiizor.Controls.AloneComboBox semestertxt;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.AloneComboBox usertypetxt;
        private ReaLTaiizor.Controls.Button createuser_button;
        private MindFusion.Diagramming.Layout.CompositeLayout compositeLayout1;
    }
}