using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace StockImage.Services.Extensions
{
    public interface ICloudinaryService
    {
        Task<string> UploadPicture(IFormFile pictureFile, string fileName);
    }
}
