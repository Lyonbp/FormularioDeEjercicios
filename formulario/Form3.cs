using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int total;
            int n = Convert.ToInt32(txtllantas.Text);

            if (n < 5)
            {
                total = (n * 300);
                label4.Text = Convert.ToString(300);
                label5.Text = Convert.ToString(total);
            }

            else if (n <= 10)
            {
                total = (n * 250);
                label4.Text = Convert.ToString(250);
                label5.Text = Convert.ToString(total);
            }

            else
            {
                total = (n * 200);
                label4.Text = Convert.ToString(200);
                label5.Text = Convert.ToString(total);
            }
        }
    }
}
