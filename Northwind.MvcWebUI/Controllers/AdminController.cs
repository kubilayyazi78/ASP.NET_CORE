using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Entites.Concrete;
using Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MvcWebUI.Controllers
{
    public class AdminController:Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;
        public AdminController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }

        public ActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product=new Product(),
                Categories=_categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", "Product was successfully added");
            }

            return RedirectToAction("Add");
        }


    }
}
