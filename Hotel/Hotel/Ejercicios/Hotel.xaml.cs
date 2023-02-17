    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.Ejercicios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hotel : ContentPage
    {
        int dias;
        string habita;

        public Hotel()
        {
            InitializeComponent();
           
            pickerope.Items.Add("SIMPLE");
            pickerope.Items.Add("DOBLE");
            pickerope.Items.Add("NUPCIAL");


        }

        private async void pickerope_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            habita = pickerope.SelectedItem.ToString();
            
        }

        private void btnnuevo_Clicked_1(object sender, EventArgs e)
        {
            txtname.Text = "";
            dias_.Text = "";
            pickerope.SelectedItem = "";
            lbltotal.Text = "";
            lbldescuento.Text = "";
            lblneto.Text = "";

        }

        private async void btnoperation_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                DisplayAlert("ALERTA: ", "El campo nombre esta vacio", "Reintentar");
            }
            else if (pickerope.SelectedIndex == -1 )
            {
                DisplayAlert("ALERTA: ", "Seleccione un tipo de colchon valido", "Reintentar");
            }
            else if (string.IsNullOrEmpty(dias_.Text))
            {
                DisplayAlert("ALERTA: ", "El campo dias ta vacio", "Reintentar");
            }

            else { 

            if (habita=="SIMPLE")
            {
                dias = int.Parse(dias_.Text);

                int venta = 15 * dias;
                double descuento = venta * 0.1;
                double total_venta = venta - descuento;

                lbltotal.Text = venta.ToString();
                lbldescuento.Text = descuento.ToString();
                lblneto.Text = total_venta.ToString();


            }
            else if (habita=="DOBLE")
            {
                dias = int.Parse(dias_.Text);

                int venta = 40 * dias;
                double descuento = venta * 0.15;
                double total_venta = venta - descuento;

                lbltotal.Text = venta.ToString();
                lbldescuento.Text = descuento.ToString();
                lblneto.Text = total_venta.ToString();
            }
            else if (habita=="NUPCIAL")
            {
                dias = int.Parse(dias_.Text);

                int venta = 120 * dias;
                double descuento = venta * 0.15;
                double total_venta = venta - descuento;

                lbltotal.Text = venta.ToString();
                lbldescuento.Text = descuento.ToString();
                lblneto.Text = total_venta.ToString();
            }

            else
            {
                DisplayAlert("Error de Datos", "Llenar los espacios en Blanco", "Continuar");
            }


        }


     
    }
}
}