using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string destino;
            int cantidad, monto;
            double descuento, montofinal;
            monto = 0;
            montofinal = 0;
            destino = Convert.ToString(txtdestino.Text);
            cantidad = Convert.ToInt32(txtboletos.Text);

            if (cantidad == 2)
            {
                if (destino == "trujillo" || destino == "Trujillo")
                {

                    monto = cantidad * 70;
                    descuento = monto * 0.1;
                    montofinal = monto - descuento;

                }
                if (destino == "Chiclayo" || destino == "Chiclayo")
                {
                    monto = cantidad * 100;
                    descuento = monto * 0.1;
                    montofinal = monto - descuento;

                }
                if (destino == "piura" || destino == "Piura")
                {
                    monto = cantidad * 120;
                    descuento = monto * 0.1;
                    montofinal = monto - descuento;

                }
            }

            if (cantidad >= 3)
            {

                if (destino == "trujillo" || destino == "Trujillo")
                {
                    monto = cantidad * 70;
                    descuento = monto * 0.25;
                    montofinal = monto - descuento;
                }
                if (destino == "Chiclayo" || destino == "Chiclayo")
                {
                    monto = cantidad * 100;
                    descuento = monto * 0.25;
                    montofinal = monto - descuento;

                }
                if (destino == "piura" || destino == "Piura")
                {
                    monto = cantidad * 120;
                    descuento = monto * 0.25;
                    montofinal = monto - descuento;

                }
            }

            if (cantidad == 1)
            {
                if (destino == "trujillo" || destino == "Trujillo")
                {

                    monto = cantidad * 70;
                    montofinal = monto;

                }
                if (destino == "Chiclayo" || destino == "Chiclayo")
                {
                    monto = cantidad * 100;
                    montofinal = monto;

                }
                if (destino == "piura" || destino == "Piura")
                {
                    monto = cantidad * 120;
                    montofinal = monto;

                }
            }
            txtmonto.Text = Convert.ToString(montofinal);
        }
    }
}
