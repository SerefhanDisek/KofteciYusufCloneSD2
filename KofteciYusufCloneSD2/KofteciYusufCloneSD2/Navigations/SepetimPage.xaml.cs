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

            


            
        }
        private async void UrunlereGit_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }



    }
}