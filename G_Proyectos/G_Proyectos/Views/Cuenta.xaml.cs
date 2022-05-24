using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_Proyectos.SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace G_Proyectos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cuenta : ContentPage
    {
        public Cuenta()
        {
            InitializeComponent();
        }

        private async void btnactualizarcuenta_Clicked(object sender, EventArgs e)
        {
           
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }
}