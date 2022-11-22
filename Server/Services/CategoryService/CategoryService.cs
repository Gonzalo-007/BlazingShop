using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
            
        public async Task<List<Category>> GetCategories()
        {
            
            return await _dataContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategorybyUrl(string categoryUrl)
        {
            return await _dataContext.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
