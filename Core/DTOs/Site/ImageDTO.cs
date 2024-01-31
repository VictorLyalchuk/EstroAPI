using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.DTOs.Site
{
    public class ImageDTO
    {
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        public int ProductId { get; set; }
    }
}
