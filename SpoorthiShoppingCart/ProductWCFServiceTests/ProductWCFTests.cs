using NUnit.Framework;
using ProductWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWCFServiceTests
{
    [TestFixture]
    public class ProductWCFTests
    {
        [TestCase]
        public void WCF_GetAllProducts()
        {
            Service1 service1 = new Service1();
            List<ProductDataContract> svcProducts = service1.GetAllProducts();
            Assert.AreEqual(77, svcProducts.Count);
        }
    }
}
