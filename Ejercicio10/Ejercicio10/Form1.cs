using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
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

        private void button1_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
