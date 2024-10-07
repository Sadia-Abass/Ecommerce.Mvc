using EasyClothes.Areas.Identity.Data;
using EasyClothes.Models;
using EasyClothes.Services.Interfaces;
using EasyClothes.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace EasyClothes.Services.Implementations
{
    public class SubcategoryRepository : ISubcaegoryRepository
    {
        private readonly ApplicationDbContext _context;

        public SubcategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(SubcategoryViewModel subcategoryViewModel)
        {
            var subcategory = new Subcategory 
            {
                Name = subcategoryViewModel.Name,
                SubcategoryId = subcategoryViewModel.SubcategoryId, 
                DateCreated = DateTime.UtcNow,
            };

            await _context.Subcategory.AddAsync(subcategory);
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<SubcategoryViewModel>> GetAllAsync()
        {
            return  _context.Subcategory.Select(e => new SubcategoryViewModel
            {
                Name = e.Name,
                SubcategoryId = e.SubcategoryId,
                DateCreated = e.DateCreated,
                DateUpdated = e.DateUpdated
            });
        }

        public async Task DeleteAsync(long id)
        {
            var subcategory = await _context.Subcategory.FindAsync(id);
            if(subcategory != null)
            {
                _context.Subcategory.Remove(subcategory);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<SubcategoryViewModel> GetByIdAsync(long id)
        {
            var subcategory = await _context.Subcategory.FindAsync(id);
            var subcategoryViewModel = new SubcategoryViewModel
            {
                Name = subcategory.Name,
                SubcategoryId= subcategory.SubcategoryId,
                DateCreated = subcategory.DateCreated,
                DateUpdated = subcategory.DateUpdated
            };

            return subcategoryViewModel;
        }

        public async Task UpdateAsync(SubcategoryViewModel subcategoryViewModel)
        {
            var subcategory = await _context.Subcategory.FindAsync(subcategoryViewModel.SubcategoryId);
            if(subcategory != null)
            {
                subcategory.Name = subcategoryViewModel.Name;
                subcategory.SubcategoryId = subcategoryViewModel.SubcategoryId;
                subcategory.DateUpdated = DateTime.UtcNow;
            }
            _context.Subcategory.Update(subcategory);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _context.Category.ToListAsync();
        }
    }
}
