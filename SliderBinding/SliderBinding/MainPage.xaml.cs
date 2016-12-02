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
        private SliderConverter sc = new SliderConverter();
        public MainPage(MainViewModel vm)
        {
            this.vm = vm;
            BindingContext = this.vm;
            slider1.SetBinding<MainViewModel>(Slider.ValueProperty, vm1 => vm1.MyValue, BindingMode.OneWay, sc);
            slider2.SetBinding<MainViewModel>(Slider.ValueProperty, vm1 => vm1.MyValue, BindingMode.TwoWay);
            InitializeComponent();
        }
    }
}
