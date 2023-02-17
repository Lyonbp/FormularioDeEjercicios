using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtganado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int puntos;
            int G = Convert.ToInt32(txtganado.Text);
            int E = Convert.ToInt32(txtempatado.Text);
            int P = Convert.ToInt32(txtperdido.Text);

            puntos = (G * 3) + E;

            label6.Text = puntos.ToString();
        }
    }
}
