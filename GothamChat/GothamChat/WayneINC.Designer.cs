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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.powerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutDownToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.wakeToolStripMenuItem});
            this.powerToolStripMenuItem.Image = global::GothamChat.Properties.Resources.power1;
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.powerToolStripMenuItem.Text = "Power";
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.shutDownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowToolStripMenuItem,
            this.secToolStripMenuItem,
            this.secToolStripMenuItem1,
            this.minToolStripMenuItem});
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shutDownToolStripMenuItem.Text = "Shut Down";
            // 
            // nowToolStripMenuItem
            // 
            this.nowToolStripMenuItem.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.nowToolStripMenuItem.Name = "nowToolStripMenuItem";
            this.nowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nowToolStripMenuItem.Text = "Now";
            this.nowToolStripMenuItem.Click += new System.EventHandler(this.nowToolStripMenuItem_Click);
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.secToolStripMenuItem.Text = "10 Sec";
            this.secToolStripMenuItem.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // secToolStripMenuItem1
            // 
            this.secToolStripMenuItem1.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.secToolStripMenuItem1.Name = "secToolStripMenuItem1";
            this.secToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.secToolStripMenuItem1.Text = "30 Sec";
            this.secToolStripMenuItem1.Click += new System.EventHandler(this.secToolStripMenuItem1_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem.Text = "5 Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowToolStripMenuItem1,
            this.secToolStripMenuItem2,
            this.secToolStripMenuItem3,
            this.minToolStripMenuItem1});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // nowToolStripMenuItem1
            // 
            this.nowToolStripMenuItem1.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.nowToolStripMenuItem1.Name = "nowToolStripMenuItem1";
            this.nowToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.nowToolStripMenuItem1.Text = "Now";
            this.nowToolStripMenuItem1.Click += new System.EventHandler(this.nowToolStripMenuItem1_Click);
            // 
            // secToolStripMenuItem2
            // 
            this.secToolStripMenuItem2.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.secToolStripMenuItem2.Name = "secToolStripMenuItem2";
            this.secToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.secToolStripMenuItem2.Text = "10 Sec";
            this.secToolStripMenuItem2.Click += new System.EventHandler(this.secToolStripMenuItem2_Click);
            // 
            // secToolStripMenuItem3
            // 
            this.secToolStripMenuItem3.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.secToolStripMenuItem3.Name = "secToolStripMenuItem3";
            this.secToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.secToolStripMenuItem3.Text = "30 Sec";
            this.secToolStripMenuItem3.Click += new System.EventHandler(this.secToolStripMenuItem3_Click);
            // 
            // minToolStripMenuItem1
            // 
            this.minToolStripMenuItem1.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.minToolStripMenuItem1.Name = "minToolStripMenuItem1";
            this.minToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem1.Text = "5 Min";
            this.minToolStripMenuItem1.Click += new System.EventHandler(this.minToolStripMenuItem1_Click);
            // 
            // wakeToolStripMenuItem
            // 
            this.wakeToolStripMenuItem.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.wakeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secToolStripMenuItem4,
            this.minToolStripMenuItem2,
            this.minToolStripMenuItem3,
            this.minToolStripMenuItem4});
            this.wakeToolStripMenuItem.Name = "wakeToolStripMenuItem";
            this.wakeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wakeToolStripMenuItem.Text = "Wake";
            // 
            // secToolStripMenuItem4
            // 
            this.secToolStripMenuItem4.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.secToolStripMenuItem4.Name = "secToolStripMenuItem4";
            this.secToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.secToolStripMenuItem4.Text = "10 Sec";
            this.secToolStripMenuItem4.Click += new System.EventHandler(this.secToolStripMenuItem4_Click);
            // 
            // minToolStripMenuItem2
            // 
            this.minToolStripMenuItem2.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.minToolStripMenuItem2.Name = "minToolStripMenuItem2";
            this.minToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem2.Text = "1 Min";
            // 
            // minToolStripMenuItem3
            // 
            this.minToolStripMenuItem3.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.minToolStripMenuItem3.Name = "minToolStripMenuItem3";
            this.minToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem3.Text = "5 Min";
            // 
            // minToolStripMenuItem4
            // 
            this.minToolStripMenuItem4.BackgroundImage = global::GothamChat.Properties.Resources._1;
            this.minToolStripMenuItem4.Name = "minToolStripMenuItem4";
            this.minToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem4.Text = "10 Min";
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WayneINC";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "WayneINC";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem4;
    }
}