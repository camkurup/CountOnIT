using CountOnIT.Controllers;

namespace CountOnIT.Views;

public partial class ProductView : ContentView
{
    int count = 0;

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

    private void Button_Clicked_Add(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CountUp.Text = $"{count} ";
        else
            CountUp.Text = $" {count} ";

        SemanticScreenReader.Announce(CountUp.Text);
    }

    private void Button_Clicked_Subtracked(object sender, EventArgs e)
    {
        count--;

        if (count > -1)
            CountUp.Text = $"{count} ";
        if (count < 0)
            count = 0;

        SemanticScreenReader.Announce(CountUp.Text);
    }
}