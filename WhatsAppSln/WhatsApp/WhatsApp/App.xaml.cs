using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new TabNames());
            navPage.BarBackgroundColor = Color.Green;

            MainPage = navPage;
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
