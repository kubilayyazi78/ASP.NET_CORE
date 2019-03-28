using Core.DataAccess;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Abstract
{
  public interface IProductDal:IEntityRepository<Product>
    {
        // custom operations
    }
}
