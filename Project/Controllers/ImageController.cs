using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Project.Data;
using Project.Data.Models;
using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Project.Controllers
{
    public class ImageController : Controller
    {
        private readonly Images _service;
        public ImageController(Images service)
        {
            _service = service;
        }
        public IActionResult Image()
        {
            var photolist = _service.GetAll();
            var model = new ImageModel()
            {
                image = photolist,
                Search = ""
            };

            return View(model);


        }
        public IActionResult Detail(int photoId)
        {
            var image = _service.GetId(photoId);

            var model = new ImageClass()
            {
                Photo_Id = image.Photo_Id,
                Name = image.Name,
                CaptureDate = image.CaptureDate,
                Geolocation = image.Geolocation,
                CaptureBy = image.CaptureBy,
                Tag = (IEnumerable<Tag>)image.Tag.Select(tg => tg.Description).ToList()


            };
            return View(model);
                
        }
    }


 



}
