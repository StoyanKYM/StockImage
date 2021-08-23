using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Web.ViewModels
{
    public class CommentViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
