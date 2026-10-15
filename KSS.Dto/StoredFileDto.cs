namespace KSS.Dto
{
    public class StoredFileDto
    {
        public int Id { get; set; }
        public Guid DocumentId { get; set; }
        public byte[] FileData { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
