using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWS_Sandbox
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Declare the main page as a navigation page!!  This will save alot of problems later
            // Same can be done with tabbed etc etc.

            MainPage = new NavigationPage(new MainPage());
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
