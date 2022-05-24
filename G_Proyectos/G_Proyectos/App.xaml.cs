using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using G_Proyectos.Data;
using System.IO;

namespace G_Proyectos
{

    public partial class App : Application
    {
        static SQLiteConeccion db;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Principal());
        }
        public static SQLiteConeccion SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteConeccion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BaseGP"));
                }
                return db;
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
