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
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral(string correo)
        {
            InitializeComponent();
            this.Master = new master();
            this.Detail = new NavigationPage(new PaginaDeInicio());
            
            App.MasterD = this;
        }
    }
}