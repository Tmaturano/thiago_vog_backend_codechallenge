using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Interfaces;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        [HttpGet(Name = "GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeeService.GetAll();
            if (!employees.Any())
                return NotFound();

            return Ok(employees);
        }

        [HttpGet("department/{departmentId}")]
        public async Task<IActionResult> GetEmployeesByDepartmentId(Guid departmentId)
        {
            if (departmentId == Guid.Empty)
                return BadRequest();

            var departments = await _departmentService.GetEmployeesByDepartmentIdAsync(departmentId);
            if (!departments.Any())
                return NotFound();
                        
            return Ok(departments);
        }
    }
}
