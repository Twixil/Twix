using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using probnielist.Models;

namespace probnielist.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public static string Index()
        {
            return "Navigate to a URL to whow an example ";
        }

        public ViewResult UseExtension
        {
            get
            {
                ShoppingCart cart = new ShoppingCart
                {
                    Products = new List<Product>
                {
                    new Product {Name ="kayak",price=275M },
                    new Product{Name="Lifejacket",price =48.95M },
                    new Product{Name="Soccer ball",price=19.50M},
                    new Product{Name="Corner",price=34.95M}
                }
                };
                decimal cartTotal = cart.TotalPrices();
                return View("Result", (object)$"Total : {cartTotal:c}");
            }
        }
    }
}
