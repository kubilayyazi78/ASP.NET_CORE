using System;
using System.Linq;
using System.Text;

namespace Northwind.Entites.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
