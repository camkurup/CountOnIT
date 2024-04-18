using CountOnIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CountOnIT.ViewModels
{
    public class ProductViewModel
    {
        private List<ProductModel> productCollection = new List<ProductModel>();

        public ProductViewModel()
        {
            productCollection.Add(new ProductModel(1, "Skruer", "description", "img"));
        }

        public List<ProductModel> StudentsCollection
        {
            get { return productCollection; }
            set { productCollection = value; }
        }
    }
}
