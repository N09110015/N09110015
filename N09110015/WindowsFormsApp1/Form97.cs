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
    public partial class Form97 : Form
    {
        int min = 0, max = 100;
        int answer;
        public Form97()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Random r = new Random();
            this.answer = r.Next(100);
            MessageBox.Show(answer.ToString());
            label1.Text = answer.ToString();
            label1.Text = "以隨機產生0~100,請在下面作答";
            label2.Text = string.Format("請輸入{0}~{1}之間的數值,min,max");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    int input = Int32.Parse(textBox1.Text);
                if(input== this.answer)
                {
                    MessageBox.Show("恭喜答對");

                }
                else if(input< this.answer)
                {

                }

            }
        }
    }
}
