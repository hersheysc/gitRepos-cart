using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpoorthiShoppingCart.Web.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Discontinued { get; set; }
        public int UnitsInstock { get; set; }
    }
}