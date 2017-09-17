using SpoorthiShoppingCart.BLL;
using SpoorthiShoppingCart.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProductWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<ProductDataContract> GetAllProducts()
        {
            ProductBLL productBLL = new ProductBLL();
            List<Product> products = productBLL.GetAllProducts();
            List<ProductDataContract> svcProducts = new List<ProductDataContract>();
            foreach (Product product in products)
            {
                ProductDataContract productDataContract = new ProductDataContract();
                productDataContract.ProductID = product.ProductID;
                productDataContract.ProductName = product.ProductName;
                productDataContract.UnitPrice = product.UnitPrice;
                productDataContract.Discontinued = product.Discontinued;
                productDataContract.UnitsInstock = product.UnitsInstock;
                svcProducts.Add(productDataContract);
            }

            return svcProducts;
        }
    }
}
