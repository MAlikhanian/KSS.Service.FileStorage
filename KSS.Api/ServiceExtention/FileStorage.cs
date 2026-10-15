using Microsoft.EntityFrameworkCore;
using KSS.Data.DbContexts;
using KSS.Repository.IRepository;
using KSS.Repository.Repository;
using KSS.Service.IService;
using KSS.Service.Service;

namespace KSS.Api.ServiceExtention
{
    public static class FileStorageServiceExtention
    {
        public static IServiceCollection AddFileStorageServiceExtention(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<MainDbContext>(options =>
                options.UseSqlServer(configuration.GetSection("ConnectionStrings")["DefaultConnection"]));

            serviceCollection.AddScoped<IStoredFileRepository, StoredFileRepository>();

            serviceCollection.AddScoped<IStoredFileService, StoredFileService>();

            return serviceCollection;
        }
    }
}
