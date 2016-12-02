using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SliderBinding;

namespace SliderBinding
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel vm;
        public MainPage(MainViewModel vm)
        {
            this.vm= vm;
            BindingContext = this.vm;
            InitializeComponent();
        }
    }
}
