using CountOnIT.Models;

namespace CountOnIT.ViewModels
{
    public class ProductViewModel : ViewModelBase<Product>
    {
        public ProductViewModel(Product model) : base(model)
        {
        }

        public string Name => Model.Name;
        public string Description => Model.Description;
        public string ImageUrl => Model.ImageUrl;
        public int StockQuantity => Model.StockQuantity;
    }
}
