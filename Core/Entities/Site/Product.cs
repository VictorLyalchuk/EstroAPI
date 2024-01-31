using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Site
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Article { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Purpose { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
        public List<Image>? Images { get; set; }
        //public string ReactCategoryName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        //public int? StorageId { get; set; }
        public List<Storage>? Storages { get; set; }
    }
}
