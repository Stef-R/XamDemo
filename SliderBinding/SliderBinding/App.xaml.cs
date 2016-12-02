using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using SliderBinding;

namespace SliderBinding
{
    public partial class App : Application
    {
        //static private SliderConverter sb = new SliderConverter();
        public App()
        {
            InitializeComponent();
            MainViewModel vm = new MainViewModel();
            MainPage = new SliderBinding.MainPage(vm);
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
