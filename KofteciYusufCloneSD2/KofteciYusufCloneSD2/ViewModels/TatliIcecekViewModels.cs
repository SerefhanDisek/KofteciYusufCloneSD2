using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using KofteciYusufCloneSD2.Models;

namespace KofteciYusufCloneSD2.ViewModels
{
    public class TatliIcecekViewModels
    {
        public ObservableCollection<Product> Products { get; set; }
        CreateModels _models = new CreateModels();
        public TatliIcecekViewModels()
        {
            Products = _models.productsTatli;

        }
    }
}
