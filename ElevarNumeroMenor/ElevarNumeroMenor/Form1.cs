using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevarNumeroMenor
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res;
            int num1 = Convert.ToInt32(txtn1.Text);
            int num2 = Convert.ToInt32(txtn2.Text);
            if (num1 > num2)
            {

                res = (int)Math.Pow(num1, num2);
            }
            else
            {
                res = (int)Math.Pow(num2, num1);
            }
            label4.Text = res.ToString();
        }
    }
}
