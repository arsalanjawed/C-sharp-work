using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testscore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1;
            s1 = (textBox1.Text);
            string s2;
            s2 = (textBox2.Text);
            string s3;
            s3 = (textBox3.Text);

            string s4;
            s4 = (textBox4.Text);
            string s5;
            s5 = (textBox5.Text);

            double avg =(Convert.ToDouble(s1)+Convert.ToDouble(s2)+Convert.ToDouble(s3)+Convert.ToDouble(s4)+Convert.ToDouble(s5))/5;
            textBox8.Text= Convert.ToString(avg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox8.Clear();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }
    }
}
