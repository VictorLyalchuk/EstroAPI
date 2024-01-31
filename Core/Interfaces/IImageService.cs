using Core.DTOs.Site;
using Core.Entities.Site;
using Microsoft.AspNetCore.Http;

namespace Core.Interfaces
{
    public interface IImageService
    {
        Task <Image> CreateImageAsync(IFormFile ImageFile);
        Task CreateAsync(ImageDTO imageDTO);
        Task <List<ImageDTO>>? GetImageByIDProductAsync(int id);
        Task DeleteAsync(int id);
        Task DeleteImageAsync(ImageDTO imageDTO);
        Task<ImageDTO> GetByIdAsync(int id);
        Task EditAsync(ImageDTO imageDTO);

        Task DeleteUserImageAsync(string image);
        Task<string> CreateUserImageAsync(IFormFile ImageFile);
    }
}
