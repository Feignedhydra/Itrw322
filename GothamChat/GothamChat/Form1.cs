using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GothamChat
{
    public partial class GothamChat : MetroFramework.Forms.MetroForm
    {
        public GothamChat()
        {
            InitializeComponent();
        }
        
        SimpleTcpClient gChat;
        
        
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            
            //Connect to gsServer
            gChat.Connect(tbxHost.Text, Convert.ToInt32(tbxPort.Text));
        }

        private void GothamChat_Load(object sender, EventArgs e)
        {
            gChat = new SimpleTcpClient();
            gChat.StringEncoder = Encoding.UTF8;
            gChat.DataReceived += GChat_DataReceived;
            
        }

        public void Gname(string name)
        {
            lblName.Text = name;
        }

        #region Send & Receive
        private void GChat_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to tbxStatus
            tbxStatus.Invoke((MethodInvoker)delegate ()
            {
                

                if ((e.MessageString) == lblName.Text + " said: " + tbxMessage.Text + "")
                {
                    tbxStatus.Text += "You said: " + tbxMessage.Text + "\r\n";
                    tbxMessage.Clear();
                    tbxStatus.SelectionStart = tbxStatus.Text.Length;
                    tbxStatus.ScrollToCaret();
                  
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, "Bat Signal Activated", "You Have New Messages", ToolTipIcon.Info);
                    }
                }
                else
                {
                    tbxStatus.Text += e.MessageString.Remove(e.MessageString.Length -1) + "\r\n";
                    tbxStatus.SelectionStart = tbxStatus.Text.Length;
                    tbxStatus.ScrollToCaret();
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                         this.Hide();
                         notifyIcon1.ShowBalloonTip(1000, "Bat Signal Activated", "You Have New Messages", ToolTipIcon.Info);
                    }
                }

               


            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            gChat.WriteLine(lblName.Text + " said: " + tbxMessage.Text);
        }
        #endregion
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        
        }
    }
}
