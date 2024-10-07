using EasyClothes.ViewModels;

namespace EasyClothes.Services.Interfaces
{
    public interface ICategoryRepository
    {
        Task<CategoryViewModel> GetByIdAsync(long id);
        Task<IQueryable<CategoryViewModel>> GetAllAsync();
        Task AddAsync(CategoryViewModel categoryViewModel);
        Task UpdateAsync(CategoryViewModel categoryViewModel);
        Task DeleteAsync(long id);
    }
}
