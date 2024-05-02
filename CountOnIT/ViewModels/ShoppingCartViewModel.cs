using CountOnIT.Models;

namespace CountOnIT.ViewModels
{
    public class ShoppingCartViewModel : ViewModelBase<ShoppingCart>
    {
        private readonly List<ShoppingCartItemViewModel> items;

        public ShoppingCartViewModel(ShoppingCart model) : base(model)
        {
            items = Model.Items.Select(x => new ShoppingCartItemViewModel(x)).ToList();
        }

        public IReadOnlyList<ShoppingCartItemViewModel> Items => items;

        public void AddItem(ShoppingCartItem item)
        {
            var vm = FindItem(item.Product);

            if (vm is null)
            {
                vm = new ShoppingCartItemViewModel(item);
                items.Add(vm);
            }
            else
            {
                vm.Quantity += item.Quantity;
            }
        }

        private ShoppingCartItemViewModel FindItem(Product product) =>
            items.FirstOrDefault(x => x.ProductId == product.Id);
    }
}
