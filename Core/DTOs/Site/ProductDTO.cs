﻿using Core.Entities.Site;

namespace Core.DTOs.Site
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Purpose { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Article { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
        public List<Image>? Images { get; set; }
        public List<string>? ImagesPath { get; set; }
        //public List<Image>? ImagesFile { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string SubCategoryName { get; set; } = string.Empty;
        public string MainCategoryName { get; set; } = string.Empty;
        public List<Storage>? Storages { get; set; }
        public int StorageQuantity { get; set; }
        public string URLCategoryName { get; set; } = string.Empty;
        public string URLSubCategoryName { get; set; } = string.Empty;
        public string URLMainCategoryName { get; set; } = string.Empty;
    }
}