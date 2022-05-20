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
            btniniciar.Clicked += Btniniciar_Clicked;
            btnregistrar.Clicked += Btnregistrar_Clicked;
        }

        private void Btnregistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrearCuenta());
        }

        private void Btniniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IniciarSesion());
        }
    }
}