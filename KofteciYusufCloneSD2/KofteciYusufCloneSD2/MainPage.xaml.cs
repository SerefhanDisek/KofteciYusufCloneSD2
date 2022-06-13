using KofteciYusufCloneSD2.NavigationsPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using KofteciYusufCloneSD2.Models;
using KofteciYusufCloneSD2.ViewModels;
using KofteciYusufCloneSD2.Views;

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

       private async void Menu_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Navigations.MenuPage());
        }

        private async void FavoriLezzetler_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FavoriLezzetler());


        }

        private async void CigUrunler_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CigUrunlerPage());
        }

        private async void IzgaraEtler_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IzgaraEtlerPage());
        }

        private async void EkmekArasi_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EkmekArasiPage());
        }

        private async void TatliIcecek_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TatliPage());
        }


    }


}
