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
    public partial class Tr1 : ContentPage
    {
        public Tr1()
        {
            InitializeComponent();
            llenardatos();
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                trabajo trabaj = new trabajo
                {
                    Actividad1=txtActividad1.Text,
                    Actividad2 = txtActividad2.Text,
                    Actividad3 = txtActividad3.Text,
                };
                await App.SqliteDB.SaveActividad1(trabaj);
               
                await DisplayAlert("Registro","Se guardo de Manera Exitosa las Actividades","OK");
                LimpiarControles();
                llenardatos();
                
            }
            else
            {
                await DisplayAlert("Advertencia","Ingresar todos los datos","OK");
            }
        }
        public async void llenardatos()
        {
            var actividadList = await App.SqliteDB.GetTrabajosAsync();
            if (actividadList != null)
            {
                lstActividades.ItemsSource = actividadList;
            }
        }
        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtActividad1.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtActividad2.Text))
            {
                respuesta=false;
            }
            else if (string.IsNullOrEmpty(txtActividad3.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta=true;
            }
            return respuesta;
        }

        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdActividades.Text))
            {
                trabajo trabaj = new trabajo()
                {
                    IdActividad = Convert.ToInt32(txtIdActividades.Text),
                    Actividad1 = txtActividad1.Text,
                    Actividad2 = txtActividad2.Text,
                    Actividad3 = txtActividad3.Text,
                    Actividad4 = txtActividad4.Text,
                    Actividad5 = txtActividad5.Text,
                    Actividad6 = txtActividad6.Text,
                    Actividad7 = txtActividad7.Text,
                    Actividad8 = txtActividad8.Text,
                    Actividad9 = txtActividad9.Text,
                    Actividad10 = txtActividad10.Text,
                };
                await App.SqliteDB.SaveActividad1(trabaj);
                await DisplayAlert("Registro", "Se Actualizo de manera Exitosa", "OK");
                LimpiarControles();
                txtIdActividades.IsVisible = false;
                btnActualizar.IsVisible = false;
                btnRegistrar.IsVisible = true;
                llenardatos();
                
            }
        }

        private async void lstActividades_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (trabajo)e.SelectedItem;
            btnRegistrar.IsVisible = false;
            txtIdActividades.IsVisible = true;
            btnActualizar.IsVisible = true;
            btnEliminar.IsVisible = true;
            if (!string.IsNullOrEmpty(obj.IdActividad.ToString()))
            {
                var actividad = await App.SqliteDB.GetTrabajoByIdAsync(obj.IdActividad);
                if(actividad!= null)
                {
                    txtIdActividades.Text = actividad.IdActividad.ToString();
                    txtActividad1.Text = actividad.Actividad1;
                    txtActividad2.Text = actividad.Actividad2;
                    txtActividad3.Text = actividad.Actividad3;
                    txtActividad4.Text = actividad.Actividad4;
                    txtActividad5.Text = actividad.Actividad5;
                    txtActividad6.Text = actividad.Actividad6;
                    txtActividad7.Text = actividad.Actividad7;
                    txtActividad8.Text = actividad.Actividad8;
                    txtActividad9.Text = actividad.Actividad9;
                    txtActividad10.Text = actividad.Actividad10;
                }
            }
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            var actividades = await App.SqliteDB.GetTrabajoByIdAsync(Convert.ToInt32(txtIdActividades.Text));
            if(actividades!= null)
            {
                await App.SqliteDB.DeleteTrabajoAsync(actividades);
                await DisplayAlert("Actividades", "Se Elimino con Exito", "OK");
                LimpiarControles();
                llenardatos();
                txtIdActividades.IsVisible = false;
                btnActualizar.IsVisible = false;
                btnEliminar.IsVisible = false;
                btnRegistrar.IsVisible = true;
            }
        }

        public void LimpiarControles()
        {
            txtIdActividades.Text = "";
            txtActividad1.Text = "";
            txtActividad2.Text = "";
            txtActividad3.Text = "";
            txtActividad4.Text = "";
            txtActividad5.Text = "";
            txtActividad6.Text = "";
            txtActividad7.Text = "";
            txtActividad8.Text = "";
            txtActividad9.Text = "";
            txtActividad10.Text = "";
        }
    }
}