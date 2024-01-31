using Core.Entities.Site;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Site
{
    public class SubCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public int? MainCategoryId { get; set; }
        public MainCategory? MainCategory { get; set; }
    }
};

