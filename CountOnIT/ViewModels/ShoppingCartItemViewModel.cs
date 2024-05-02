using CountOnIT.Models;

namespace CountOnIT.ViewModels
{
    public class ShoppingCartItemViewModel : ViewModelBase<ShoppingCartItem>
    {
        public ShoppingCartItemViewModel(ShoppingCartItem model) : base(model)
        {
        }

        public int ProductId => Model.Product.Id;
        public string ProductName => Model.Product.Name;
        public string ImageUrl => Model.Product.ImageUrl;

        public int Quantity
        {
            get => Model.Quantity;
            set => Model.Quantity = value;
        }
    }
}
