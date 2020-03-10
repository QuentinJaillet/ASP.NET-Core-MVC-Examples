using System;
using System.Collections.Generic;
using System.Linq;
using MyWebApp.Business.Models;

namespace MyWebApp.Business
{
    public class ProductService : IProductService
    {
        private static List<Product> Products = new List<Product>();

        public void Create(string name, string description)
        {
            var product = new Product();
            product.CreationDate = DateTime.Now;
            product.Description = description;
            product.Name = name;

            var lastProduct = Products.OrderBy(s => s.CreationDate).FirstOrDefault();
            if (lastProduct == null)
                product.Id = 1;
            else
                product.Id = lastProduct.Id + 1;

            Products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}