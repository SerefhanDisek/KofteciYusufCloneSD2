using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using KofteciYusufCloneSD2.Models;

namespace KofteciYusufCloneSD2.ViewModels
{
    public class EkmekArasiViewModel
    {
        CreateModels _models = new CreateModels();
        public ObservableCollection<Product> Products { get; set; }

        public EkmekArasiViewModel()
        {
            Products = _models.productsEkmk;
        }
    }
}
