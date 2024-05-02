using CountOnIT.Pages;
using CountOnIT.ViewModels;

namespace CountOnIT.Views;

public partial class ProductItemView : ContentView
{
    public ProductItemView()
    {
        InitializeComponent();
    }

    public ProductViewModel ViewModel => BindingContext as ProductViewModel;

    private async void Item_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ProductPage(ViewModel));
    }
}