using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSemana2TagliacozzoNR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ingreso : ContentPage
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private async void btnValidar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtDato1.Text;
            string clave = txtDato2.Text;
            if (usuario =="estudiante2021" && clave=="uisrael2021" )
            {
                await Navigation.PushAsync(new VistaDos(usuario, clave));
            }
            else
            {
               await DisplayAlert("Alerta", "Credenciales incorrectas", "OK");
            }

        }
    }
}