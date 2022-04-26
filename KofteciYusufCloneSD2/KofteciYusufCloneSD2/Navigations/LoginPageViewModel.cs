using Xamarin.Forms;

namespace App.Core.Pages.Account
{
    internal class LoginPageViewModel
    {
        private INavigation navigation;

        public LoginPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }
    }
}