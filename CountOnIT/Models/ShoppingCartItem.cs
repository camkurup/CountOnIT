using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOnIT.Models
{
    public class ShoppingCartItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
