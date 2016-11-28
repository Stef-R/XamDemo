using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LoginMVVM.VievModels;
using LoginMVVM.Pages;

using Xamarin.Forms;

namespace LoginMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new LoginMVVM.MainPage();
            var viewmodel = new LoginViwModel();
            MainPage = new LoginPage(viewmodel);
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
