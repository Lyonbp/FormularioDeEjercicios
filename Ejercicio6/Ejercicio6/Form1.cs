using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int año_siguiente;
            int dia_siguiente;
            int mes_siguiente;
            int año = Convert.ToInt32(txtanho.Text);
            int dia = Convert.ToInt32(txtdia.Text);
            int mes = Convert.ToInt32(txtmes.Text);
            
           

            
            if ((dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia == 29 && mes == 2) || (dia == 28 && mes == 2 && ((año % 4 != 0) || (año % 100) == 0) && (año % 400) != 0) || dia == 31)
            {
                mes_siguiente = mes + 1;
                dia_siguiente = 1;
            }
            else
            {
                dia_siguiente = dia + 1;
                mes_siguiente = mes;
            }

            if (dia_siguiente == 1 && mes_siguiente == 13)
            {
                mes_siguiente = 1;
                año_siguiente = año + 1;
            }
            else
            {
                año_siguiente = año;
            }

            txtdia2.Text = dia_siguiente.ToString();
            txtmes2.Text = mes_siguiente.ToString();
            txtanho2.Text = año_siguiente.ToString();
        }

        private void txtdia2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
