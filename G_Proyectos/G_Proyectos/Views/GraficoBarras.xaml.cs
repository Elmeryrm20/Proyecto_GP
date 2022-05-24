using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace G_Proyectos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraficoBarras : ContentPage
    {

        public ObservableCollection<SQLite.Monitoreobase> Data { get; set; }

        public GraficoBarras()
        {
            InitializeComponent();

            Data = new ObservableCollection<SQLite.Monitoreobase>();
            FillData();
        }

        private void FillData()
        {
            SQLite.Monitoreobase HipoGlucemia = new SQLite.Monitoreobase()
            {
                precion = await App.SQLiteDB.Hipoglucemia();
            };
        }
    }
}