using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using KofteciYusufCloneSD2.Models;

namespace KofteciYusufCloneSD2.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        private CreateModels _models = new CreateModels();
        public MainPageViewModel()
        {
            Products = _models.productsFav;
        }
    }
}
