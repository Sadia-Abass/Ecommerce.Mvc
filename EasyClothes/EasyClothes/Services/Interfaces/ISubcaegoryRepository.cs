using EasyClothes.Models;
using EasyClothes.ViewModels;

namespace EasyClothes.Services.Interfaces
{
    public interface ISubcaegoryRepository
    {
        Task<SubcategoryViewModel> GetByIdAsync(long id);
        Task<IQueryable<SubcategoryViewModel>> GetAllAsync();
        Task AddAsync(SubcategoryViewModel subcategoryViewModel);
        Task UpdateAsync(SubcategoryViewModel subcategoryViewModel);
        Task DeleteAsync(long id);
    }
}
