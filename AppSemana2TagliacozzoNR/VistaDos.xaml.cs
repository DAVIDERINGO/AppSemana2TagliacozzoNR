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
    public partial class VistaDos : ContentPage
    {
        public VistaDos(string usuario, string clave)
        {
            InitializeComponent();
            lblUser.Text = "USUARIO LOGEADO ES: " + usuario;
           // lblPass.Text = "CLAVE: " + clave;
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            //Sirve para capturar las exxcepciones
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);


                double suma = dato1 + dato2;
                txtResultado.Text = suma.ToString();
                lblResultado.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "App");
            }
        }

        private void btnRestar_Clicked(object sender, EventArgs e)
        {
            //Sirve para capturar las exxcepciones
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);


                double resta = dato1 - dato2;
                txtResultado.Text = resta.ToString();
                lblResultado.Text = resta.ToString();
                
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "App");
            }
        }
    }
}