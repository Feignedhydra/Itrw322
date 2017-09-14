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

        //add var to keep track of what chat is open.
        private string currentChat = null;
        private string previousChat = null;


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void wikusToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tsmiWikus.Select();
            previousChat = currentChat;
            setCurrentChat();

            string lines = rtbChat.Text;
            
            // Write the string to a file.
            StreamWriter file = new System.IO.StreamWriter("G:\\Chats\\" + previousChat  + ".txt");
            file.WriteLine(lines);

            file.Close();

            rtbChat.Clear();

           // MessageBox.Show("Current: " + currentChat + "\nPrevious: " + previousChat);

            //open Chat
            rtbChat.Text = File.ReadAllText(@"G:\\Chats\\"+ currentChat + ".txt");
        }

        private void tsmiDrikus_Click(object sender, EventArgs e)
        {
  
            string lines = rtbChat.Text;

            // Write the string to a file.
            StreamWriter file = new System.IO.StreamWriter("G:\\Chats\\" + currentChat + ".txt");
            file.WriteLine(lines);
            file.Close();

            rtbChat.Clear();

            //open Chat

            tsmiDrikus.Select();
            setCurrentChat();
             rtbChat.Text = File.ReadAllText(@"G:\Chats\Drikus.txt");
           
        }


        private void tsmiWerner_Click(object sender, EventArgs e)
        {
            tsmiWerner.Select();
            previousChat = currentChat;
            setCurrentChat();

            // can write method to save and display text.
            string lines = rtbChat.Text;

            // Write the string to a file.
            //need to set better or specific path faor chat saves.
            StreamWriter file = new StreamWriter("G:\\Chats\\" + previousChat + ".txt");
            file.WriteLine(lines);

            file.Close();

            rtbChat.Clear();

            // MessageBox.Show("Current: " + currentChat + "\nPrevious: " + previousChat);

            //open Chat
            rtbChat.Text = File.ReadAllText(@"G:\\Chats\\" + currentChat + ".txt");
        }

        

        public void setCurrentChat()
        {
            //need to change hard coded chat options.
            //tsmi* will probably be set to ToolStripMenuItem1 with names generated from protocol
            if (tsmiDrikus.Selected == true)
            {
                currentChat = tsmiDrikus.Text;
            }
            else if (tsmiWikus.Selected == true)
            {
                currentChat = tsmiWikus.Text;
            }
            else if (tsmiWerner.Selected == true)
            {
                currentChat = tsmiWerner.Text;
            }
            else if (tsmiChantel.Selected == true)
            {
                currentChat = tsmiChantel.Text;
            }
        }

        private void tsmiChantel_Click_1(object sender, EventArgs e)
        {
            
                tsmiChantel.Select();
                previousChat = currentChat;
                setCurrentChat();

                string lines = rtbChat.Text;

                // Write the string to a file.
                StreamWriter file = new StreamWriter("G:\\Chats\\" + previousChat + ".txt");
                file.WriteLine(lines);

                file.Close();

                rtbChat.Clear();

                //MessageBox.Show("Current: " + currentChat + "\nPrevious: " + previousChat);

                //open Chat
                rtbChat.Text = File.ReadAllText(@"G:\\Chats\\" + currentChat + ".txt");
            
        }
    }
}
