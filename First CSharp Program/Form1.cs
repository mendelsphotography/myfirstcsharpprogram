using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_CSharp_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a = "Welomce to My First C# Program";
            string title = "Welcome ";
            MessageBox.Show(a, title);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void UpdateTime()
        {
            label1.Text = DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes + "." + DateTime.Now.TimeOfDay.Seconds;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = "Plese Email Youre Feedback To you@gmail.com ";
            string title = "Feedback";
            MessageBox.Show(a, title);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
