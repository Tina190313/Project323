using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Project.Service
    
{
    public class ServiceImages : Images
    {
        private readonly ProjectDb ct;
        public ServiceImages(ProjectDb cx)
        {
            ct = cx;
        }
        public IEnumerable<ImageClass> GetAll()
        {
            return ct.ImageClass.Include(ig => ig.Tag);

        }

        public ImageClass GetId(int photoId)
        {
            return ct.ImageClass.Find(photoId);
        }

        public IEnumerable<ImageClass> GetTag(string tag)
        {
            return GetAll().Where(ig => ig.Tag.Any(tg => tg.Description == tag));
        }
    }
}
