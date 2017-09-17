using SpoorthiShoppingCart.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoorthiShoppingCart.BLL.Interfaces
{
    public interface IProductBLL
    {
        List<Product> GetAllProducts();
    }
}
