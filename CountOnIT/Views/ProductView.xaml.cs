using CountOnIT.Controllers;
using CountOnIT.ViewModels;

namespace CountOnIT.Views;

public partial class ProductView : ContentView
{
    int count = 0;

    public ProductView(ProductViewModel viewModel)
	{
		InitializeComponent();

        ContentView.BindingContext = viewModel;

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

    private void Button_Clicked_Add(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CartItemCount.Text = $"{count} ";
        else
            CartItemCount.Text = $" {count} ";

        SemanticScreenReader.Announce(CartItemCount.Text);
    }

    private void Button_Clicked_Subtracked(object sender, EventArgs e)
    {
        count--;

        if (count > -1)
            CartItemCount.Text = $"{count} ";
        if (count < 0)
            count = 0;

        SemanticScreenReader.Announce(CartItemCount.Text);
    }
}