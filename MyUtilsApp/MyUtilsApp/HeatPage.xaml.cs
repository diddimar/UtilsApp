﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyUtilsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeatPage : ContentPage
    {
        public HeatPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel.HeatViewModel();

        }
    }
}
