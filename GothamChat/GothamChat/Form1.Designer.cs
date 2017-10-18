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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbxMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
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
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(407, 288);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 20);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxStatus
            // 
            this.tbxStatus.BackColor = System.Drawing.SystemColors.Window;
            this.tbxStatus.Enabled = false;
            this.tbxStatus.Location = new System.Drawing.Point(37, 63);
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
            this.tbxMessage.MaxLength = 32767;
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
            // 
            // GothamChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 418);
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
    }
}

