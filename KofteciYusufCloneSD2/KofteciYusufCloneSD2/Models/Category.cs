using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace KofteciYusufCloneSD2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ObservableCollection<Product> Products { get; set; }
    }
}
