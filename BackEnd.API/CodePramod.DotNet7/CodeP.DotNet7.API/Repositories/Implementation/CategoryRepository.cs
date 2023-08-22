using CodeP.DotNet7.API.Data;
using CodeP.DotNet7.API.Models.Domain;
using CodeP.DotNet7.API.Repositories.Interface;

namespace CodeP.DotNet7.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDBContext dbContext;

        public CategoryRepository(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            //throw new NotImplementedException();
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
            return category; 
        }
    }
}
