using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using Services;
using Polly;

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
            var policy = Policy.Handle<Exception>().RetryAsync(5);

            await policy.ExecuteAsync(async () => await studentService.Add(model));
        }
    }
}
