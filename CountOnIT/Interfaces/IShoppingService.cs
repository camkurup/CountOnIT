using CountOnIT.Models;

namespace CountOnIT.Interfaces
{
    public interface IShoppingService
    {
        public IReadOnlyList<Product> GetProducts();
    }
}
