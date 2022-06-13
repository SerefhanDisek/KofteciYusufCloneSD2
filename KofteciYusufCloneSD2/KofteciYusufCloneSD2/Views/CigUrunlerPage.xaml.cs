using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KofteciYusufCloneSD2.ViewModels;

namespace KofteciYusufCloneSD2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CigUrunlerPage : ContentPage
    {
        public CigUrunlerPage()
        {
            InitializeComponent();
            BindingContext = new CigUrunlerViewModel();
        }
    }
}