using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoginMVVM.VievModels;

using Xamarin.Forms;

namespace LoginMVVM.Pages
{
    public partial class LoginPage : ContentPage
    {
        private LoginViwModel loginViewModel;

        public LoginPage(LoginViwModel loginViewModel )
        {
            this.loginViewModel = loginViewModel;

            BindingContext = this.loginViewModel;

            loginKnap.SetBinding(Button.IsEnabledProperty, "LoginOk", BindingMode.OneWay);

            loginEntry.SetBinding<LoginViwModel>(Entry.TextProperty, vm=>vm.StatusText, BindingMode.TwoWay);
            InitializeComponent();

        }
    }
}
