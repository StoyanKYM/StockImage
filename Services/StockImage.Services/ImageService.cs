using StockImage.Web.Data;
using StockImage.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Services
{
    public class ImageService : IImageService
    {
        private readonly StockImageDbContext context;

        public ImageService(StockImageDbContext context)
        {
            this.context = context;
        }
        public async Task<IQueryable<ImageViewModel>> GetAllImages()
        {
            return this.context.Images.Select(image => new ImageViewModel
            {
                CreatorName = image.CreatorName,
                Title = image.Title,
                Picture = image.Picture
            });
        }
    }
}
