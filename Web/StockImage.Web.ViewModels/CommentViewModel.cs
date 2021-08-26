using System;

namespace StockImage.Web.ViewModels
{
    public class CommentViewModel
    {
        public string CurrentUser { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
