using BilBest.BusinessCode;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Autofac;

namespace BilBest
{
    public partial class App : Application
    {
        //TODO : To Define Global Varialbes Here....
        private static Autofac.IContainer _container;

        public App()
        {
            InitializeComponent();

            //To initialize Containers..
            AppSetup appSetup = new AppSetup();
            _container = appSetup.CreateContainer();
             
            MainPage = new NavigationPage(new Views.Package.PackageSecondPage());
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
