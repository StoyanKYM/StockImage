using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Web.ViewModels
{
    public class ParentViewModel
    {
        public CommentViewModel Comment { get; set; }
        public IndexModel IndexModel { get; set; }
    }
}
