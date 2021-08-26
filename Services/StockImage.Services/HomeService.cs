using StockImage.Web.Data;
using StockImage.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace StockImage.Services
{
    public class HomeService : IHomeService
    {
        private readonly StockImageDbContext _context;

        public HomeService(StockImageDbContext context)
        {
            this._context = context;
        }
        public List<CommentViewModel> GetAllComments()
        {
            List<CommentViewModel> allComments = this._context.Comments.Select(commentsFromDb => new CommentViewModel
            {
                CurrentUser = commentsFromDb.UserName,
                Title = commentsFromDb.Title,
                Content = commentsFromDb.Content,
                CreatedOn = commentsFromDb.CreatedOn
            })
                .OrderByDescending(date => date.CreatedOn)
                .ToList();

            return allComments;
        }
    }
}
