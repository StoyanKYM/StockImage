using Microsoft.AspNetCore.Mvc;
using StockImage.Services;

namespace StockImage.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _hService;

        public HomeController(IHomeService hService)
        {
            
            this._hService = hService;
        }
        public IActionResult Index()
        {

            var allComments = _hService.GetAllComments();
            

            return View(allComments);
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
