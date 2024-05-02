namespace CountOnIT.Models
{
    public class ShoppingCart
    {
        private readonly List<ShoppingCartItem> items = new List<ShoppingCartItem>();

        public ShoppingCart()
        {
        }

        public List<ShoppingCartItem> Items => items;
    }
}
