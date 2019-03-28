﻿using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
