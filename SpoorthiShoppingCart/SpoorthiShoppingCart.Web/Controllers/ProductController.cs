using SpoorthiShoppingCart.Web.Models;
using SpoorthiShoppingCart.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpoorthiShoppingCart.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            List<ProductViewModel> viewModelProducts = new List<ProductViewModel>();
            viewModelProducts = productModel.GetAllProducts();
            return View(viewModelProducts);
        }

        public ActionResult Details()
        {
           
            return View();
        }

    }
}