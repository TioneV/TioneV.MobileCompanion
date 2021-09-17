using System;
using System.Collections.Generic;
using System.ComponentModel;
using TioneV.MobileCompanion.Models;
using TioneV.MobileCompanion.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TioneV.MobileCompanion.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}