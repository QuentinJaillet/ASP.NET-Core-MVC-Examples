using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models.ProductItemViewModels;

namespace MyWebApp.Controllers
{
    public class ProductController : Controller
    {
        private static List<ProductItemViewModel> products = new List<ProductItemViewModel>();

        public ProductController()
        {
            products.Add(new ProductItemViewModel { Id = 1, Name = "Plop" });
            products.Add(new ProductItemViewModel { Id = 2, Name = "Plop" });
            products.Add(new ProductItemViewModel { Id = 3, Name = "Plop" });
            products.Add(new ProductItemViewModel { Id = 4, Name = "Plop" });
        }

        public IActionResult Index()
        {
            return View(products);
        }
    }
}
