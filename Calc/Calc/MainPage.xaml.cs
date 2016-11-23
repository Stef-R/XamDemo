using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnDigitClick(object sender,EventArgs e)
        {
            //var senderButton = (Button)sender;
            var senderButton = sender as Button;
            //textLabel = senderButton.Text;
            return;
        }
    }
}
