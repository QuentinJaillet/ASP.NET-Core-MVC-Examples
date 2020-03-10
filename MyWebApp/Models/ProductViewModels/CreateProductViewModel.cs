using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models.ProductItemViewModels
{
    public class CreateProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}