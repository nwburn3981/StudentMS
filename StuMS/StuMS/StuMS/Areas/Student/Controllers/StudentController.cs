using AutoMapper;
using StuMS.Models;
using StuMS.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StuMS.Services.IService;

namespace StuMS.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _StudentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService StudentService, IMapper mapper)
        {
            _StudentService = StudentService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<StudentDto> list = new();

            var response = await _StudentService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<StudentDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}