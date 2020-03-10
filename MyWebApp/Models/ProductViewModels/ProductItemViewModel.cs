using System;

namespace MyWebApp.Models.ProductItemViewModels
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public DateTime CreationDate { get; set; }
    }
}