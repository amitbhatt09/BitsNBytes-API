namespace Bits_Bytes.API.Models.Domain
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string UserEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
