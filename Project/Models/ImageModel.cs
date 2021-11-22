using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ImageModel
    {
        public IEnumerable<ImageClass> image { get; set; }
        public string Search { get; set; }
    }
}
