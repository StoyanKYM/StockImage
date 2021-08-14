using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Web.BindingModels
{
    public class ImageCreateBindingModel
    {
        public string CreatorName { get; set; }
        public string Title { get; set; }
        public IFormFile Picture { get; set; }
    }
}
