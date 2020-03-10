using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models.ProductItemViewModels
{
    public class EditProductViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}