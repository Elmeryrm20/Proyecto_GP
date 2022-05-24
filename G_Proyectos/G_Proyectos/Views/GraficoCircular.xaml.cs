using G_Proyectos.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DataChart = Microcharts.ChartEntry;

namespace G_Proyectos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraficoCircular : ContentPage
    {
        public GraficoCircular()
        {

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjQ0NDMxQDMyMzAyZTMxMmUzMFBPTUJMUjJ4Sk9yUm1yTHJ2eTl2ZUlRcEFrRUxzYXU0T3VZVG5YWTlta289");

            InitializeComponent();

            //BindingContext = new SQLite.Monitoreo();
        }

        
        
    }
}