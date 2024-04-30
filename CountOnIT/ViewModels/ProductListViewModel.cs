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
            productCollection.Add(new ProductModel(1, "Skruer", "description", "ikon1.png", 201));
            productCollection.Add(new ProductModel(1, "Søm", "description", "ikon2.png", 201));
            productCollection.Add(new ProductModel(1, "Pluks", "description", "ikon3.png", 201));
            productCollection.Add(new ProductModel(1, "Dims", "description", "ikon4.png", 201));
            productCollection.Add(new ProductModel(1, "Tingel", "description", "ikon5.png", 201));
            productCollection.Add(new ProductModel(1, "Tangel", "description", "ikon6.png", 201));
            productCollection.Add(new ProductModel(1, "Knofedt", "description", "iko1.png", 201));
            productCollection.Add(new ProductModel(1, "Tommelstok", "description", "ikon6.png", 201));
            productCollection.Add(new ProductModel(1, "Himstregims", "description", "ikon1.png", 201));
            productCollection.Add(new ProductModel(1, "Du ved nok", "description", "ikon2.png", 201));
            productCollection.Add(new ProductModel(1, "Tommelstokforlænger", "description", "ikon3.png", 201));
        }

        public List<ProductModel> ProductsCollection
        {
            get { return productCollection; }
            set { productCollection = value; }
        }

    }
}
