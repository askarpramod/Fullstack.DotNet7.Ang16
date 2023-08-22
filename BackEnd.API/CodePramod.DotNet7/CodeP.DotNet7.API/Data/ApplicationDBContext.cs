using CodeP.DotNet7.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodeP.DotNet7.API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlobPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
