using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using Services;

namespace DelegateSample.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        public async Task Add(StudentQuery model)
        {
            await studentService.Add(model);
        }
    }
}
