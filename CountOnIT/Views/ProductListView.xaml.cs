using CountOnIT.Pages;
using CountOnIT.ViewModels;

namespace CountOnIT.Views;

public partial class ProductListView : ContentView
{
    public ProductListView()
    {
        InitializeComponent();
    }

    public ShoppingCartViewModel ViewModel => BindingContext as ShoppingCartViewModel;

    private async void Go_To_ShoppingCart(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ShoppingCartPage(ViewModel));
    }
}