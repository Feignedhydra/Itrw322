using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using S22.Imap;
namespace GothamChat
{
    public partial class Emails : MetroFramework.Forms.MetroForm
    {
        static Emails f;
        public Emails()
        {
            InitializeComponent();
            f = this;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                var message = new MailMessage(tbxEmail.Text, tbxTo.Text);
                var plainView = AlternateView.CreateAlternateViewFromString(tbxBody.Text, null, "text/plain");
                message.Subject = tbxSubject.Text;
                //message.Body = edtBody.Text;
                message.AlternateViews.Add(plainView);

                using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                {
                    mailer.Credentials = new NetworkCredential(tbxEmail.Text, tbxPassword.Text);
                    mailer.EnableSsl = true;
                    mailer.Send(message);
                };

                // edtSubject.Text = null;
                // edtBody.Text = null;
                // edtTo.Text = null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void StartRecieving()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, tbxEmail.Text,
                    tbxPassword.Text, AuthMethod.Login, true))
                {
                    if (client.Supports("IDLE") == false)
                    {
                        MessageBox.Show("Server does not Support IMAP IDLE");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNewMessage);
                    while (true) ;
                }
            });
        }
        static void OnNewMessage(object sender, IdleMessageEventArgs e)
        {
            MessageBox.Show("New Message Recieved");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            f.Invoke((MethodInvoker)delegate
            {
                f.redtRecieve.AppendText("From: " + m.From + "\n" +
                                        "Subject: " + m.Subject + "\n" +
                                        "Body: " + m.Body + "\n\n"
                                        );
            });
        }

        private void Emails_Load(object sender, EventArgs e)
        {
            StartRecieving();
        }
    }
}
