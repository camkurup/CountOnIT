using CountOnIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOnIT.ViewModels
{
    public class ProductViewModel
    {
        private readonly Product model;

        public ProductViewModel(Product model) 
        {
            this.model = model;

        }

        public string Name => model.Name;
        public string Description => model.Description;
        public string ImageName => model.ImageName;
    }
}
