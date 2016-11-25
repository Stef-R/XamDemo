using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlSamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // alt binding skal evt. så et andet sted
            //ClockViewModel cm = new ClockViewModel();
            //BindingContext = cm;
            InitializeComponent();
        }
    }
}
