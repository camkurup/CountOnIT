using CountOnIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOnIT.Interfaces
{
    public interface IShoppingService
    {
        public IReadOnlyList<Product> GetProducts();
    }
}
