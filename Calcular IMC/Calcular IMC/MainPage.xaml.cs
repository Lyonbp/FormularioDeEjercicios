using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calcular_IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado = "";

                if(imc < 18.5)
                {
                    resultado = "Estas Flaco Come mrd";
                }
                else if(imc >= 18.5 && imc<=24.9)
                {
                    resultado = "Tu peso es el Correcto";
                }
                else if(imc >=25 && imc <= 29.9)
                {
                    resultado = "Tu tienes Sobrepeso";
                }
                else
                {
                    resultado = "Estas Gordo, ¡Alimentate Bien!";
                }

                DisplayAlert("resultado", resultado ,"ok");
            }
            else
            {
                DisplayAlert("Error de datos", "Llenar los espacios en blanco", "Continuar");
            }
        }
       
    
    private void Button_Clicked_1(object sender, EventArgs e)
        {
            Altura.Text = "";
            Peso.Text = "";
            IMC.Text = "";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
            Environment.Exit(0);
        }
    }
}
