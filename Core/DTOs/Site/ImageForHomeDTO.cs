using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Site
{
    public class ImageForHomeDTO
    {
        public int Id { get; set; }
        public string? ImagePath { get; set; }
    }
}
