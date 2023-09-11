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
    public class TeacherController : BaseController
    {

        private readonly ITeacherService _TeacherService;
        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ITeacherService TeacherService, ILogger<TeacherController> logger)
        {
            _TeacherService = TeacherService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllTeachers")]
        public async Task<List<TeacherDto>> GetAll()
        {
            var result = await _TeacherService.GetAll();
            return result.Select(x => x.ToTeacherDto()).ToList();
        }

        [HttpGet("{TeacherId}", Name = "GetTeacher")]
        public async Task<TeacherDto?> Get(int TeacherId)
        {
            var result = await _TeacherService.GetById(TeacherId);
            return result?.ToTeacherDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] TeacherDto requestDto)
        {
            var TeacherModel = requestDto.ToTeacherModel();
            return await _TeacherService.CreateTeacher(TeacherModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] TeacherDto requestDto)
        {
            await _TeacherService.UpdateTeacher(requestDto.ToTeacherModel());
            return Ok();
        }

        [HttpDelete, Route("{TeacherId}")]
        public async Task<IActionResult> Delete(int TeacherId)
        {
            await _TeacherService.DeleteTeacher(TeacherId);
            return Ok();
        }
    }
}
