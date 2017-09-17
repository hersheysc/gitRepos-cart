using NUnit.Framework;
using SpoorthiShoppingCart.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoorthiShoppingCart.DAL.UnitTests
{
    [TestFixture]
    public class ProductDALTests
    {
        [TestCase]
        public void DAL_GetAllProductsTest()
        {
            ProductDAL productDAL = new ProductDAL();
           List<Product> products = productDAL.GetAllProducts();
            
            Assert.AreEqual(77, products.Count);
        }
    }
}
