using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ImageClass
    {


        [Key]
        public int Photo_Id { get; set; }
        public string Name { get; set; }
        public DateTime CaptureDate { get; set; }
        public string Geolocation { get; set; }
        public string CaptureBy { get; set; }
        public virtual IEnumerable <Tag> Tag { get; set; }
       

    }
}
