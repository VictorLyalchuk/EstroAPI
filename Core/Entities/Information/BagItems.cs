﻿using Core.Entities.Site;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Information
{
    public class BagItems
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public int Size { get; set; }
        public int BagId { get; set; }
        public Bag? Bag { get; set; }
    }
}
