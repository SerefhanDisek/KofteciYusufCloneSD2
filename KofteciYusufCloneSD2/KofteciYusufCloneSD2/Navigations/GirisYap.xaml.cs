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
    public partial class GirisYap : ContentPage
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        async void GirisYap_Click (object sender, EventArgs e)
        {
            var kullanıcı = new Kullanıcı
            {
                KullanıcıAdı = kullanıcıAdıEntry.Text,
                Şifre = şifreEntry.Text
            };
        }
    }
}