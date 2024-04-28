using CountOnIT.Views;

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

     

        public void GoBack()
        {
            var newView = new ProductListView(); 
            
            newView.Content = newView;
        }
    }
}