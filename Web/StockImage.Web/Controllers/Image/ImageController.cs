using Microsoft.AspNetCore.Mvc;
using StockImage.Web.BindingModels;
using StockImage.Data;
using System;
using System.Threading.Tasks;
using StockImage.Web.Data;
using StockImage.Services.Extensions;
using System.Collections.Generic;
using System.Linq;
using StockImage.Web.ViewModels;

namespace StockImage.Web.Controllers.Image
{
    public class ImageController : Controller
    {
        private readonly StockImageDb _context;

        private readonly ICloudinaryService _cloudinaryService;

        public ImageController(StockImageDb context, ICloudinaryService cloudinaryService)
        {
            _context = context;
            _cloudinaryService = cloudinaryService;
        }

        [HttpGet]
        public IActionResult Create()
        {
             return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ImageCreateBindingModel bindingModel)
        {
            string pictureUrl = await this._cloudinaryService.UploadPicture(
                    bindingModel.Picture,
                    bindingModel.Title);

            if (this.ModelState.IsValid)
            {
                StockImage.Data.Models.Image image = new StockImage.Data.Models.Image
                {
                    CreatorName = bindingModel.CreatorName,
                    Title = bindingModel.Title,
                    Picture = pictureUrl
                };

                

                image.Id = Guid.NewGuid().ToString();

                await _context.Images.AddAsync(image);
                await _context.SaveChangesAsync();

                return RedirectToAction("All");
            }


            return this.View();
        }

        public IActionResult All()
        {
            List<ImageViewModel> images = _context.Images
                .Select(imagesFromDb => new ImageViewModel
                {
                    CreatorName = imagesFromDb.CreatorName,
                    Title = imagesFromDb.Title,
                    Picture = imagesFromDb.Picture
                })
                .ToList();

            return this.View(images);
        }



    }
}
