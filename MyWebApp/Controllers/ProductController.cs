using Microsoft.AspNetCore.Mvc;
using MyWebApp.Business;
using MyWebApp.Business.Models;
using MyWebApp.Models.ProductItemViewModels;

namespace MyWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = _productService.GetProducts().ConvertAll(ConvertToProductItemViewModel);

            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            if (isAjax)
            {
                return PartialView("_Products", products);
            }

            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("_CreateModal", new CreateProductViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateProductViewModel model)
        {
            if (ModelState.IsValid)
                _productService.Create(model.Name, model.Description);

            return PartialView("_CreateModal", model);
        }

        private ProductItemViewModel ConvertToProductItemViewModel(Product product)
        {
            return new ProductItemViewModel
            {
                Id = product.Id,
                Name = product.Name,
                LastUpdatedDate = product.LastUpdatedDate,
                CreationDate = product.CreationDate
            };
        }
    }
}
