using Bits_Bytes.API.Models.Domain;
using Bits_Bytes.API.Models.DTO;
using Bits_Bytes.API.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bits_Bytes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentRepository commentRepository;

        public CommentsController(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        // POST: {apibaseurl}/api/comments
        [HttpPost]
        [Authorize]   // any logged-in user (Reader or Writer)
        public async Task<IActionResult> CreateComment([FromBody] CreateCommentRequestDto request)
        {
            // Pull the email from the JWT claims — this is the authenticated user
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(userEmail))
            {
                return Unauthorized();
            }

            var comment = new Comment
            {
                Content = request.Content,
                UserEmail = userEmail,
                CreatedAt = DateTime.UtcNow,
                BlogPostId = request.BlogPostId
            };

            comment = await commentRepository.CreateAsync(comment);

            var response = new CommentDto
            {
                Id = comment.Id,
                Content = comment.Content,
                UserEmail = comment.UserEmail,
                CreatedAt = comment.CreatedAt,
                BlogPostId = comment.BlogPostId
            };

            return Ok(response);
        }

        // GET: {apibaseurl}/api/comments/{blogPostId}
        [HttpGet]
        [Route("{blogPostId:Guid}")]
        public async Task<IActionResult> GetCommentsByBlogPostId([FromRoute] Guid blogPostId)
        {
            var comments = await commentRepository.GetByBlogPostIdAsync(blogPostId);

            var response = new List<CommentDto>();
            foreach (var comment in comments)
            {
                response.Add(new CommentDto
                {
                    Id = comment.Id,
                    Content = comment.Content,
                    UserEmail = comment.UserEmail,
                    CreatedAt = comment.CreatedAt,
                    BlogPostId = comment.BlogPostId
                });
            }

            return Ok(response);
        }
    }
}
