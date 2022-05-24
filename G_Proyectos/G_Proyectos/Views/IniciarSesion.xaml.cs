using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace G_Proyectos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IniciarSesion : ContentPage
    {
        
        public IniciarSesion()
        {
            InitializeComponent();
        }
        private async void Btniniciarsesion_Clicked(object sender, EventArgs e)
        {
            if (await ValidateForm())
            {
                var result = App.SQLiteDB.BuscarUsuario(userentry.Text.Trim(), passwordentry.Text.Trim());

                if (result.Count() == 0)
                {
                    await DisplayAlert("Alerta", "Email o Password Incorrectos.", "OK");
                }
                else if (result.Count() == 1)
                {
                    await Navigation.PushAsync(new MenuLateral(userentry.Text));
                }
                else if (result.Count() >= 1)
                {
                    await DisplayAlert("Alerta", "Existe más de una cuenta registada, favor de solicitar la correción de la cuenta.", "OK");
                }
            }
            
        }
        private async Task<bool> ValidateForm()
        {
            //Valida si el valor en el Entry txtTo se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(userentry.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo Email es obligatorio.", "OK");
                return false;
            }
            //Valida si el valor en el Entry txtSubject se encuentra vacio o es igual a Null
            else if (String.IsNullOrWhiteSpace(passwordentry.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo Password es obligatorio.", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}