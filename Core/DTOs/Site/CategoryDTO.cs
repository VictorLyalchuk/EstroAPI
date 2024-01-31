using Core.Entities.Site;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Site
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string URLName { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        public int? SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
        public int? MainCategoryId { get; set; }
        public MainCategory? MainCategory { get; set; }
    }
}
