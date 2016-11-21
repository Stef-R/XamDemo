using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TutorQuickXAML
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;
        public MainPage()
        {
            InitializeComponent();
        }
        void OnTranslate(object sender, EventArgs e)
        {
            translatedNumber = "234";// Core.P;
            if (!string.IsNullOrWhiteSpace(translatedNumber))
            {
                callButtom.IsEnabled = true;
                callButtom.Text = "Call" + translatedNumber;
            } else {
                callButtom.IsEnabled = false;
                callButtom.Text = "Call";
            }
        }


    }
}
