namespace GothamChat
{
    partial class ArkhamLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArkhamLogin));
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lLblForgot = new MetroFramework.Controls.MetroLink();
            this.btnSignup = new MetroFramework.Controls.MetroButton();
            this.tbxUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbxPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbxSName = new MetroFramework.Controls.MetroTextBox();
            this.tbxSsurname = new MetroFramework.Controls.MetroTextBox();
            this.tbxSusername = new MetroFramework.Controls.MetroTextBox();
            this.tbxSemail = new MetroFramework.Controls.MetroTextBox();
            this.tbxSpassword = new MetroFramework.Controls.MetroTextBox();
            this.lblSname = new MetroFramework.Controls.MetroLabel();
            this.lblSsurname = new MetroFramework.Controls.MetroLabel();
            this.lblSusername = new MetroFramework.Controls.MetroLabel();
            this.lblSemail = new MetroFramework.Controls.MetroLabel();
            this.lblSpassword = new MetroFramework.Controls.MetroLabel();
            this.lblNewAccount = new MetroFramework.Controls.MetroLink();
            this.Loading = new MetroFramework.Controls.MetroProgressBar();
            this.LoadingBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 158);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 19);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 191);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(85, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 32);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lLblForgot
            // 
            this.lLblForgot.Location = new System.Drawing.Point(85, 331);
            this.lLblForgot.Name = "lLblForgot";
            this.lLblForgot.Size = new System.Drawing.Size(134, 25);
            this.lLblForgot.TabIndex = 1;
            this.lLblForgot.Text = "I Forgot my password.";
            this.lLblForgot.UseSelectable = true;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(333, 292);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(134, 32);
            this.btnSignup.TabIndex = 2;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseSelectable = true;
            this.btnSignup.Visible = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // tbxUsername
            // 
            // 
            // 
            // 
            this.tbxUsername.CustomButton.Image = null;
            this.tbxUsername.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.tbxUsername.CustomButton.Name = "";
            this.tbxUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxUsername.CustomButton.TabIndex = 1;
            this.tbxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxUsername.CustomButton.UseSelectable = true;
            this.tbxUsername.CustomButton.Visible = false;
            this.tbxUsername.Lines = new string[0];
            this.tbxUsername.Location = new System.Drawing.Point(85, 158);
            this.tbxUsername.MaxLength = 32767;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.SelectionLength = 0;
            this.tbxUsername.SelectionStart = 0;
            this.tbxUsername.ShortcutsEnabled = true;
            this.tbxUsername.Size = new System.Drawing.Size(134, 25);
            this.tbxUsername.TabIndex = 4;
            this.tbxUsername.UseSelectable = true;
            this.tbxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxPassword
            // 
            // 
            // 
            // 
            this.tbxPassword.CustomButton.Image = null;
            this.tbxPassword.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.tbxPassword.CustomButton.Name = "";
            this.tbxPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPassword.CustomButton.TabIndex = 1;
            this.tbxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPassword.CustomButton.UseSelectable = true;
            this.tbxPassword.CustomButton.Visible = false;
            this.tbxPassword.Lines = new string[0];
            this.tbxPassword.Location = new System.Drawing.Point(85, 190);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.SelectionLength = 0;
            this.tbxPassword.SelectionStart = 0;
            this.tbxPassword.ShortcutsEnabled = true;
            this.tbxPassword.Size = new System.Drawing.Size(134, 25);
            this.tbxPassword.TabIndex = 5;
            this.tbxPassword.UseSelectable = true;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxSName
            // 
            // 
            // 
            // 
            this.tbxSName.CustomButton.Image = null;
            this.tbxSName.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.tbxSName.CustomButton.Name = "";
            this.tbxSName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbxSName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSName.CustomButton.TabIndex = 1;
            this.tbxSName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSName.CustomButton.UseSelectable = true;
            this.tbxSName.CustomButton.Visible = false;
            this.tbxSName.Lines = new string[0];
            this.tbxSName.Location = new System.Drawing.Point(333, 91);
            this.tbxSName.MaxLength = 32767;
            this.tbxSName.Name = "tbxSName";
            this.tbxSName.PasswordChar = '\0';
            this.tbxSName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSName.SelectedText = "";
            this.tbxSName.SelectionLength = 0;
            this.tbxSName.SelectionStart = 0;
            this.tbxSName.ShortcutsEnabled = true;
            this.tbxSName.Size = new System.Drawing.Size(134, 25);
            this.tbxSName.TabIndex = 6;
            this.tbxSName.UseSelectable = true;
            this.tbxSName.Visible = false;
            this.tbxSName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxSsurname
            // 
            // 
            // 
            // 
            this.tbxSsurname.CustomButton.Image = null;
            this.tbxSsurname.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.tbxSsurname.CustomButton.Name = "";
            this.tbxSsurname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbxSsurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSsurname.CustomButton.TabIndex = 1;
            this.tbxSsurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSsurname.CustomButton.UseSelectable = true;
            this.tbxSsurname.CustomButton.Visible = false;
            this.tbxSsurname.Lines = new string[0];
            this.tbxSsurname.Location = new System.Drawing.Point(333, 122);
            this.tbxSsurname.MaxLength = 32767;
            this.tbxSsurname.Name = "tbxSsurname";
            this.tbxSsurname.PasswordChar = '\0';
            this.tbxSsurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSsurname.SelectedText = "";
            this.tbxSsurname.SelectionLength = 0;
            this.tbxSsurname.SelectionStart = 0;
            this.tbxSsurname.ShortcutsEnabled = true;
            this.tbxSsurname.Size = new System.Drawing.Size(134, 25);
            this.tbxSsurname.TabIndex = 7;
            this.tbxSsurname.UseSelectable = true;
            this.tbxSsurname.Visible = false;
            this.tbxSsurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSsurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxSusername
            // 
            // 
            // 
            // 
            this.tbxSusername.CustomButton.Image = null;
            this.tbxSusername.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.tbxSusername.CustomButton.Name = "";
            this.tbxSusername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbxSusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSusername.CustomButton.TabIndex = 1;
            this.tbxSusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSusername.CustomButton.UseSelectable = true;
            this.tbxSusername.CustomButton.Visible = false;
            this.tbxSusername.Lines = new string[0];
            this.tbxSusername.Location = new System.Drawing.Point(333, 153);
            this.tbxSusername.MaxLength = 32767;
            this.tbxSusername.Name = "tbxSusername";
            this.tbxSusername.PasswordChar = '\0';
            this.tbxSusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSusername.SelectedText = "";
            this.tbxSusername.SelectionLength = 0;
            this.tbxSusername.SelectionStart = 0;
            this.tbxSusername.ShortcutsEnabled = true;
            this.tbxSusername.Size = new System.Drawing.Size(134, 25);
            this.tbxSusername.TabIndex = 8;
            this.tbxSusername.UseSelectable = true;
            this.tbxSusername.Visible = false;
            this.tbxSusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxSemail
            // 
            // 
            // 
            // 
            this.tbxSemail.CustomButton.Image = null;
            this.tbxSemail.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.tbxSemail.CustomButton.Name = "";
            this.tbxSemail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbxSemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSemail.CustomButton.TabIndex = 1;
            this.tbxSemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSemail.CustomButton.UseSelectable = true;
            this.tbxSemail.CustomButton.Visible = false;
            this.tbxSemail.Lines = new string[0];
            this.tbxSemail.Location = new System.Drawing.Point(333, 185);
            this.tbxSemail.MaxLength = 32767;
            this.tbxSemail.Name = "tbxSemail";
            this.tbxSemail.PasswordChar = '\0';
            this.tbxSemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSemail.SelectedText = "";
            this.tbxSemail.SelectionLength = 0;
            this.tbxSemail.SelectionStart = 0;
            this.tbxSemail.ShortcutsEnabled = true;
            this.tbxSemail.Size = new System.Drawing.Size(134, 25);
            this.tbxSemail.TabIndex = 9;
            this.tbxSemail.UseSelectable = true;
            this.tbxSemail.Visible = false;
            this.tbxSemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxSpassword
            // 
            // 
            // 
            // 
            this.tbxSpassword.CustomButton.Image = null;
            this.tbxSpassword.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.tbxSpassword.CustomButton.Name = "";
            this.tbxSpassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbxSpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSpassword.CustomButton.TabIndex = 1;
            this.tbxSpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSpassword.CustomButton.UseSelectable = true;
            this.tbxSpassword.CustomButton.Visible = false;
            this.tbxSpassword.Lines = new string[0];
            this.tbxSpassword.Location = new System.Drawing.Point(333, 216);
            this.tbxSpassword.MaxLength = 32767;
            this.tbxSpassword.Name = "tbxSpassword";
            this.tbxSpassword.PasswordChar = '\0';
            this.tbxSpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSpassword.SelectedText = "";
            this.tbxSpassword.SelectionLength = 0;
            this.tbxSpassword.SelectionStart = 0;
            this.tbxSpassword.ShortcutsEnabled = true;
            this.tbxSpassword.Size = new System.Drawing.Size(134, 25);
            this.tbxSpassword.TabIndex = 10;
            this.tbxSpassword.UseSelectable = true;
            this.tbxSpassword.Visible = false;
            this.tbxSpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(259, 91);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(45, 19);
            this.lblSname.TabIndex = 13;
            this.lblSname.Text = "Name";
            this.lblSname.Visible = false;
            // 
            // lblSsurname
            // 
            this.lblSsurname.AutoSize = true;
            this.lblSsurname.Location = new System.Drawing.Point(259, 122);
            this.lblSsurname.Name = "lblSsurname";
            this.lblSsurname.Size = new System.Drawing.Size(61, 19);
            this.lblSsurname.TabIndex = 14;
            this.lblSsurname.Text = "Surname";
            this.lblSsurname.Visible = false;
            // 
            // lblSusername
            // 
            this.lblSusername.AutoSize = true;
            this.lblSusername.Location = new System.Drawing.Point(259, 153);
            this.lblSusername.Name = "lblSusername";
            this.lblSusername.Size = new System.Drawing.Size(68, 19);
            this.lblSusername.TabIndex = 15;
            this.lblSusername.Text = "Username";
            this.lblSusername.Visible = false;
            // 
            // lblSemail
            // 
            this.lblSemail.AutoSize = true;
            this.lblSemail.Location = new System.Drawing.Point(259, 185);
            this.lblSemail.Name = "lblSemail";
            this.lblSemail.Size = new System.Drawing.Size(41, 19);
            this.lblSemail.TabIndex = 16;
            this.lblSemail.Text = "Email";
            this.lblSemail.Visible = false;
            // 
            // lblSpassword
            // 
            this.lblSpassword.AutoSize = true;
            this.lblSpassword.Location = new System.Drawing.Point(257, 216);
            this.lblSpassword.Name = "lblSpassword";
            this.lblSpassword.Size = new System.Drawing.Size(63, 19);
            this.lblSpassword.TabIndex = 17;
            this.lblSpassword.Text = "Password";
            this.lblSpassword.Visible = false;
            // 
            // lblNewAccount
            // 
            this.lblNewAccount.Location = new System.Drawing.Point(85, 362);
            this.lblNewAccount.Name = "lblNewAccount";
            this.lblNewAccount.Size = new System.Drawing.Size(134, 25);
            this.lblNewAccount.TabIndex = 18;
            this.lblNewAccount.Text = "Dont have an account?";
            this.lblNewAccount.UseSelectable = true;
            this.lblNewAccount.Click += new System.EventHandler(this.lblNewAccount_Click);
            // 
            // Loading
            // 
            this.Loading.Location = new System.Drawing.Point(162, 421);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(224, 23);
            this.Loading.TabIndex = 19;
            this.Loading.Visible = false;
            // 
            // LoadingBox
            // 
            this.LoadingBox.Image = global::GothamChat.Properties.Resources.loading;
            this.LoadingBox.Location = new System.Drawing.Point(162, 158);
            this.LoadingBox.Name = "LoadingBox";
            this.LoadingBox.Size = new System.Drawing.Size(240, 140);
            this.LoadingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoadingBox.TabIndex = 20;
            this.LoadingBox.TabStop = false;
            this.LoadingBox.Visible = false;
            // 
            // ArkhamLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 515);
            this.Controls.Add(this.LoadingBox);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.lblNewAccount);
            this.Controls.Add(this.lblSpassword);
            this.Controls.Add(this.lblSemail);
            this.Controls.Add(this.lblSusername);
            this.Controls.Add(this.lblSsurname);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxSpassword);
            this.Controls.Add(this.tbxSemail);
            this.Controls.Add(this.tbxSusername);
            this.Controls.Add(this.tbxSsurname);
            this.Controls.Add(this.tbxSName);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lLblForgot);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Old English Text MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ArkhamLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Text = "ArkhamLogin";
            this.Load += new System.EventHandler(this.ArkhamLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLink lLblForgot;
        private MetroFramework.Controls.MetroButton btnSignup;
        private MetroFramework.Controls.MetroTextBox tbxUsername;
        private MetroFramework.Controls.MetroTextBox tbxPassword;
        private MetroFramework.Controls.MetroTextBox tbxSName;
        private MetroFramework.Controls.MetroTextBox tbxSsurname;
        private MetroFramework.Controls.MetroTextBox tbxSusername;
        private MetroFramework.Controls.MetroTextBox tbxSemail;
        private MetroFramework.Controls.MetroTextBox tbxSpassword;
        private MetroFramework.Controls.MetroLabel lblSname;
        private MetroFramework.Controls.MetroLabel lblSsurname;
        private MetroFramework.Controls.MetroLabel lblSusername;
        private MetroFramework.Controls.MetroLabel lblSemail;
        private MetroFramework.Controls.MetroLabel lblSpassword;
        private MetroFramework.Controls.MetroLink lblNewAccount;
        private MetroFramework.Controls.MetroProgressBar Loading;
        private System.Windows.Forms.PictureBox LoadingBox;
    }
}