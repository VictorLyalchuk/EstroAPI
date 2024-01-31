using Core.DTOs.Site;
using Core.Entities.Site;

namespace Core.Interfaces
{
    public interface ICategoryService
    {
        Task<List<MainCategoryDTO>> MainGetAllAsync();
        Task<List<SubCategoryDTO>> SubGetAllAsync();
        Task<List<CategoryDTO>> GetAllAsync();
        Task<MainCategoryDTO?> MainGetByIdAsync(int id);
        Task<List<CategoryDTO>> CategoryGetWithSubAsync(string subName);
    }
}
