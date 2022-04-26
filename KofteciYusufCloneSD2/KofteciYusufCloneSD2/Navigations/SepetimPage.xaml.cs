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
    public partial class SepetimPage : ContentPage
    {
        public SepetimPage()
        {
            InitializeComponent();

            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Sepetinizde Ürün Bulunmamaktadır"
            };


            
        }

        private async void UrunlereGit_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }


    }
}