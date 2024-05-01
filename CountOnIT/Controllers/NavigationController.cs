using CountOnIT.Views;
using CountOnIT.ViewModels;

namespace CountOnIT.Controllers
{
    public class NavigationController
    {
  
        private void GoToShoppingcart(ContentView currentPage)
        {
            
            var newView = new ShoppingCartView();

            currentPage.Content = newView;
        }

        //In this method I should consiter making it dynamic.
        //newView shoul call the view the user came from and not just go back to ProductListView as default
        //I could do something like this:

        //if(came from x)
        //{ go back to x}
        //else{ go back to y}

        private void GoBack(ContentView currentPage)
        {
            var newView = new ProductListView();

            newView.Content = newView;
        }
    }
}