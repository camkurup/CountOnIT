using CountOnIT.ViewModels;

namespace CountOnIT.Pages;

public partial class ShoppingCartPage : ContentPage
{
    public ShoppingCartPage(ShoppingCartViewModel cart)
    {
        InitializeComponent();
        BindingContext = cart;
    }
}