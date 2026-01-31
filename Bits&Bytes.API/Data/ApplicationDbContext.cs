using Bits_Bytes.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bits_Bytes.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
