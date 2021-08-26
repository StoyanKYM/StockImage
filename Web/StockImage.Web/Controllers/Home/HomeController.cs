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
