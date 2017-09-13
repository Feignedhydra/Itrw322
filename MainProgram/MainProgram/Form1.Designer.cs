namespace MainProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrikus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWikus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWerner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChantel = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 307);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 33);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(12, 27);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(472, 274);
            this.rtbChat.TabIndex = 1;
            this.rtbChat.Text = "You: Hello \nDrikus: Yes, Whats up?\nYou: Nie veel nie en daar?\nDrikus: Stil en rus" +
    "tig\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 20);
            this.textBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDrikus,
            this.tsmiWikus,
            this.tsmiWerner,
            this.tsmiChantel});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "Chats";
            // 
            // tsmiDrikus
            // 
            this.tsmiDrikus.Name = "tsmiDrikus";
            this.tsmiDrikus.Size = new System.Drawing.Size(152, 22);
            this.tsmiDrikus.Text = "Drikus";
            this.tsmiDrikus.Click += new System.EventHandler(this.tsmiDrikus_Click);
            // 
            // tsmiWikus
            // 
            this.tsmiWikus.Name = "tsmiWikus";
            this.tsmiWikus.Size = new System.Drawing.Size(152, 22);
            this.tsmiWikus.Text = "Wikus";
            this.tsmiWikus.Click += new System.EventHandler(this.wikusToolStripMenuItem_Click);
            // 
            // tsmiWerner
            // 
            this.tsmiWerner.Name = "tsmiWerner";
            this.tsmiWerner.Size = new System.Drawing.Size(152, 22);
            this.tsmiWerner.Text = "Werner";
            // 
            // tsmiChantel
            // 
            this.tsmiChantel.Name = "tsmiChantel";
            this.tsmiChantel.Size = new System.Drawing.Size(152, 22);
            this.tsmiChantel.Text = "Chantel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 352);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrikus;
        private System.Windows.Forms.ToolStripMenuItem tsmiWikus;
        private System.Windows.Forms.ToolStripMenuItem tsmiWerner;
        private System.Windows.Forms.ToolStripMenuItem tsmiChantel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

