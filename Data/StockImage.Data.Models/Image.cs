using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Data.Models
{
    public class Image
    {
        public string Id { get; set; }

        public string CreatorName { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }

        public DateTime UploadedOn { get; set; } = DateTime.UtcNow;
    }
}
