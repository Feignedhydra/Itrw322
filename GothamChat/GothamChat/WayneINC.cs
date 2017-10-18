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
            GothamChat chat = new GothamChat();
            chat.Show();
        }

        
    }
}
