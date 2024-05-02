using CountOnIT.Interfaces;
using CountOnIT.ViewModels;

namespace CountOnIT.Views;

public partial class UsagePage : ContentPage
{
    public UsagePage(IShoppingService shoppingService)
    {
        InitializeComponent();

        var products = shoppingService.GetProducts();
        listView.BindingContext = new ProductListViewModel(products);
    }
}