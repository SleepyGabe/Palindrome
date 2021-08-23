using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTFI1B_Parinas_Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            //Main Input: Recieve word input from user and determine if it's a palindrome or not.
            //1.) Declare variables for the Word Input and the reversed word
            string WordIn, RevWord = "";

            //2.) retrieve user's input
            WordIn = word1.Text;
            //3.) Use For loop to reverse the input
            for (int i = WordIn.Length - 1; i >= 0; i--)
            {
                RevWord += WordIn[i].ToString();
            }
            //4.) Check if reversed string matches original input
            //4.1) Output "Palindrome" to user if condition is met
            if (RevWord == WordIn)
            {
                TxtOut.Text = "Pendelum";
            }
            //4.2) Output "not palindrome" to user if condition is not met
            else
            {
                TxtOut.Text = "Not a Pendelum";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
