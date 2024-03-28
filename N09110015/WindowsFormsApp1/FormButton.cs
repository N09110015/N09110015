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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text =="欸戳我一下") 
            button1.Text = "白癡ㄛ快按回去";
           else if (button1.Text =="白癡ㄛ快按回去")
            button1.Text = "欸戳我一下";
        }


        private void btmAdd_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(labCount.Text);
            count = count+1;
            labCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(labCount.Text);
            count = count-1;
            labCount.Text = count.ToString();
        }
    }
}
