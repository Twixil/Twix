using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace probnielist.Models
{
    public class Product
    {
        public int productID { get; set; }
        private string name;
        public string Name
        {
            get { return productID + name; }
            set { name = value; }
        }

        internal static IEnumerator<Product> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public string Description { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }


    }
}
