using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KofteciYusufCloneSD2.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void GirisYap_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GirisYap());
        }

        private async void Hakkımızda_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Hakkımızda());
        }

        private async void BTH_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BTH());
        }

        private async void Kullanım_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Kullanım());
        }

        private async void KVK_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new KVK());
        }

        private async void MSS_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MSS());
        }

        private async void TeslimatSozlesmesi_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TeslimatSozlesmesi());
        }

        private async void Sube_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sube());
        }
    }

    internal class Sube : Page
    {
    }

    internal class TeslimatSozlesmesi : Page
    {
    }

    internal class MSS : Page
    {
    }

    internal class KVK : Page
    {
    }

    internal class Kullanım : Page
    {
    }

    internal class BTH : Page
    {
    }
}