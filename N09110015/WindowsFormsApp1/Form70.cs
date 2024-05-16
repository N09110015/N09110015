using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form70 : Form
    {

        public Form70()
        {
            InitializeComponent();

        }

        int sec = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "金罵喜"+sec.ToString() + "秒";
            this.sec++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.sec = 0;
            label1.Text = "0秒";
        }
    }
}
