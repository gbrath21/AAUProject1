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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.passwordtx = new Bunifu.UI.WinForms.BunifuTextBox();
            this.usernametx = new Bunifu.UI.WinForms.BunifuTextBox();
            this.usertypetx = new Bunifu.UI.WinForms.BunifuDropdown();
            this.semestertx = new Bunifu.UI.WinForms.BunifuDropdown();
            this.UsernameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.PasswordLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.UserTypeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SemesterLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SaveUserInDBButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // passwordtx
            // 
            this.passwordtx.AcceptsReturn = false;
            this.passwordtx.AcceptsTab = false;
            this.passwordtx.AnimationSpeed = 200;
            this.passwordtx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordtx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordtx.AutoSizeHeight = true;
            this.passwordtx.BackColor = System.Drawing.Color.Transparent;
            this.passwordtx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordtx.BackgroundImage")));
            this.passwordtx.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.passwordtx.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordtx.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwordtx.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwordtx.BorderRadius = 1;
            this.passwordtx.BorderThickness = 1;
            this.passwordtx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordtx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtx.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.passwordtx.DefaultText = "";
            this.passwordtx.FillColor = System.Drawing.Color.White;
            this.passwordtx.HideSelection = true;
            this.passwordtx.IconLeft = null;
            this.passwordtx.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtx.IconPadding = 10;
            this.passwordtx.IconRight = null;
            this.passwordtx.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtx.Lines = new string[0];
            this.passwordtx.Location = new System.Drawing.Point(39, 162);
            this.passwordtx.MaxLength = 32767;
            this.passwordtx.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordtx.Modified = false;
            this.passwordtx.Multiline = false;
            this.passwordtx.Name = "passwordtx";
            stateProperties25.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordtx.OnActiveState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordtx.OnDisabledState = stateProperties26;
            stateProperties27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties27.FillColor = System.Drawing.Color.Empty;
            stateProperties27.ForeColor = System.Drawing.Color.Empty;
            stateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordtx.OnHoverState = stateProperties27;
            stateProperties28.BorderColor = System.Drawing.Color.Silver;
            stateProperties28.FillColor = System.Drawing.Color.White;
            stateProperties28.ForeColor = System.Drawing.Color.Empty;
            stateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordtx.OnIdleState = stateProperties28;
            this.passwordtx.Padding = new System.Windows.Forms.Padding(3);
            this.passwordtx.PasswordChar = '\0';
            this.passwordtx.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordtx.PlaceholderText = "Enter text";
            this.passwordtx.ReadOnly = false;
            this.passwordtx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtx.SelectedText = "";
            this.passwordtx.SelectionLength = 0;
            this.passwordtx.SelectionStart = 0;
            this.passwordtx.ShortcutsEnabled = true;
            this.passwordtx.Size = new System.Drawing.Size(209, 39);
            this.passwordtx.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordtx.TabIndex = 1;
            this.passwordtx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordtx.TextMarginBottom = 0;
            this.passwordtx.TextMarginLeft = 3;
            this.passwordtx.TextMarginTop = 1;
            this.passwordtx.TextPlaceholder = "Enter text";
            this.passwordtx.UseSystemPasswordChar = false;
            this.passwordtx.WordWrap = true;
            // 
            // usernametx
            // 
            this.usernametx.AcceptsReturn = false;
            this.usernametx.AcceptsTab = false;
            this.usernametx.AnimationSpeed = 200;
            this.usernametx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernametx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernametx.AutoSizeHeight = true;
            this.usernametx.BackColor = System.Drawing.Color.Transparent;
            this.usernametx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernametx.BackgroundImage")));
            this.usernametx.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.usernametx.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usernametx.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.usernametx.BorderColorIdle = System.Drawing.Color.Silver;
            this.usernametx.BorderRadius = 1;
            this.usernametx.BorderThickness = 1;
            this.usernametx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernametx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametx.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.usernametx.DefaultText = "";
            this.usernametx.FillColor = System.Drawing.Color.White;
            this.usernametx.HideSelection = true;
            this.usernametx.IconLeft = null;
            this.usernametx.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametx.IconPadding = 10;
            this.usernametx.IconRight = null;
            this.usernametx.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametx.Lines = new string[0];
            this.usernametx.Location = new System.Drawing.Point(39, 92);
            this.usernametx.MaxLength = 32767;
            this.usernametx.MinimumSize = new System.Drawing.Size(1, 1);
            this.usernametx.Modified = false;
            this.usernametx.Multiline = false;
            this.usernametx.Name = "usernametx";
            stateProperties29.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties29.FillColor = System.Drawing.Color.Empty;
            stateProperties29.ForeColor = System.Drawing.Color.Empty;
            stateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernametx.OnActiveState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.usernametx.OnDisabledState = stateProperties30;
            stateProperties31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties31.FillColor = System.Drawing.Color.Empty;
            stateProperties31.ForeColor = System.Drawing.Color.Empty;
            stateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernametx.OnHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.Silver;
            stateProperties32.FillColor = System.Drawing.Color.White;
            stateProperties32.ForeColor = System.Drawing.Color.Empty;
            stateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernametx.OnIdleState = stateProperties32;
            this.usernametx.Padding = new System.Windows.Forms.Padding(3);
            this.usernametx.PasswordChar = '\0';
            this.usernametx.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.usernametx.PlaceholderText = "Enter text";
            this.usernametx.ReadOnly = false;
            this.usernametx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametx.SelectedText = "";
            this.usernametx.SelectionLength = 0;
            this.usernametx.SelectionStart = 0;
            this.usernametx.ShortcutsEnabled = true;
            this.usernametx.Size = new System.Drawing.Size(209, 39);
            this.usernametx.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.usernametx.TabIndex = 0;
            this.usernametx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernametx.TextMarginBottom = 0;
            this.usernametx.TextMarginLeft = 3;
            this.usernametx.TextMarginTop = 1;
            this.usernametx.TextPlaceholder = "Enter text";
            this.usernametx.UseSystemPasswordChar = false;
            this.usernametx.WordWrap = true;
            // 
            // usertypetx
            // 
            this.usertypetx.BackColor = System.Drawing.Color.Transparent;
            this.usertypetx.BackgroundColor = System.Drawing.Color.White;
            this.usertypetx.BorderColor = System.Drawing.Color.Silver;
            this.usertypetx.BorderRadius = 1;
            this.usertypetx.Color = System.Drawing.Color.Silver;
            this.usertypetx.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.usertypetx.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.usertypetx.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usertypetx.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.usertypetx.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usertypetx.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.usertypetx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.usertypetx.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.usertypetx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usertypetx.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.usertypetx.FillDropDown = true;
            this.usertypetx.FillIndicator = false;
            this.usertypetx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usertypetx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usertypetx.ForeColor = System.Drawing.Color.Black;
            this.usertypetx.FormattingEnabled = true;
            this.usertypetx.Icon = null;
            this.usertypetx.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.usertypetx.IndicatorColor = System.Drawing.Color.DarkGray;
            this.usertypetx.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.usertypetx.IndicatorThickness = 2;
            this.usertypetx.IsDropdownOpened = false;
            this.usertypetx.ItemBackColor = System.Drawing.Color.White;
            this.usertypetx.ItemBorderColor = System.Drawing.Color.White;
            this.usertypetx.ItemForeColor = System.Drawing.Color.Black;
            this.usertypetx.ItemHeight = 26;
            this.usertypetx.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.usertypetx.ItemHighLightForeColor = System.Drawing.Color.White;
            this.usertypetx.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.usertypetx.ItemTopMargin = 3;
            this.usertypetx.Location = new System.Drawing.Point(39, 235);
            this.usertypetx.Name = "usertypetx";
            this.usertypetx.Size = new System.Drawing.Size(209, 32);
            this.usertypetx.TabIndex = 3;
            this.usertypetx.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.usertypetx.TextLeftMargin = 5;
            // 
            // semestertx
            // 
            this.semestertx.BackColor = System.Drawing.Color.Transparent;
            this.semestertx.BackgroundColor = System.Drawing.Color.White;
            this.semestertx.BorderColor = System.Drawing.Color.Silver;
            this.semestertx.BorderRadius = 1;
            this.semestertx.Color = System.Drawing.Color.Silver;
            this.semestertx.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.semestertx.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.semestertx.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.semestertx.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.semestertx.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.semestertx.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.semestertx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.semestertx.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.semestertx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestertx.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.semestertx.FillDropDown = true;
            this.semestertx.FillIndicator = false;
            this.semestertx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.semestertx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.semestertx.ForeColor = System.Drawing.Color.Black;
            this.semestertx.FormattingEnabled = true;
            this.semestertx.Icon = null;
            this.semestertx.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.semestertx.IndicatorColor = System.Drawing.Color.DarkGray;
            this.semestertx.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.semestertx.IndicatorThickness = 2;
            this.semestertx.IsDropdownOpened = false;
            this.semestertx.ItemBackColor = System.Drawing.Color.White;
            this.semestertx.ItemBorderColor = System.Drawing.Color.White;
            this.semestertx.ItemForeColor = System.Drawing.Color.Black;
            this.semestertx.ItemHeight = 26;
            this.semestertx.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.semestertx.ItemHighLightForeColor = System.Drawing.Color.White;
            this.semestertx.ItemTopMargin = 3;
            this.semestertx.Location = new System.Drawing.Point(39, 303);
            this.semestertx.Name = "semestertx";
            this.semestertx.Size = new System.Drawing.Size(209, 32);
            this.semestertx.TabIndex = 4;
            this.semestertx.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.semestertx.TextLeftMargin = 5;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AllowParentOverrides = false;
            this.UsernameLabel.AutoEllipsis = false;
            this.UsernameLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.UsernameLabel.Font = new System.Drawing.Font("Barlow SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.Location = new System.Drawing.Point(39, 71);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameLabel.Size = new System.Drawing.Size(54, 16);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.UsernameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.UsernameLabel.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AllowParentOverrides = false;
            this.PasswordLabel.AutoEllipsis = false;
            this.PasswordLabel.CursorType = null;
            this.PasswordLabel.Font = new System.Drawing.Font("Barlow SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(39, 141);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordLabel.Size = new System.Drawing.Size(53, 16);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PasswordLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AllowParentOverrides = false;
            this.UserTypeLabel.AutoEllipsis = false;
            this.UserTypeLabel.CursorType = null;
            this.UserTypeLabel.Font = new System.Drawing.Font("Barlow SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.UserTypeLabel.Location = new System.Drawing.Point(39, 214);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserTypeLabel.Size = new System.Drawing.Size(50, 16);
            this.UserTypeLabel.TabIndex = 7;
            this.UserTypeLabel.Text = "User type";
            this.UserTypeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.UserTypeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AllowParentOverrides = false;
            this.SemesterLabel.AutoEllipsis = false;
            this.SemesterLabel.CursorType = null;
            this.SemesterLabel.Font = new System.Drawing.Font("Barlow SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.SemesterLabel.Location = new System.Drawing.Point(39, 282);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SemesterLabel.Size = new System.Drawing.Size(50, 16);
            this.SemesterLabel.TabIndex = 8;
            this.SemesterLabel.Text = "Semester";
            this.SemesterLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SemesterLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SaveUserInDBButton
            // 
            this.SaveUserInDBButton.AllowAnimations = true;
            this.SaveUserInDBButton.AllowMouseEffects = true;
            this.SaveUserInDBButton.AllowToggling = false;
            this.SaveUserInDBButton.AnimationSpeed = 200;
            this.SaveUserInDBButton.AutoGenerateColors = false;
            this.SaveUserInDBButton.AutoRoundBorders = false;
            this.SaveUserInDBButton.AutoSizeLeftIcon = true;
            this.SaveUserInDBButton.AutoSizeRightIcon = true;
            this.SaveUserInDBButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveUserInDBButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.SaveUserInDBButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveUserInDBButton.BackgroundImage")));
            this.SaveUserInDBButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveUserInDBButton.ButtonText = "Create User";
            this.SaveUserInDBButton.ButtonTextMarginLeft = 0;
            this.SaveUserInDBButton.ColorContrastOnClick = 45;
            this.SaveUserInDBButton.ColorContrastOnHover = 45;
            this.SaveUserInDBButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.SaveUserInDBButton.CustomizableEdges = borderEdges4;
            this.SaveUserInDBButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveUserInDBButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveUserInDBButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.SaveUserInDBButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.SaveUserInDBButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveUserInDBButton.Font = new System.Drawing.Font("Barlow SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.SaveUserInDBButton.ForeColor = System.Drawing.Color.White;
            this.SaveUserInDBButton.IconLeft = null;
            this.SaveUserInDBButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveUserInDBButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveUserInDBButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveUserInDBButton.IconMarginLeft = 11;
            this.SaveUserInDBButton.IconPadding = 10;
            this.SaveUserInDBButton.IconRight = null;
            this.SaveUserInDBButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveUserInDBButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveUserInDBButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveUserInDBButton.IconSize = 25;
            this.SaveUserInDBButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.SaveUserInDBButton.IdleBorderRadius = 0;
            this.SaveUserInDBButton.IdleBorderThickness = 0;
            this.SaveUserInDBButton.IdleFillColor = System.Drawing.Color.Empty;
            this.SaveUserInDBButton.IdleIconLeftImage = null;
            this.SaveUserInDBButton.IdleIconRightImage = null;
            this.SaveUserInDBButton.IndicateFocus = false;
            this.SaveUserInDBButton.Location = new System.Drawing.Point(151, 376);
            this.SaveUserInDBButton.Name = "SaveUserInDBButton";
            this.SaveUserInDBButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveUserInDBButton.OnDisabledState.BorderRadius = 1;
            this.SaveUserInDBButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveUserInDBButton.OnDisabledState.BorderThickness = 1;
            this.SaveUserInDBButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveUserInDBButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveUserInDBButton.OnDisabledState.IconLeftImage = null;
            this.SaveUserInDBButton.OnDisabledState.IconRightImage = null;
            this.SaveUserInDBButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.SaveUserInDBButton.onHoverState.BorderRadius = 1;
            this.SaveUserInDBButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveUserInDBButton.onHoverState.BorderThickness = 1;
            this.SaveUserInDBButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.SaveUserInDBButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SaveUserInDBButton.onHoverState.IconLeftImage = null;
            this.SaveUserInDBButton.onHoverState.IconRightImage = null;
            this.SaveUserInDBButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SaveUserInDBButton.OnIdleState.BorderRadius = 1;
            this.SaveUserInDBButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveUserInDBButton.OnIdleState.BorderThickness = 1;
            this.SaveUserInDBButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SaveUserInDBButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SaveUserInDBButton.OnIdleState.IconLeftImage = null;
            this.SaveUserInDBButton.OnIdleState.IconRightImage = null;
            this.SaveUserInDBButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveUserInDBButton.OnPressedState.BorderRadius = 1;
            this.SaveUserInDBButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveUserInDBButton.OnPressedState.BorderThickness = 1;
            this.SaveUserInDBButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveUserInDBButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SaveUserInDBButton.OnPressedState.IconLeftImage = null;
            this.SaveUserInDBButton.OnPressedState.IconRightImage = null;
            this.SaveUserInDBButton.Size = new System.Drawing.Size(150, 39);
            this.SaveUserInDBButton.TabIndex = 9;
            this.SaveUserInDBButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveUserInDBButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveUserInDBButton.TextMarginLeft = 0;
            this.SaveUserInDBButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SaveUserInDBButton.UseDefaultRadiusAndThickness = true;
            this.SaveUserInDBButton.Click += new System.EventHandler(this.SaveUserInDBButton_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Barlow SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(26, 22);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(186, 16);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Fill in the boxes to create a new user";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.SaveUserInDBButton);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.UserTypeLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.semestertx);
            this.Controls.Add(this.usertypetx);
            this.Controls.Add(this.passwordtx);
            this.Controls.Add(this.usernametx);
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox usernametx;
        private Bunifu.UI.WinForms.BunifuTextBox passwordtx;
        private Bunifu.UI.WinForms.BunifuDropdown usertypetx;
        private Bunifu.UI.WinForms.BunifuDropdown semestertx;
        private Bunifu.UI.WinForms.BunifuLabel UsernameLabel;
        private Bunifu.UI.WinForms.BunifuLabel PasswordLabel;
        private Bunifu.UI.WinForms.BunifuLabel UserTypeLabel;
        private Bunifu.UI.WinForms.BunifuLabel SemesterLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveUserInDBButton;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}