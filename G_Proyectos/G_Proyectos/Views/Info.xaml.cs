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
    public partial class Info : ContentPage
    {
        public Info()
        {
            InitializeComponent();
        }

        private async void actualizarinfo_Clicked(object sender, EventArgs e)
        {
            if (true)
            {
                Usuario date = new Usuario
                {
                    NombreReal = nombre.Text,
                    Apellido = apellido.Text,
                    FecNacimiento = fecha_nac.Date,
                    TelefonoP = celular.Text,
                    TipoPersona = tipo_paciente.Text

                 };
                await App.SQLiteDB.ActualiarUsuario(date);
                await DisplayAlert("Advetencia", "Actualizacion con exito", "OK");

            }
        }
    }
}