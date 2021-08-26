using System;

namespace StockImage.Data.Models
{
    public class Image
    {
        public string Id { get; set; }

        public string CreatorName { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }

        public DateTime UploadedOn { get; set; } = DateTime.UtcNow.AddHours(3);
    }
}
