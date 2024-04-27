using CountOnIT.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountOnIT.Models;


namespace CountOnIT.ViewModels
{
    //The method in this class handles the list of products
    public class ProductListViewModel
    {
        private List<ProductModel> productCollection = new List<ProductModel>();

        //This list is statik. It should be handled dynamic with data from my database
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
