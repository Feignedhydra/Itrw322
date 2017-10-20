using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Threading;


namespace GothamChat
{
    public partial class WayneINC : MetroFramework.Forms.MetroForm
    {
        public WayneINC(string name)
        {
            InitializeComponent();
            lblName.Text = "Welcome " + name;
            
            
        }
        
        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void tlChat_Click(object sender, EventArgs e)
        {
            GothamChat chat = new GothamChat(lblName.Text);
            chat.Show();
        }

        private void tlEmail_Click(object sender, EventArgs e)
        {
            Emails email = new Emails();
            email.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArkhamLogin logout = new ArkhamLogin();
            logout.Show();
        }

        private void nowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 10");
        }

        private void secToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 30");
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 300");
        }

        private void nowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void secToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 10");
        }

        private void secToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 30");
        }

        private void minToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 300");
        }

        private void secToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            WakeUP wup = new WakeUP();
            long delay = 1;
            wup.SetWakeUpDelay(-1 * delay * 10000000);
            //RunCmd("rundll32 powrprof.dll,SetSuspendState");
            Application.SetSuspendState(PowerState.Suspend, false, false);

        }


    }
}
