using NUnit.Framework;
using SpoorthiShoppingCart.BO;
using SpoorthiShoppingCart.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoorthiShoppingCart.BLL.Tests
{
    [TestFixture]
    public class ProductBLLTests
    {
        [TestCase]
        public void BLL_GetAllProducts()
        {
            //ProductDAL productDAL = new ProductDAL();
            ProductBLL productsBLL = new ProductBLL();
            List<Product> products = productsBLL.GetAllProducts();
            Assert.AreEqual(77, products.Count);
        }

    }
}
