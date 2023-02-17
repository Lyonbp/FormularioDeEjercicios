using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c, mayor;

            a = Convert.ToInt32(txtn1.Text);
            b = Convert.ToInt32(txtn2.Text);
            c = Convert.ToInt32(txtn3.Text);

            if (a > b && a > c)
                mayor = a;
            else if (b > c)
                mayor = b;
            else
                mayor = c;

            txtresultado.Text = Convert.ToString(mayor);
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            int a, b, c, multiplicacion;
            a = Convert.ToInt32(txtn1.Text);
            b = Convert.ToInt32(txtn2.Text);
            c = Convert.ToInt32(txtn3.Text);

            multiplicacion = a * b * c;

            txtresultado.Text = Convert.ToString(multiplicacion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, suma;
            a = Convert.ToInt32(txtn1.Text);
            b = Convert.ToInt32(txtn2.Text);
            c = Convert.ToInt32(txtn3.Text);

            suma = a + b + c;

            txtresultado.Text = Convert.ToString(suma);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a, b, c, menor;

            a = Convert.ToInt32(txtn1.Text);
            b = Convert.ToInt32(txtn2.Text);
            c = Convert.ToInt32(txtn3.Text);

            if (a < b && a < c)
                menor = a;
            else if (b < c)
                menor = b;
            else
                menor = c;

            txtresultado.Text = Convert.ToString(menor);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
