namespace CountOnIT.Views;

public partial class ShoppingCartView : ContentView
{
	public ShoppingCartView()
	{
		InitializeComponent();
	}

    private void Go_Back_tapped(object sender, TappedEventArgs e)
    {
        var newView = new ProductListView();

        Content = newView;
    }
}