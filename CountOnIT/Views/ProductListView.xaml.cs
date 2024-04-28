using CountOnIT.Models;
using CountOnIT.Data;

namespace CountOnIT.Views;

public partial class ProductListView : ContentView
{
    public List<ProductModel> Products { get; set; }
    public ProductListView()
	{
		InitializeComponent();

        // Opret en instans af DataAccess-klassen
        DataAccess dataAccess = new DataAccess();

        // Hent produkter ved at kalde GetProducts-metoden fra DataAccess-klassen
        Products = dataAccess.GetProduct();
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