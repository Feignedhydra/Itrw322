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
        }

        private void GChat_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to tbxStatus
            tbxStatus.Invoke((MethodInvoker)delegate ()
            {
                tbxStatus.Text += e.MessageString;
              
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            gChat.WriteLineAndGetReply(tbxMessage.Text, TimeSpan.FromSeconds(1));
        }
    }
}
