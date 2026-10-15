using KSS.Dto;
using KSS.Entity;
using KSS.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace KSS.API.Controller
{
    public class StoredFileController : BaseController<StoredFile, StoredFileDto, StoredFileAddDto, StoredFileAddDto>
    {
        private readonly IStoredFileService _service;

        public StoredFileController(IStoredFileService service) : base(service)
        {
            _service = service;
        }

        /// <summary>
        /// Single-row fetch by DocumentId. Used by the FileOrchestrator's
        /// Download / Delete flows so they don't have to call ToListAll and
        /// materialize every blob in memory (which OOMs the pod).
        /// GET /Api/StoredFile/FindByDocumentId/{documentId}
        /// </summary>
        [HttpGet("{documentId}")]
        public async Task<ActionResult<StoredFile>> FindByDocumentIdAsync(Guid documentId)
        {
            var file = await _service.FirstOrDefaultAsync(s => s.DocumentId == documentId);
            if (file == null) return NotFound();
            return Ok(file);
        }
    }
}
