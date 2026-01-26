namespace Bits_Bytes.API.Models.DTO
{
    public class UploadImageRequestDTO
    {
        public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string Title { get; set; }
    }
}
    