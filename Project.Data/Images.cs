using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data
{
    public interface Images
    {
        IEnumerable<ImageClass> GetAll();
        IEnumerable<ImageClass> GetTag(string tag);
    
        ImageClass GetId(int photoId);


    }
}
