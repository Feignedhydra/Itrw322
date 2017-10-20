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
using System.Security.Cryptography;
using System.Net;
using Microsoft.VisualBasic;
using System.IO;
namespace GothamChat
{
    public partial class GothamChat : MetroFramework.Forms.MetroForm
    {
        
        public GothamChat(string name)
        {
            InitializeComponent();
            lblName.Text = name;
            
        }

        public string encryption, decryption;
        public string proxyAdress = "http://cache3.p.nwu.ac.za:80/",
            proxyUsername = "26903202", proxyPassword = "bla";
        SimpleTcpClient gChat;
        string hash = "f0xle@rn";



        private void btnConnect_Click(object sender, EventArgs e)
        {   
            btnConnect.Enabled = false;

            WebProxy Proxy = new WebProxy(proxyAdress, true);
            Proxy.Credentials = new NetworkCredential(proxyUsername,proxyPassword );
            WebRequest req = WebRequest.Create("http://www.contoso.com");
            req.Proxy = Proxy;
            //Connect to gsServer
            gChat.Connect(tbxHost.Text, Convert.ToInt32(tbxPort.Text));
        }

      
        private void GothamChat_Load(object sender, EventArgs e)
        {
            gChat = new SimpleTcpClient();
            gChat.StringEncoder = Encoding.UTF8;
            gChat.DataReceived += GChat_DataReceived; 
        }

        #region Send & Receive
        private void GChat_DataReceived(object sender, SimpleTCP.Message e)
        {
            tbxStatus.Invoke((MethodInvoker)delegate ()
            {


                if ((e.MessageString) == encryption + "")
                {
                    encryption = e.MessageString.Remove(e.MessageString.Length - 1);
                    decrypt(encryption);
                    if ((decryption) == (lblName.Text + " said: " + tbxMessage.Text))
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
                        tbxStatus.Text += decryption.Remove(0, 7) + "\r\n";
                        tbxStatus.SelectionStart = tbxStatus.Text.Length;
                        tbxStatus.ScrollToCaret();
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            this.Hide();
                            notifyIcon1.ShowBalloonTip(1000, "Bat Signal Activated", "You Have New Messages", ToolTipIcon.Info);
                        }
                    }
                }
                else
                {
                    encryption = e.MessageString.Remove(e.MessageString.Length - 1);
                    decrypt(encryption);

                    if ((decryption) == (lblName.Text + " said: " + tbxMessage.Text))
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
                        tbxStatus.Text += decryption.Remove(0,7) + "\r\n";
                        tbxStatus.SelectionStart = tbxStatus.Text.Length;
                        tbxStatus.ScrollToCaret();
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            this.Hide();
                            notifyIcon1.ShowBalloonTip(1000, "Bat Signal Activated", "You Have New Messages", ToolTipIcon.Info);
                        }
                    }
                }
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            encrypt(lblName.Text + " said: " + tbxMessage.Text);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtProxyAddress.Text = proxyAdress;
            txtProxyUsername.Text = proxyUsername;
            txtProxyPassword.Text = proxyPassword;
        }

        private void btnProxyChange_Click(object sender, EventArgs e)
        {
            proxyAdress = txtProxyAddress.Text;
            proxyUsername = txtProxyUsername.Text;
            proxyPassword = txtProxyPassword.Text;
            panel1.Visible = false;
        }

        private void btnCancelprox_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // method 1
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(reader.ReadToEnd());
                string message = reader.ReadToEnd();
                tbxMessage.Text = message;
                gChat.WriteLine(message);
            }
        }
        #region encryption and decryption
        public void encrypt(string msg)
        {
            Boolean encr = false;
            if (encr == false)
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(msg);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        msg = Convert.ToBase64String(results, 0, results.Length);
                        encr = true;
                        encryption = msg;
                    }
                }
            }

            if (encr == true)
            {
                gChat.WriteLine(msg);

            }
            else
            {
                MessageBox.Show("Encryption Failed");
            }
        }

        public void decrypt(string msg)
        {
            byte[] data = Convert.FromBase64String(msg);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    decryption = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
        #endregion
#endregion
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        
        }
    }
}
