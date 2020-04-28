﻿using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xaminals
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new AboutPage();
            //Task startupWork = new Task(() => { SimulateStartup(); });
            //startupWork.Start();
            //System.Threading.Thread.Sleep(5000);
            MainPage = new AppShell();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
