using CountOnIT.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountOnIT.Models;


namespace CountOnIT.ViewModels
{
    public class ProductListViewModel
    {
        private List<ProductModel> productCollection = new List<ProductModel>();

        public ProductListViewModel()
        {
            productCollection.Add(new ProductModel(1, "Skruer", "description", "ikon1.png"));
            productCollection.Add(new ProductModel(1, "Skruer", "description", "ikon1.png"));
            productCollection.Add(new ProductModel(1, "Skruer", "description", "ikon1.png"));
            productCollection.Add(new ProductModel(1, "Skruer", "description", "ikon1.png"));
            productCollection.Add(new ProductModel(1, "Skruer", "description", "ikon1.png"));
            productCollection.Add(new ProductModel(1, "Skruer", "description", "ikon1.png"));
        }

        public List<ProductModel> ProductsCollection
        {
            get { return productCollection; }
            set { productCollection = value; }
        }

    }
}
