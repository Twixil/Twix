using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace probnielist.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod.price;

            }
            return total;
        }


    }
}
