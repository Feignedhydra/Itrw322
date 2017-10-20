namespace GothamChat
{
    partial class GothamChat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GothamChat));
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbxMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.Settings = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelprox = new System.Windows.Forms.Button();
            this.lblPP = new System.Windows.Forms.Label();
            this.btnProxyChange = new System.Windows.Forms.Button();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtProxyUsername = new System.Windows.Forms.TextBox();
            this.lblProxyUsername = new System.Windows.Forms.Label();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.lblproxyAddress = new System.Windows.Forms.Label();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(407, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 20);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxHost
            // 
            this.tbxHost.BackColor = System.Drawing.SystemColors.Window;
            this.tbxHost.Location = new System.Drawing.Point(263, 37);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(80, 20);
            this.tbxHost.TabIndex = 3;
            this.tbxHost.Text = "127.0.0.1";
            // 
            // tbxPort
            // 
            this.tbxPort.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPort.Location = new System.Drawing.Point(349, 37);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(52, 20);
            this.tbxPort.TabIndex = 4;
            this.tbxPort.Text = "8910";
            // 
            // tbxStatus
            // 
            this.tbxStatus.BackColor = System.Drawing.SystemColors.Window;
            this.tbxStatus.Enabled = false;
            this.tbxStatus.Location = new System.Drawing.Point(37, 63);
            this.tbxStatus.MaxLength = 50000000;
            this.tbxStatus.Multiline = true;
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(445, 219);
            this.tbxStatus.TabIndex = 7;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Bat Signal";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tbxMessage
            // 
            // 
            // 
            // 
            this.tbxMessage.CustomButton.Image = null;
            this.tbxMessage.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.tbxMessage.CustomButton.Name = "";
            this.tbxMessage.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.tbxMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxMessage.CustomButton.TabIndex = 1;
            this.tbxMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxMessage.CustomButton.UseSelectable = true;
            this.tbxMessage.CustomButton.Visible = false;
            this.tbxMessage.Lines = new string[0];
            this.tbxMessage.Location = new System.Drawing.Point(37, 314);
            this.tbxMessage.MaxLength = 64;
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.PasswordChar = '\0';
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMessage.SelectedText = "";
            this.tbxMessage.SelectionLength = 0;
            this.tbxMessage.SelectionStart = 0;
            this.tbxMessage.ShortcutsEnabled = true;
            this.tbxMessage.Size = new System.Drawing.Size(445, 81);
            this.tbxMessage.TabIndex = 9;
            this.tbxMessage.UseSelectable = true;
            this.tbxMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(349, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Port:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(263, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Host:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 288);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 0);
            this.lblName.TabIndex = 12;
            this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Settings
            // 
            this.Settings.Image = global::GothamChat.Properties.Resources.Untitled;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Settings.Location = new System.Drawing.Point(37, 401);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(108, 34);
            this.Settings.TabIndex = 13;
            this.Settings.Text = "Proxy";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.BackgroundImage = global::GothamChat.Properties.Resources.Send1;
            this.btnSend.Location = new System.Drawing.Point(488, 288);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(37, 33);
            this.btnSend.TabIndex = 5;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelprox);
            this.panel1.Controls.Add(this.lblPP);
            this.panel1.Controls.Add(this.btnProxyChange);
            this.panel1.Controls.Add(this.txtProxyPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtProxyUsername);
            this.panel1.Controls.Add(this.lblProxyUsername);
            this.panel1.Controls.Add(this.txtProxyAddress);
            this.panel1.Controls.Add(this.lblproxyAddress);
            this.panel1.Location = new System.Drawing.Point(115, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 228);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // btnCancelprox
            // 
            this.btnCancelprox.Location = new System.Drawing.Point(173, 188);
            this.btnCancelprox.Name = "btnCancelprox";
            this.btnCancelprox.Size = new System.Drawing.Size(104, 23);
            this.btnCancelprox.TabIndex = 8;
            this.btnCancelprox.Text = "Cancel";
            this.btnCancelprox.UseVisualStyleBackColor = true;
            this.btnCancelprox.Click += new System.EventHandler(this.btnCancelprox_Click);
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPP.Location = new System.Drawing.Point(21, 14);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(110, 20);
            this.lblPP.TabIndex = 7;
            this.lblPP.Text = "Proxy Settings";
            // 
            // btnProxyChange
            // 
            this.btnProxyChange.Location = new System.Drawing.Point(21, 189);
            this.btnProxyChange.Name = "btnProxyChange";
            this.btnProxyChange.Size = new System.Drawing.Size(109, 23);
            this.btnProxyChange.TabIndex = 6;
            this.btnProxyChange.Text = "Saved Changes";
            this.btnProxyChange.UseVisualStyleBackColor = true;
            this.btnProxyChange.Click += new System.EventHandler(this.btnProxyChange_Click);
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.Location = new System.Drawing.Point(113, 141);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.PasswordChar = '*';
            this.txtProxyPassword.Size = new System.Drawing.Size(169, 20);
            this.txtProxyPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(18, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Proxy Password:";
            // 
            // txtProxyUsername
            // 
            this.txtProxyUsername.Location = new System.Drawing.Point(113, 91);
            this.txtProxyUsername.Name = "txtProxyUsername";
            this.txtProxyUsername.Size = new System.Drawing.Size(169, 20);
            this.txtProxyUsername.TabIndex = 3;
            // 
            // lblProxyUsername
            // 
            this.lblProxyUsername.AutoSize = true;
            this.lblProxyUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProxyUsername.Location = new System.Drawing.Point(18, 94);
            this.lblProxyUsername.Name = "lblProxyUsername";
            this.lblProxyUsername.Size = new System.Drawing.Size(89, 13);
            this.lblProxyUsername.TabIndex = 2;
            this.lblProxyUsername.Text = "Proxy UserName:";
            // 
            // txtProxyAddress
            // 
            this.txtProxyAddress.Location = new System.Drawing.Point(113, 47);
            this.txtProxyAddress.Name = "txtProxyAddress";
            this.txtProxyAddress.Size = new System.Drawing.Size(169, 20);
            this.txtProxyAddress.TabIndex = 1;
            // 
            // lblproxyAddress
            // 
            this.lblproxyAddress.AutoSize = true;
            this.lblproxyAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblproxyAddress.Location = new System.Drawing.Point(18, 47);
            this.lblproxyAddress.Name = "lblproxyAddress";
            this.lblproxyAddress.Size = new System.Drawing.Size(77, 13);
            this.lblproxyAddress.TabIndex = 0;
            this.lblproxyAddress.Text = "Proxy Address:";
            this.lblproxyAddress.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(23, 285);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GothamChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 442);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.tbxHost);
            this.Controls.Add(this.btnConnect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GothamChat";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "GothamChat";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.GothamChat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroTextBox tbxMessage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblName;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelprox;
        private System.Windows.Forms.Label lblPP;
        private System.Windows.Forms.Button btnProxyChange;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtProxyUsername;
        private System.Windows.Forms.Label lblProxyUsername;
        private System.Windows.Forms.TextBox txtProxyAddress;
        private System.Windows.Forms.Label lblproxyAddress;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

