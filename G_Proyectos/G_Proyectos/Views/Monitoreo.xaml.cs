using G_Proyectos.SQLite;
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
    public partial class Monitoreo : ContentPage
    {
        public Monitoreo()
        {
            InitializeComponent();
            MostrarMonitoreos();
        }

        private async void BtnIngresar_Clicked(object sender, EventArgs e)
        {

            if (true)
            {
                Monitoreobase Moni = new Monitoreobase
                {
                    Precion = MonitoreoValor.Text + " mg/dl",
                    FecRegistro = DateTime.Now,
                    NotaMonitoreo = Nota.Text
                };
                await App.SQLiteDB.InsertarMonitoreo(Moni);
                await DisplayAlert("Advetencia", "Monitoreo Registrado", "OK");
                MostrarMonitoreos();
            }
        }
        public async void MostrarMonitoreos()
        {
            var UsuarioList = await App.SQLiteDB.ListaMonitoreos();
            if (UsuarioList != null)
            {
                listaM.ItemsSource = UsuarioList;
            }
        }
    }
}