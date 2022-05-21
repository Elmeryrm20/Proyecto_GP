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
    public partial class CrearCuenta : ContentPage
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void Btncrearcuenta_Clicked(object sender, EventArgs e)
        {
           
        }
        public bool validacion()
        {
            bool restuesta = true;

            return restuesta;
            
        }
    }
}