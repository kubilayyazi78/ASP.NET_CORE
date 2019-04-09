using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
       private ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        //public ViewComponentResult Invoke()
        //{
        //    var model = new CategoryListViewModel
        //    {
        //        Categories=_categoryService.GetAll()
        //    };
        //    return View(model);
        //}
    }
}
