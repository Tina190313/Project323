using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
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
        public IActionResult Image()
        {
            var snowImageTag = new List<Tag>();
            var raindropImageTag = new List<Tag>();
            var photolist = new List<ImageClass>();

            var tagrain = new Tag()
            {
                TagId = 1,
                Description = "Rain "
               
            };
            var tagsnow = new Tag()
            {
                TagId = 2,
                Description = "Snow"
            };

            snowImageTag.Add(tagsnow);
            raindropImageTag.Add(tagrain);


            {
                new ImageClass()
                {
                    Name = "Snow",
                    CaptureDate = DateTime.Now,
                    Geolocation = "https://images.pexels.com/photos/839462/pexels-photo-839462.jpeg",
                    CaptureBy = "Jerry",
                    Tag = snowImageTag,
                };
                new ImageClass()
                {
                    Name = "Rain Drop",
                    CaptureDate = DateTime.Now,
                    Geolocation = "https://images.pexels.com/photos/1100946/pexels-photo-1100946.jpeg",
                    CaptureBy = "Tim Burton",
                    Tag = raindropImageTag,
                };
               

            };
            var model = new ImageModel()
            {
                image = photolist,
                Search = ""
            };

            return View(model);


        }
        
        
    }
       

        //private readonly IConfiguration configuration;
        
        //public ImageController(IConfiguration config)
        //{
        //    configuration = config;
        //}
        //[HttpGet]
        //public IActionResult Image()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Image(IFormFile form)
        //{
        //    string systemFileName = form.FileName;
        //    string blobstorageconnection = configuration.GetValue<string>("blobstorage");
        //    byte[] files;
        //    CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(blobstorageconnection);
        //    CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
        //    CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("imagecontainer");
        //    BlobContainerPermissions permissions = new BlobContainerPermissions
        //    {
        //        PublicAccess = BlobContainerPublicAccessType.Blob
        //    };

        //    await cloudBlobContainer.SetPermissionsAsync(permissions);
        //    await using (var target = new MemoryStream())
        //    {
        //        form.CopyTo(target); files = target.ToArray();
        //    }
        //    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(systemFileName);
        //    await using (var data = form.OpenReadStream())
        //    {
        //        await cloudBlockBlob.UploadFromStreamAsync(data);
        //    }


        //    return View("Create");

        //}




        //public async Task<IActionResult> ShowAllBlobs()
        //{
        //    string blobstorageconnection = configuration.GetValue<string>("blobstorage");
        //    CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(blobstorageconnection);
        //    CloudBlobClient blobClient = cloudStorageAccount.CreateCloudBlobClient();
        //    CloudBlobContainer container = blobClient.GetContainerReference("imagecontainer");
        //    CloudBlobDirectory dirb = container.GetDirectoryReference("imagecontainer");
        //    BlobResultSegment resultSegment = await container.ListBlobsSegmentedAsync(string.Empty, true, BlobListingDetails.Metadata, 100, null, null, null);
        //    var filelist = new List<FileList>();
        //    foreach (var blobItem in resultSegment.Results)
        //    {
        //        var blob = (CloudBlob)blobItem; fileList.Add(new FileData()
        //        {
        //            FileName = blob.Name,
        //            FileSize = Math.Round((blob.Properties.Length / 1024f) / 1024f, 2).ToString(),
        //            ModifiedOn = DateTime.Parse(blob.Properties.LastModified.ToString()).ToLocalTime().ToString()
        //        });
        //    }
        //    return View(fileList);
        //}
    

  
}
