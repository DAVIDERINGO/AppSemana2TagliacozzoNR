using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSemana2TagliacozzoNR
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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

            }
            catch(Exception ex)
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

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "App");
            }
        }
    }
}
