using Microsoft.AspNetCore.Mvc;
using StockImage.Services;

namespace StockImage.Web.Controllers.Download
{
    public class DownloadController : Controller
    {
        private readonly IFileService _fService;

        public DownloadController(IFileService fService)
        {
            this._fService = fService;
        }
        public IActionResult Download()
        {
            var file = _fService.GetFile();

            return file;
        }        
    }
}
