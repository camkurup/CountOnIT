
using CountOnIT.Models;
using CountOnIT.ViewModels;

namespace CountOnIT.Views;

public partial class ProductListView : ContentView
{

    public ProductListView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        // Opret en ny instans af det nye view
        var newView = new ProductView();

        // Erstat det nuværende view med det nye view
        Content = newView;
    }
    
}