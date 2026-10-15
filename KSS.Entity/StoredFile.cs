using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace KSS.Entity
{
    public class StoredFile
    {
        [Key]
        public int Id { get; set; }

        public Guid DocumentId { get; set; }

        public byte[] FileData { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
