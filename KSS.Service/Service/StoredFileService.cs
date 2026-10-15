using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class StoredFileService : BaseService<StoredFile, StoredFileDto, StoredFileAddDto, StoredFileAddDto>, IStoredFileService
    {
        public StoredFileService(IMapper mapper, IStoredFileRepository repository) : base(mapper, repository) { }
    }
}
