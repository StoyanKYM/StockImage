using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace StockImage.Web.BindingModels
{
    public class ImageCreateBindingModel
    {
        [Required]
        [Display(Name = "Author")]
        public string CreatorName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public IFormFile Picture { get; set; }
    }
}
