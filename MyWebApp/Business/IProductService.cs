using System.Collections.Generic;
using MyWebApp.Business.Models;

namespace MyWebApp.Business
{
    public interface IProductService
    {
        List<Product> GetProducts();
        
        void Create(string name, string description);
        
        Product GetProductById(int id);
    }
}