using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("哈哈");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBox3.Text);
                b = Int32.Parse(textBox4.Text);
            }
            catch (System.FormatException)

            {
                MessageBox.Show("給我數字!");
                a = 0;
                b = 0;
              
            }
            label2.Text = (a + b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(textBox6.Text);
            int d = Int32.Parse(textBox5.Text);
            label7.Text = (c - d).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int f = Int32.Parse(textBox8.Text);
            int g = Int32.Parse(textBox7.Text);
            label10.Text = (f * g).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int h = Int32.Parse(textBox10.Text);
            int i = Int32.Parse(textBox9.Text);
            label13.Text = (h / i).ToString();
        }
    }
}
