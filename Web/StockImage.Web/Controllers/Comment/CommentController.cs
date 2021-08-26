using Microsoft.AspNetCore.Mvc;
using StockImage.Web.BindingModels;
using StockImage.Web.Data;
using StockImage.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockImage.Web.Controllers.Comment
{
    public class CommentController : Controller
    {

        private readonly StockImageDbContext _context;


        public CommentController(StockImageDbContext context)
        {
            this._context = context;

        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CommentCreateBindingModel bindingModel)
        {
            var comment = new StockImage.Data.Models.Comment()
            {
                UserName = this.User.Identity.Name,
                Title = bindingModel.Title,
                Content = bindingModel.Content
            };

            comment.Id = Guid.NewGuid().ToString();



            this._context.Comments.Add(comment);
            this._context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        
    }
}
