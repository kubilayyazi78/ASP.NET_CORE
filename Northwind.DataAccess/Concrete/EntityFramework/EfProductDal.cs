using Core.DataAccess.EntityFramework;
using Northwind.DataAccess.Abstract;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
  public  class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
