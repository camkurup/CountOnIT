using CountOnIT.Models;


namespace CountOnIT.ViewModels
{
    public class ProductListViewModel
    {
        private readonly List<ProductViewModel> products;

        public ProductListViewModel(IEnumerable<Product> products)
        {
            this.products = products?.Select(x => new ProductViewModel(x)).ToList() ?? new List<ProductViewModel>();
        }

        public IReadOnlyList<ProductViewModel> Products => products;

    }
}
