using KSS.Data.DbContexts;
using KSS.Entity;
using KSS.Repository.IRepository;

namespace KSS.Repository.Repository
{
    public class StoredFileRepository : BaseRepository<MainDbContext, StoredFile>, IStoredFileRepository
    {
        public StoredFileRepository(MainDbContext dbContext) : base(dbContext) { }
    }
}
