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
            mostararU();
        }

        private async void actualizarinfo_Clicked(object sender, EventArgs e)
        {
            if (true)
            {

                App.SQLiteDB.ActualiarUsuario(nombre.Text, apellido.Text, fecha_nac.Date, celular.Text, tipo_paciente.Text, "123");
                await DisplayAlert("Advetencia", "Actualizacion con exito", "OK");

            }
        }
        public  void mostararU()
        {
            var datos = App.SQLiteDB.UsuarioLogeado("123");
            apellido.Text = datos.ToString();
        }
    }
}