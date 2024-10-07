using EasyClothes.Areas.Identity.Data;
using EasyClothes.Models;
using EasyClothes.Services.Interfaces;
using EasyClothes.ViewModels;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace EasyClothes.Services.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task AddAsync(CategoryViewModel categoryViewModel)
        {
            var category = new Category 
            { 
                Name = categoryViewModel.Name,
                DateCreated = DateTime.UtcNow,
                //IsDeleted = categoryViewModel.IsDeleted,
            };

            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category != null)
            {
                _context.Category.Remove(category);
                await _context.SaveChangesAsync();
            }
             
        }

        public async Task<IQueryable<CategoryViewModel>> GetAllAsync()
        {
            //var category = await _context.Category.ToListAsync();
            return _context.Category.Select(e => new CategoryViewModel 
            { 
                Name = e.Name,
                DateCreated = e.DateCreated,
                DateUpdated = e.DateUpdated,
                //IsDeleted = e.IsDeleted,
            });
        }

        public async Task<CategoryViewModel> GetByIdAsync(long id)
        {
            var category = await _context.Category.FindAsync(id);
            var categoryViewModel = new CategoryViewModel
            {
                Name = category.Name,
                DateCreated = category.DateCreated,
                DateUpdated = category.DateUpdated,
                //IsDeleted = category.IsDeleted
            };

            return categoryViewModel;
        }

        public async Task UpdateAsync(CategoryViewModel categoryViewModel)
        {
            var category = await _context.Category.FindAsync(categoryViewModel.CategoryID);
            if (category != null)
            {
                category.Name = categoryViewModel.Name;
                category.DateUpdated = DateTime.UtcNow;
                //category.IsDeleted = categoryViewModel.IsDeleted;
            }

            _context.Category.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
