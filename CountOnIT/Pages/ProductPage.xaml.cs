using CountOnIT.ViewModels;

namespace CountOnIT.Pages;

public partial class ProductPage : ContentPage
{
    public ProductPage(ProductViewModel product)
    {
        BindingContext = product;
        InitializeComponent();
    }
}