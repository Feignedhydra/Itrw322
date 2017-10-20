namespace GothamChat
{
    partial class WayneINC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WayneINC));
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.tlAccount = new MetroFramework.Controls.MetroTile();
            this.tlEmail = new MetroFramework.Controls.MetroTile();
            this.tlCalendar = new MetroFramework.Controls.MetroTile();
            this.tlChat = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblName.Location = new System.Drawing.Point(231, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(501, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(81, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tlAccount
            // 
            this.tlAccount.ActiveControl = null;
            this.tlAccount.Location = new System.Drawing.Point(148, 218);
            this.tlAccount.Name = "tlAccount";
            this.tlAccount.Size = new System.Drawing.Size(155, 103);
            this.tlAccount.Style = MetroFramework.MetroColorStyle.Black;
            this.tlAccount.TabIndex = 3;
            this.tlAccount.Text = "Account";
            this.tlAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlAccount.TileImage = global::GothamChat.Properties.Resources.signal2;
            this.tlAccount.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlAccount.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tlAccount.UseSelectable = true;
            this.tlAccount.UseTileImage = true;
            // 
            // tlEmail
            // 
            this.tlEmail.ActiveControl = null;
            this.tlEmail.Location = new System.Drawing.Point(310, 218);
            this.tlEmail.Name = "tlEmail";
            this.tlEmail.Size = new System.Drawing.Size(164, 103);
            this.tlEmail.Style = MetroFramework.MetroColorStyle.Black;
            this.tlEmail.TabIndex = 2;
            this.tlEmail.TileImage = global::GothamChat.Properties.Resources.Batmail;
            this.tlEmail.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlEmail.UseSelectable = true;
            this.tlEmail.UseTileImage = true;
            this.tlEmail.Click += new System.EventHandler(this.tlEmail_Click);
            // 
            // tlCalendar
            // 
            this.tlCalendar.ActiveControl = null;
            this.tlCalendar.Location = new System.Drawing.Point(310, 121);
            this.tlCalendar.Name = "tlCalendar";
            this.tlCalendar.Size = new System.Drawing.Size(164, 91);
            this.tlCalendar.TabIndex = 1;
            this.tlCalendar.Text = "Calendar";
            this.tlCalendar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tlCalendar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tlCalendar.TileImage = global::GothamChat.Properties.Resources.Email2;
            this.tlCalendar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tlCalendar.UseSelectable = true;
            this.tlCalendar.UseTileImage = true;
            this.tlCalendar.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // tlChat
            // 
            this.tlChat.ActiveControl = null;
            this.tlChat.BackColor = System.Drawing.Color.White;
            this.tlChat.Location = new System.Drawing.Point(148, 121);
            this.tlChat.Name = "tlChat";
            this.tlChat.Size = new System.Drawing.Size(155, 91);
            this.tlChat.TabIndex = 0;
            this.tlChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlChat.TileImage = global::GothamChat.Properties.Resources.Logo2;
            this.tlChat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlChat.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tlChat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tlChat.UseSelectable = true;
            this.tlChat.UseTileImage = true;
            this.tlChat.Click += new System.EventHandler(this.tlChat_Click);
            // 
            // WayneINC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(605, 413);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tlAccount);
            this.Controls.Add(this.tlEmail);
            this.Controls.Add(this.tlCalendar);
            this.Controls.Add(this.tlChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WayneINC";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "WayneINC";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tlChat;
        private MetroFramework.Controls.MetroTile tlCalendar;
        private MetroFramework.Controls.MetroTile tlEmail;
        private MetroFramework.Controls.MetroTile tlAccount;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}