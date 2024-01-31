using Core.Entities.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Site
{
    public class StorageDTO
    {
        public int Id { get; set; }
        public int? ProductQuantity { get; set; }
        public int Size { get; set; }
        public int ProductId { get; set; }
        public bool inStock { get; set; }
    }
}
