
using CountOnIT.Models;
using CountOnIT.ViewModels;

namespace CountOnIT.Views;

public partial class ProductListView : ContentView
{
    bool isView1Visible = true;

    public ProductListView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Skift mellem View1 og View2
        if (isView1Visible)
            ShowView2();
        else
            ShowView1();

        // Skift tilstanden for isView1Visible
        isView1Visible = !isView1Visible;
    }
    private void ShowView1()
    {
        // Vis View1
        ProductView.Content = new ProductListView();
    }

    private void ShowView2()
    {
        // Vis View2
        ProductView.Content = new ProductView();
    }
}