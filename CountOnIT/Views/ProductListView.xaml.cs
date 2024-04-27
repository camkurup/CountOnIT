
using CountOnIT.Models;
using CountOnIT.ViewModels;

namespace CountOnIT.Views;

public partial class ProductListView : ContentView
{
    private ProductListViewModel productsListViewModel;

    public ProductListView()
	{
		InitializeComponent();
        productsListViewModel = new ProductListViewModel();

        ProductCollectionView.ItemsSource = productsListViewModel.ProductsCollection;

    }

    private void Go_To_Shoppingcart(object sender, TappedEventArgs e)
    {
        //This one have to be changed. I'll need this snippet more than onec, therefore I'll need a mothode that I insted will call here
        //AndExpandLayoutManager that methode should perhaps be in af class called "Navigation" Lets see if I get to do it. 
        var newView = new ShoppingCartView();

        Content = newView;
    }

    private void Go_To_Product(object sender, TappedEventArgs e)
    {
        var newView = new ProductView();

        Content = newView;

    }
}