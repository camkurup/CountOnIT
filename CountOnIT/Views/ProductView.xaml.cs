using CountOnIT.Controllers;

namespace CountOnIT.Views;

public partial class ProductView : ContentView
{
	public ProductView()
	{
		InitializeComponent();
	}

    // should call method from NavigationController
    private void Go_Back_tapped(object sender, TappedEventArgs e)
    {
        //OBS!This will only go back to productlist.
        //in a production application this would have to be more dynamick.
        //it should not be bound to a specific page/view

        var newView = new ProductListView();

        Content = newView;
    }

    // should call method from NavigationController
    private void Go_To_Shoppingcart(object sender, TappedEventArgs e)
    {
        var newView = new ShoppingCartView();

        Content = newView;
    }
}