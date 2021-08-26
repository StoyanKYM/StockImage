using StockImage.Web.ViewModels;
using System.Collections.Generic;

namespace StockImage.Services
{
    public interface IHomeService
    {
        public List<CommentViewModel> GetAllComments();
    }
}
