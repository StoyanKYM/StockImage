using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Data.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        
        public string Title { get; set; }
        
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow.AddHours(3);

    }
}
