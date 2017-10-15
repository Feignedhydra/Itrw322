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
    public partial class GothamChat : Form
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
            string name = tbxName.Text;
            
        }
        
        
        
        private void GChat_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to tbxStatus
            tbxStatus.Invoke((MethodInvoker)delegate ()
            {
                if ((e.MessageString) == tbxName.Text + " said: " + tbxMessage.Text + "")
                {
                    tbxStatus.Text += "You said: " + tbxMessage.Text + "\r\n";
                    tbxMessage.Clear();
                    tbxStatus.SelectionStart = tbxStatus.Text.Length;
                    tbxStatus.ScrollToCaret();
                }
                else
                {
                    tbxStatus.Text += e.MessageString.Remove(e.MessageString.Length -1) + "\r\n";
                }

               
               
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            gChat.WriteLine(tbxName.Text + " said: " + tbxMessage.Text);
            
         
        }
    }
}
