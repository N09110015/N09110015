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

namespace WindowsFormsApp1
{
    public partial class Form100 : Form
    {
        string food, drink;

        public Form100()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,鹹食,甜食\n", Encoding.UTF8);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        food = food + ((CheckBox)c).Text + " ";
                    }
                }
            }

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        drink = drink + ((CheckBox)c).Text + " ";
                    }
                }
            }

            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm");
            File.AppendAllText("OrderData.csv", formattedDateTime + "," + food + "," + drink + "\n", Encoding.UTF8);

            MessageBox.Show("鹹食：" + food + Environment.NewLine + "甜食：" + drink);

            food = string.Empty;
            drink = string.Empty;

            //畢業萬歲
        }

    }
}
