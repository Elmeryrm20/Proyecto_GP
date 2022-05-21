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
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<DataChart> datachartlist = new List<DataChart>
            {
                new DataChart(3.4f)
                {
                    Color = SkiaSharp.SKColor.Parse("#ff92a0"),
                    TextColor = SkiaSharp.SKColor.Parse("#ff92a0"),
                    Label = "Point 1",
                    ValueLabel = "3.4"
                },
                new DataChart(7.3f)
                {
                    Color = SkiaSharp.SKColor.Parse("#0092a0"),
                    TextColor = SkiaSharp.SKColor.Parse("#0092a0"),
                    Label = "Point 2",
                    ValueLabel = "7.3"
                }
            };

            Grafico_Torta.Chart = new Microcharts.LineChart
            {
                
            };
        }
    }
}