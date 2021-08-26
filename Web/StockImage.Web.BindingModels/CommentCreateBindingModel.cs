using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Web.BindingModels
{
    public class CommentCreateBindingModel
    {
        public string UserName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Title must be atleast 2 characters long.", MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Description must be atleast 5 characters long.", MinimumLength = 5)]
        public string Content { get; set; }
    }
}
