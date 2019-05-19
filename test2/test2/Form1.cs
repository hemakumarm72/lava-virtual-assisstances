using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AIMLbot;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axActiveHaptekX1.HyperText = @"\load [file= standardstartup.hap]";

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bot ai = new Bot(); // the named our bot this code
            ai.loadSettings(); // write this code you will load setting frame
            ai.loadAIMLFromFiles(); // with this code you will load aiml files into your project
            ai.isAcceptingUserInput = false; //write the help of 
            User myuser = new User("Larva", ai );
            ai.isAcceptingUserInput = true;
            Request r = new Request(textBox1.Text, myuser, ai);
            Result res = ai.Chat(r);
            textBox2.Text =  res.Output;
            axActiveHaptekX1.HyperText = @"\speak [string= ["+textBox2.Text+"]]";


        }
    }
}
