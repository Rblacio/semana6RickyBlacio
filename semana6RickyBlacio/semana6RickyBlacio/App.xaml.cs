using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana6RickyBlacio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Listado();//MainPage();
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
