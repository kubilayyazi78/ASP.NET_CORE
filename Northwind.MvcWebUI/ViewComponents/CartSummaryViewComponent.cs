using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Northwind.MvcWebUI.Models;
using Northwind.MvcWebUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MvcWebUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        ICartSessionService _cartSessionService;
        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    }
}
