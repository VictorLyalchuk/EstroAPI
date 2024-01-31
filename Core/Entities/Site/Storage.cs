using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Site
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }
        public int? ProductQuantity { get; set; }
        public int Size { get; set; }
        public int ProductId { get; set; }
        public bool inStock  { get; set; } = false;
        public Product? Product { get; set; }
    }
}
