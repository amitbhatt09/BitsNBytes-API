namespace Bits_Bytes.API.Models.DTO
{
    public class CreateCommentRequestDto
    {
        public string Content { get; set; }
        public Guid BlogPostId { get; set; }
    }
}
