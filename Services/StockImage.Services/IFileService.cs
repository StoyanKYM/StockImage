using Microsoft.AspNetCore.Mvc;

namespace StockImage.Services
{
    public interface IFileService
    {
        string GetMimeType();
        FileContentResult GetFile();
    }
}
