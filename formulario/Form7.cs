using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
