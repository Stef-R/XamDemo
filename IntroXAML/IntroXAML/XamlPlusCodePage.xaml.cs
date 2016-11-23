using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IntroXAML
{
    public partial class XamlPlusCodePage : ContentPage
    {
        public XamlPlusCodePage()
        {
            InitializeComponent();           
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLabel.Text = ((Slider)sender).Value.ToString("F3");
            //valueLabel.Text = args.NewValue.ToString("F3");            
        }
        async void OnButtomClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!",
                "The button labeled '"+button.Text + "' has been clicked",
                "OK");
            //valueLabel.Text = args.NewValue.ToString("F3");            
        }

    }
}
