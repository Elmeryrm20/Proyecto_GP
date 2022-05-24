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
    public partial class CrearCuenta : ContentPage
    {
        public CrearCuenta()
        {
            InitializeComponent();
            MostrarUsuario();
        }

        private async void Btncrearcuenta_Clicked(object sender, EventArgs e)
        {
            if (validacion())
            {
                Usuario user = new Usuario
                {
                    CorreoU = correoelectronico.Text,
                    NombreU = userentry.Text,
                    Contraseña = passwordentry.Text
                    
                };
                await App.SQLiteDB.InsertarUsuario(user);
                await DisplayAlert("Advetencia", "Registro con exito", "OK");
                limpiar();
                
            }
            else
            {
                await DisplayAlert("Advetencia", "ingrese los datos bien no seas GIL", "YA WEI");
            }
          
        }
        public bool validacion()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(correoelectronico.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(userentry.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(passwordentry.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(passworrepetdentry.Text))
            {
                respuesta = false;
            }
            else if (passwordentry.Text!= passworrepetdentry.Text)
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
            
        }
        public void limpiar()
        {
            correoelectronico.Text = "";
            userentry.Text = "";
            passwordentry.Text = "";
        }
        public async void MostrarUsuario()
        {
            var UsuarioList = await App.SQLiteDB.ListaUsuarios();
            if (UsuarioList != null)
            {
                listaU.ItemsSource = UsuarioList;
            }
        }
    }
}