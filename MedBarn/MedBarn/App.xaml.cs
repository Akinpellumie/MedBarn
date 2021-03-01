using MedBarn.Services;
using MedBarn.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedBarn
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            var _mainpage= new NavigationPage(new LandingPage());
            MainPage = _mainpage;
            //MainPage = new AppShell();
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
