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
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
           
        }

        private async void Btnregistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearCuenta());
        }

        private async void Btniniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IniciarSesion());
        }
    }
}