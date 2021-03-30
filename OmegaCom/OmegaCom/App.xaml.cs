using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;

namespace OmegaCom
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Plugin.Media.CrossMedia.Current.Initialize();
            MainPage = new Welcomepage();
            

            
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
