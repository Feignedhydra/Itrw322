using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace MainProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fileName;
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void wikusToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //add var to keep track of what chat is open.


            // Compose a string that consists of three lines.
            string lines = rtbChat.Text;
            
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("E:\\Chats\\" + tsmiDrikus.Text + ".txt");
            file.WriteLine(lines);

            file.Close();
        }

        private void tsmiDrikus_Click(object sender, EventArgs e)
        {
        
             rtbChat.Text = System.IO.File.ReadAllText(@"E:\Chats\Drikus.txt");
           
        }
    }
}
