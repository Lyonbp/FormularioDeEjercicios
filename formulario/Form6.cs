using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
