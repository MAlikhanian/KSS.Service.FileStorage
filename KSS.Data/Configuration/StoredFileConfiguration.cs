using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KSS.Entity;

namespace KSS.Data.Configuration
{
    public class StoredFileConfiguration : IEntityTypeConfiguration<StoredFile>
    {
        public void Configure(EntityTypeBuilder<StoredFile> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.DocumentId);
        }
    }
}
