using Bits_Bytes.API.Data;
using Bits_Bytes.API.Models.Domain;
using Bits_Bytes.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bits_Bytes.API.Repositories.Implementation
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CommentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Comment> CreateAsync(Comment comment)
        {
            await dbContext.Comments.AddAsync(comment);
            await dbContext.SaveChangesAsync();
            return comment;
        }

        public async Task<IEnumerable<Comment>> GetByBlogPostIdAsync(Guid blogPostId)
        {
            return await dbContext.Comments
                .Where(c => c.BlogPostId == blogPostId)
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();
        }
    }
}
