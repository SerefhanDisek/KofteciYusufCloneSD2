using KofteciYusufCloneSD2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KofteciYusufCloneSD2.NavigationsPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HesabımPage : ContentPage
    {
        public HesabımPage()
        {
            InitializeComponent();
        }

        private async void GirisYap_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GirisYap());
        }
    }
}