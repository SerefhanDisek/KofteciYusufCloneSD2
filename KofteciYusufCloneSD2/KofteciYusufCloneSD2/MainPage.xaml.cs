using KofteciYusufCloneSD2.NavigationsPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KofteciYusufCloneSD2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AnaSayfa_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void Sepetim_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SepetimPage());
        }

        private async void Hesabım_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HesabımPage());
        }

        


    }


}
