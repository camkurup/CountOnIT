using CountOnIT.ViewModels;

namespace CountOnIT.Views;

public partial class ShoppingCartView : ContentView
{
    private ProductListViewModel productsListViewModel;

    public ShoppingCartView()
	{
		InitializeComponent();
        productsListViewModel = new ProductListViewModel();

        ProductCollectionView.ItemsSource = productsListViewModel.ProductsCollection;

    }

    // should call method from NavigationController
    private void Go_Back_tapped(object sender, TappedEventArgs e)
    {
        var newView = new ProductListView();

        Content = newView;
    }


    private void Go_To_Product(object sender, TappedEventArgs e)
    {
        var newView = new ProductView();

        Content = newView;
    }
}