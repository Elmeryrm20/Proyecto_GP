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
    public partial class master : ContentPage
    {
        public master()
        {
            InitializeComponent();
        }

        private async void btninicio_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new PaginaDeInicio());
        }

        private async void btninformacion_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new MiInformacion());
        }

        private void btnreportes_Clicked(object sender, EventArgs e)
        {

        }

        private void btnacercade_Clicked(object sender, EventArgs e)
        {

        }

        private void btncerrarsesion_Clicked(object sender, EventArgs e)
        {

        }
    }
}