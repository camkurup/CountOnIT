namespace CountOnIT.Views;

public partial class ShoppingCartView : ContentView
{
	public ShoppingCartView()
	{
		InitializeComponent();
	}

    // should call method from NavigationController
    private void Go_Back_tapped(object sender, TappedEventArgs e)
    {
        var newView = new ProductListView();

        Content = newView;
    }
}