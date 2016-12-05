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
        private MainViewModel svm;
        private SliderConverter sc = new SliderConverter();
        public MainPage(MainViewModel svm)
        {
            this.svm = svm;
            BindingContext = this.svm;
            InitializeComponent();
            slider1.SetBinding<MainViewModel>(Slider.ValueProperty, vm => vm.MyValue, BindingMode.OneWay);
            slider2.SetBinding<MainViewModel>(Slider.ValueProperty, vm => vm.MyValue, BindingMode.TwoWay);
        }
    }
}
