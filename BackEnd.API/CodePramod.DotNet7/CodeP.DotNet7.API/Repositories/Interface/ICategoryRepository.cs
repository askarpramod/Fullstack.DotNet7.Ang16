using CodeP.DotNet7.API.Models.Domain;

namespace CodeP.DotNet7.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
