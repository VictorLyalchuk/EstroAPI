﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Site
{
    public class ImageForHome
    {
        [Key]
        public int Id { get; set; }
        public string? ImagePath { get; set; }
    }
}
