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

namespace GothamServer
{
    public partial class GothamServer : Form
    {
        public GothamServer()
        {
            InitializeComponent();
        }
        
        SimpleTcpServer gServer;
        
        private void GothamServer_Load(object sender, EventArgs e)
        {
            gServer = new SimpleTcpServer();
            gServer.Delimiter = 0x13;//enter
            gServer.StringEncoder = Encoding.UTF8;
            gServer.DataReceived += GServer_DataReceived;

        }

        
        
        public void GServer_DataReceived(object sender, SimpleTCP.Message e)
        {
            
            //Update message to tbxStatus
            tbxStatus.Invoke((MethodInvoker)delegate ()
            {

                tbxStatus.Text += "\n" + e.MessageString;
                
                gServer.BroadcastLine(string.Format("{0}",e.MessageString));
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start server host
            tbxStatus.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(tbxHost.Text);
            gServer.Start(ip, Convert.ToInt32(tbxPort.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (gServer.IsStarted)
                gServer.Stop();
        }

        private void btnHowmany_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(gServer.ConnectedClientsCount));
            
           
        }
    }
}
