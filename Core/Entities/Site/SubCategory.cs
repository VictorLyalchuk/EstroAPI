using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Site
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string URLName { get; set; }
        public string? ImagePath { get; set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public int? MainCategoryId { get; set; }
        public MainCategory? MainCategory { get; set; }
    }
}
