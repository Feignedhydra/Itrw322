using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleTCP;


namespace webchat
{
    public partial class ChatHome : System.Web.UI.Page
    {
        SimpleTcpClient gchat;
        protected void Page_Load(object sender, EventArgs e)
        {
            gchat = new SimpleTcpClient();
            gchat.StringEncoder = Encoding.UTF8;
            gchat.DataReceived += Gchat_DataReceived;
            string name = TextBox4.Text;


        }

        private void Gchat_DataReceived(object sender, Message e)
        {
            TextBox5.
          
        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Enabled = false;
            gchat.Connect(TextBox1.Text, Convert.ToInt32(TextBox2.Text));


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            gchat.WriteLine(TextBox4.Text + " said: " + TextBox3.Text);
        }
    }
}