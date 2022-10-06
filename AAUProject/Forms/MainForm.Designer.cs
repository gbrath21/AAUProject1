namespace AAUProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.Login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LabelPassword = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelUsername = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGroupBox1.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(547, 256);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(180, 20);
            this.Password.TabIndex = 16;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Barlow", 8.25F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(547, 194);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(182, 21);
            this.Username.TabIndex = 15;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // UserType
            // 
            this.UserType.Font = new System.Drawing.Font("Barlow", 8.25F, System.Drawing.FontStyle.Bold);
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.UserType.Location = new System.Drawing.Point(547, 309);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(180, 23);
            this.UserType.TabIndex = 12;
            this.UserType.Text = "Select user type";
            this.UserType.SelectedIndexChanged += new System.EventHandler(this.UserType_SelectedIndexChanged);
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.White;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.Login);
            this.bunifuGroupBox1.Controls.Add(this.LabelPassword);
            this.bunifuGroupBox1.Controls.Add(this.LabelUsername);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel1);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(467, 1);
            this.bunifuGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuGroupBox1.Size = new System.Drawing.Size(467, 552);
            this.bunifuGroupBox1.TabIndex = 18;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Enter += new System.EventHandler(this.bunifuGroupBox1_Enter);
            // 
            // Login
            // 
            this.Login.AllowAnimations = true;
            this.Login.AllowMouseEffects = true;
            this.Login.AllowToggling = false;
            this.Login.AnimationSpeed = 200;
            this.Login.AutoGenerateColors = false;
            this.Login.AutoRoundBorders = false;
            this.Login.AutoSizeLeftIcon = true;
            this.Login.AutoSizeRightIcon = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Login.ButtonText = "Login";
            this.Login.ButtonTextMarginLeft = 0;
            this.Login.ColorContrastOnClick = 45;
            this.Login.ColorContrastOnHover = 45;
            this.Login.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Login.CustomizableEdges = borderEdges1;
            this.Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Login.DisabledFillColor = System.Drawing.Color.Empty;
            this.Login.DisabledForecolor = System.Drawing.Color.Empty;
            this.Login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Login.Font = new System.Drawing.Font("Barlow", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.IconLeft = null;
            this.Login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Login.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Login.IconMarginLeft = 11;
            this.Login.IconPadding = 10;
            this.Login.IconRight = null;
            this.Login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Login.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Login.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Login.IconSize = 25;
            this.Login.IdleBorderColor = System.Drawing.Color.Empty;
            this.Login.IdleBorderRadius = 0;
            this.Login.IdleBorderThickness = 0;
            this.Login.IdleFillColor = System.Drawing.Color.Empty;
            this.Login.IdleIconLeftImage = null;
            this.Login.IdleIconRightImage = null;
            this.Login.IndicateFocus = false;
            this.Login.Location = new System.Drawing.Point(107, 356);
            this.Login.Name = "Login";
            this.Login.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Login.OnDisabledState.BorderRadius = 1;
            this.Login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Login.OnDisabledState.BorderThickness = 1;
            this.Login.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Login.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Login.OnDisabledState.IconLeftImage = null;
            this.Login.OnDisabledState.IconRightImage = null;
            this.Login.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.Login.onHoverState.BorderRadius = 1;
            this.Login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Login.onHoverState.BorderThickness = 1;
            this.Login.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.Login.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Login.onHoverState.IconLeftImage = null;
            this.Login.onHoverState.IconRightImage = null;
            this.Login.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.Login.OnIdleState.BorderRadius = 1;
            this.Login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Login.OnIdleState.BorderThickness = 1;
            this.Login.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.Login.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Login.OnIdleState.IconLeftImage = null;
            this.Login.OnIdleState.IconRightImage = null;
            this.Login.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Login.OnPressedState.BorderRadius = 1;
            this.Login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Login.OnPressedState.BorderThickness = 1;
            this.Login.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Login.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Login.OnPressedState.IconLeftImage = null;
            this.Login.OnPressedState.IconRightImage = null;
            this.Login.Size = new System.Drawing.Size(137, 39);
            this.Login.TabIndex = 3;
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login.TextMarginLeft = 0;
            this.Login.TextPadding = new System.Windows.Forms.Padding(0);
            this.Login.UseDefaultRadiusAndThickness = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AllowParentOverrides = false;
            this.LabelPassword.AutoEllipsis = false;
            this.LabelPassword.CursorType = null;
            this.LabelPassword.Font = new System.Drawing.Font("Barlow Black", 9F, System.Drawing.FontStyle.Bold);
            this.LabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.LabelPassword.Location = new System.Drawing.Point(80, 234);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPassword.Size = new System.Drawing.Size(54, 16);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Password";
            this.LabelPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelPassword.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AllowParentOverrides = false;
            this.LabelUsername.AutoEllipsis = false;
            this.LabelUsername.CursorType = null;
            this.LabelUsername.Font = new System.Drawing.Font("Barlow Black", 9F, System.Drawing.FontStyle.Bold);
            this.LabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.LabelUsername.Location = new System.Drawing.Point(80, 172);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelUsername.Size = new System.Drawing.Size(55, 16);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "Username";
            this.LabelUsername.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelUsername.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Barlow Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(31, 62);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuLabel1.Size = new System.Drawing.Size(188, 45);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Please Login";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.bunifuGroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.label4);
            this.bunifuGroupBox2.Controls.Add(this.pictureBox1);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(0, 1);
            this.bunifuGroupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuGroupBox2.Size = new System.Drawing.Size(467, 552);
            this.bunifuGroupBox2.TabIndex = 19;
            this.bunifuGroupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Barlow ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Welcome to The AAU Schedule App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 551);
            this.Controls.Add(this.bunifuGroupBox2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.bunifuGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.ComboBox UserType;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel LabelPassword;
        private Bunifu.UI.WinForms.BunifuLabel LabelUsername;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Login;
    }
}