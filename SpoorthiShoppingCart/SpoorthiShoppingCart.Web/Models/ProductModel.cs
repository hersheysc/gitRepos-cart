
using SpoorthiShoppingCart.Web.ProductServiceProxyV2;
using SpoorthiShoppingCart.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpoorthiShoppingCart.Web.Models
{
    public class ProductModel
    {
        public List<ProductViewModel> GetAllProducts()
        {

            Service1Client serviceClient = new Service1Client();
            var products = serviceClient.GetAllProducts().ToList();
            List<ProductViewModel> viewModelProducts = new List<ProductViewModel>();
            foreach (var item in products)
            {
                ProductViewModel productViewModel = new ProductViewModel();
                productViewModel.ProductID = item.ProductID;
                productViewModel.ProductName = item.ProductName;
                productViewModel.UnitPrice = item.UnitPrice;
                productViewModel.Discontinued = item.Discontinued;
                productViewModel.UnitsInstock = item.UnitsInstock;
            
                viewModelProducts.Add(productViewModel);
            }

            return viewModelProducts;
        }
    }
}