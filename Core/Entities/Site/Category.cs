using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Site
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string URLName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public ICollection<Product> Products { get;  } = new List<Product>();
        public int? SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
    }
}
