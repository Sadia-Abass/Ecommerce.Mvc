using EasyClothes.Models;
using EasyClothes.ViewModels;

namespace EasyClothes.Services.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductViewModel>> GetAllProductsAsync();
        Task<ProductViewModel> GetProductByIdAsync(long id);
        Task AddAsync(ProductViewModel productViewModel);
        Task DeleteAsync(long id);
        Task UpdateAsync(ProductViewModel productViewModel);
        Task<List<Subcategory>> GetSubcategoriesAsync();
    }
}
