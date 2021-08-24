using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Services
{
    public interface IFileService
    {
        string GetMimeType();
        FileContentResult GetFile();
    }
}
