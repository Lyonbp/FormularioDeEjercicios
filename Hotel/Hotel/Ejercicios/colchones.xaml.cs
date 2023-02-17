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
    public partial class colchones : ContentPage
    {
        int cant;
        string prod,cat;

        public colchones()
        {
            InitializeComponent();
            pickerope.Items.Add("10011 - A");
            pickerope.Items.Add("20011 - B");
            pickerope.Items.Add("20022 - C");
            categoria.Items.Add("A");
            categoria.Items.Add("B");
        }

        private async void pickerope_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            prod = pickerope.SelectedItem.ToString();
        }

        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cat = categoria.SelectedItem.ToString();
        }

        private async void btnoperation_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                DisplayAlert("ALERTA: ", "El campo nombre esta vacio", "Reintentar");
            }
            else if (string.IsNullOrEmpty(txtapep.Text))
            {
                DisplayAlert("ALERTA: ", "El campo apellido paterno esta vacio", "Reintentar");
            }
            else if (string.IsNullOrEmpty(txtapem.Text))
            {
                DisplayAlert("ALERTA: ", "El campo apellido materno esta vacio", "Reintentar");
            }
            else if (pickerope.SelectedIndex == -1)
            {
                DisplayAlert("ALERTA: ", "Seleccione un tipo de colchon valido", "Reintentar");
            }
            else if (categoria.SelectedIndex == -1 )
            {
                DisplayAlert("ALERTA: ", "Seleccione un tipo de pago valido", "Reintentar");
            }
            else if (string.IsNullOrEmpty(cantidad.Text))
            {
                DisplayAlert("ALERTA: ", "El campo cantidad esta vacio", "Reintentar");
            }
            else { 
            if (cat == "A")
            {
                if (prod == "10011 - A")
                {
                    cant = int.Parse(cantidad.Text);
                    

                    int venta = 100 * cant;
                    double descuento = venta * 0.2;
                    double total_venta = venta - descuento;

                    
                    lblventa.Text = "CONTADO";
                    lbldescuento.Text = descuento.ToString();
                    lbltotal.Text = total_venta.ToString();
                }

                else if(prod == "20011 - B")
                {
                    cant = int.Parse(cantidad.Text);
                   

                    int venta = 120 * cant;
                    double descuento = venta * 0.2;
                    double total_venta = venta - descuento;

                    lblventa.Text = "CONTADO";
                    lbldescuento.Text = descuento.ToString();
                    lbltotal.Text = total_venta.ToString();
                }
                else if (prod == "20022 - C")
                {
                    cant = int.Parse(cantidad.Text);

                    int venta = 90 * cant;
                    double descuento = venta * 0.2;
                    double total_venta = venta - descuento;

                    lblventa.Text = "CONTADO";
                    lbldescuento.Text = descuento.ToString();
                    lbltotal.Text = total_venta.ToString();
                }
               

            }
            if (cat == "B")
            {
                if (prod == "10011 - A")
                {
                    cant = int.Parse(cantidad.Text);


                    int venta = 100 * cant;
                    double descuento = venta * 0.05;
                    double total_venta = venta - descuento;


                    lblventa.Text = "CREDITO";
                    lbldescuento.Text = descuento.ToString();
                    lbltotal.Text = total_venta.ToString();
                }

                else if (prod == "20011 - B")
                {
                    cant = int.Parse(cantidad.Text);


                    int venta = 120 * cant;
                    double descuento = venta * 0.05;
                    double total_venta = venta - descuento;

                    lblventa.Text = "CREDITO";
                    lbldescuento.Text = descuento.ToString();
                    lbltotal.Text = total_venta.ToString();
                }
                else if (prod == "20022 - C")
                {
                    cant = int.Parse(cantidad.Text);

                    int venta = 90 * cant;
                    double descuento = venta * 0.05;
                    double total_venta = venta - descuento;

                    lblventa.Text = "CREDITO";
                    lbldescuento.Text = descuento.ToString();
                    lbltotal.Text = total_venta.ToString();
                }
               
            }
            
        }
     }
        private void btnnuevo_Clicked(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtapep.Text = "";
            txtapem.Text = "";
            cantidad.Text = "";
            pickerope.SelectedItem = "";
            categoria.SelectedItem = "";
            lblventa.Text = "";
            lbldescuento.Text = "";
            lbltotal.Text = "";
        }

        
    }
}