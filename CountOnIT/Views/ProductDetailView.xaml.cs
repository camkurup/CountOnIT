namespace CountOnIT.Views;

public partial class ProductDetailsView : ContentView
{
    int count = 0;

    public ProductDetailsView()
    {
        InitializeComponent();
    }

    private void GoToShoppingCart(object sender, TappedEventArgs e)
    {
    }

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CartItemCount.Text = $"{count} ";
        else
            CartItemCount.Text = $" {count} ";

        SemanticScreenReader.Announce(CartItemCount.Text);
    }

    private void SubtractButton_Clicked(object sender, EventArgs e)
    {
        count--;

        if (count > -1)
            CartItemCount.Text = $"{count} ";
        if (count < 0)
            count = 0;

        SemanticScreenReader.Announce(CartItemCount.Text);
    }
}