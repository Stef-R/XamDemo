using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Navigation
{
    public partial class App : Application
    {

        private TabbedPage tabPage = new TabbedPage();
        private NavigationPage navNumber = new NavigationPage();
        private NavigationPage navLetter = new  NavigationPage();
        public App()
        {
            InitializeComponent();

            MainPage = tabPage;

            tabPage.Children.Add(navNumber);
            tabPage.Children.Add(navLetter);



            //MainPage = new Navigation.MainPage();
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
            var  page1 = new Page1();
            var  pageA = new PageA();
            await navNumber.PushAsync(page1);
            await navLetter.PushAsync(pageA);
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
