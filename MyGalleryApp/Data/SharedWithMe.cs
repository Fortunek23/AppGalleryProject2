using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyGalleryApp.Data
{
    public class SharedWithMe
    {
        [Key]
        public int ShareId { get; set; }
        public int PhotoId { get; set; }

        public string Name { get; set; }

        public string UserId { get; set; }
    }
}
