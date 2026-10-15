namespace KSS.Dto
{
    public class StoredFileAddDto
    {
        public Guid DocumentId { get; set; }
        public byte[] FileData { get; set; }
    }
}
