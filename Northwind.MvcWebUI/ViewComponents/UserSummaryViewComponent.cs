using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Northwind.MvcWebUI.Models;

namespace Northwind.MvcWebUI.ViewComponents
{
    public class UserSummaryViewComponent : ViewComponent
    { 
        public ViewViewComponentResult Invoke()
        {
          
            UserDetailsViewModel model = new UserDetailsViewModel
            {
                UserName = HttpContext.User.Identity.Name
            };

            return View(model);
        }
    }
}
