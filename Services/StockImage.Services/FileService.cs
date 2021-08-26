using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockImage.Services
{
    public class FileService : IFileService
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        
        public FileService(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }


        public string GetMimeType()
        {
            string fileName = "secondForestFog.jfif";
            // Make Sure Microsoft.AspNetCore.StaticFiles Nuget Package is installed
            var provider = new FileExtensionContentTypeProvider();
            string contentType;
            if (!provider.TryGetContentType(fileName, out contentType))
            {
                contentType = "application/octet-stream";
            }
            return contentType;
        }

        public FileContentResult GetFile()
        {
            string filename = "forest.rar";
            var filepath = Path.Combine($"{this._hostingEnvironment.WebRootPath}\\Files\\{filename}");

            var mimeType = this.GetMimeType();

            byte[] fileBytes;

            if (File.Exists(filepath))
            {
                fileBytes = File.ReadAllBytes(filepath);
            }
            else
            {
                throw new ArgumentException("no such file");
                // Code to handle if file is not present
            }

            return new FileContentResult(fileBytes, mimeType)
            {
                FileDownloadName = filename
            };
        }
    }
}
