﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace G_Proyectos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalle_mes : ContentPage
    {
        public Detalle_mes()
        {
            InitializeComponent();
            BindingContext = new SQLite.Monitoreobase();
        }
    }
}