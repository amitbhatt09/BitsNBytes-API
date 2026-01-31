using Bits_Bytes.API.Models.Domain;

namespace Bits_Bytes.API.Repositories.Interface
{
    public interface ICommentRepository
    {
        Task<Comment> CreateAsync(Comment comment);
        Task<IEnumerable<Comment>> GetByBlogPostIdAsync(Guid blogPostId);
    }
}
