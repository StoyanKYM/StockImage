using Microsoft.AspNetCore.Mvc;
using StockImage.Data.Models;
using StockImage.Services;
using StockImage.Web.BindingModels;
using StockImage.Web.Data;
using StockImage.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockImage.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly StockImageDb _context;


        public HomeController(StockImageDb context)
        {
            
            this._context = context;

        }
        public IActionResult Index()
        {
            List<CommentViewModel> allComments = this._context.Comments.Select(commentsFromDb => new CommentViewModel
            {
                Title = commentsFromDb.Title,
                Content = commentsFromDb.Content,
                CreatedOn = commentsFromDb.CreatedOn
            })
                .OrderByDescending(date => date.CreatedOn)
                .ToList();

            return View(allComments);
        }
 
    }
}
