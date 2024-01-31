﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Site
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
