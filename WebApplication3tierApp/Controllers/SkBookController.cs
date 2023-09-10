using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SkBookController : BaseController
    {

        private readonly ISkBookService _SkBookService;
        private readonly ILogger<SkBookController> _logger;

        public SkBookController(ISkBookService SkBookService, ILogger<SkBookController> logger)
        {
            _SkBookService = SkBookService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllSkBooks")]
        public async Task<List<SkBookDto>> GetAll()
        {
            var result = await _SkBookService.GetAll();
            return result.Select(x => x.ToSkBookDto()).ToList();
        }

        [HttpGet("{SkBookId}", Name = "GetSkBook")]
        public async Task<SkBookDto?> Get(int SkBookId)
        {
            var result = await _SkBookService.GetById(SkBookId);
            return result?.ToSkBookDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] SkBookDto requestDto)
        {
            var SkBookModel = requestDto.ToSkBookModel();
            return await _SkBookService.CreateBook(SkBookModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] SkBookDto requestDto)
        {
            await _SkBookService.UpdateBook(requestDto.ToSkBookModel());
            return Ok();
        }

        [HttpDelete, Route("{SkBookId}")]
        public async Task<IActionResult> Delete(int SkBookId)
        {
            await _SkBookService.DeleteBook(SkBookId);
            return Ok();
        }
    }
}
