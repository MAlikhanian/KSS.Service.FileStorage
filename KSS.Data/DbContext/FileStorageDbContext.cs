using Microsoft.EntityFrameworkCore;
using KSS.Entity;

namespace KSS.Data.DbContexts
{
    public partial class MainDbContext
    {
        public DbSet<StoredFile> StoredFiles { get; set; }
    }
}
