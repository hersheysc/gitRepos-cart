using SpoorthiShoppingCart.BLL.Interfaces;
using SpoorthiShoppingCart.BO;
using SpoorthiShoppingCart.DAL;
using SpoorthiShoppingCart.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoorthiShoppingCart.BLL
{

    public class ProductBLL : IProductBLL
    {
        public List<Product> GetAllProducts()
        {
            ProductDAL productDAL = new ProductDAL();
            List<Product> products = productDAL.GetAllProducts();
            foreach (var item in products)
            {
                if (item.Discontinued == 0)
                {
                    item.UnitPrice = item.UnitPrice + 20;
                }
            }

            return products;
        }
    }
}
