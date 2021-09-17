using System;
using TioneV.MobileCompanion.Services;
using TioneV.MobileCompanion.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TioneV.MobileCompanion
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
