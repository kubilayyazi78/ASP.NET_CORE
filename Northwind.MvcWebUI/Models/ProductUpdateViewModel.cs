using System.Collections.Generic;
using Northwind.Entites.Concrete;

namespace Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}