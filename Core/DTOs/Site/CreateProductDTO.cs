using Core.Entities.Site;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Site
{
    public class CreateProductDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Purpose { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Article { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
        //[BindProperty(Name = "ImagesFile[]")]
        //public List<IFormFile>? ImagesFile { get; set; }
        public List<Image>? ImagesFile { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public int? StorageId { get; set; }
        public int StorageQuantity { get; set; }
    }
}