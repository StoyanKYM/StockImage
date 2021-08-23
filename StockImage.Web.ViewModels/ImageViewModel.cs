using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Web.ViewModels
{
    public class ImageViewModel
    {
        public string Id { get; set; }

        public string CreatorName { get; set; }

        public string Title { get; set; }

        public string Picture { get; set; }
    }
}
