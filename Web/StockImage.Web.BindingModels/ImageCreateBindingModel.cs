using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
