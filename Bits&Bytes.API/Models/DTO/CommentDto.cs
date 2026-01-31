namespace Bits_Bytes.API.Models.DTO
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string UserEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid BlogPostId { get; set; }
    }
}
