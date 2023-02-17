using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hotel
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void btnhotel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ejercicios.Hotel());
          
        }

        private void btnsalir_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
            Environment.Exit(0);
        }

        private async void btncolchon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ejercicios.colchones());
        }

        private async void btntr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ejercicios.Tr1());
        }
    }
}