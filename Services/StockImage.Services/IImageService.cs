using StockImage.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Services
{
    public interface IImageService
    {
        Task<IQueryable<ImageViewModel>> GetAllImages();
    }
}
