using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpEntity.Models;

namespace SpEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly VCSEmployeeDbContext context;
        public EmployeeController(VCSEmployeeDbContext vsccontext)
        {
            context = vsccontext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var employees = context.GetEmployees();
            return Ok(employees);
        }
    }
}
