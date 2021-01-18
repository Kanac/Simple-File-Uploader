using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Controllers
{
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpGet]
        [Route("test")]
        public async Task<string> Test([FromForm] IFormFile file)
        {
            return "hello";
        }

        [HttpPost]
        [Route("api/upload/file")]
        public async Task<string> UploadFile([FromForm] IFormFile file)
        {
            string path = Guid.NewGuid() + " " + file.FileName;
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return file.FileName;
        }

    }
}
