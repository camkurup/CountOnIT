using CountOnIT.Interfaces;
using CountOnIT.Models;

namespace CountOnIT.Services
{
    public class ShoppingServiceMock : IShoppingService
    {
        private readonly List<Product> products;

        public ShoppingServiceMock()
        {
            products = new List<Product>
            {
                new Product(1, "Skruer", "description", "ikon1.png", 201),
                new Product(1, "Søm", "description", "ikon2.png", 201),
                new Product(1, "Pluks", "description", "ikon3.png", 201),
                new Product(1, "Dims", "description", "ikon4.png", 201),
                new Product(1, "Tingel", "description", "ikon5.png", 201),
                new Product(1, "Tangel", "description", "ikon6.png", 201),
                new Product(1, "Knofedt", "description", "ikon1.png", 201),
                new Product(1, "Tommestok", "description", "ikon6.png", 201),
                new Product(1, "Himstregims", "description", "ikon1.png", 201),
                new Product(1, "Du ved nok", "description", "ikon2.png", 201),
                new Product(1, "Tommestokforlænger", "description", "ikon3.png", 201)
            };
        }

        public IReadOnlyList<Product> GetProducts()
        {
            return products;
        }
    }
}