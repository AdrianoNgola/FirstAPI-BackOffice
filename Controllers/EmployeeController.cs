
using FirstAPI.Model;
using FirstAPI.Services.Employee.Interface;
using FirstAPI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstAPI.Controllers
{   [Authorize]
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeRepository employeeRepository, IEmployeeService employeeService)
        {
            _employeeRepository = employeeRepository;
            _employeeService = employeeService;
        }


       // [Authorize]
        [HttpPost]
        public IActionResult AddEmployees([FromForm] EmployeeRequest employeeRequest)
        {
            var filePath = Path.Combine("Storage", employeeRequest.photo?.FileName ?? "default.png");
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeRequest.photo?.CopyTo(fileStream);

            var employee = new EmployeeModel(employeeRequest.id, employeeRequest.name, employeeRequest.age, filePath);
            _employeeService.AddEmployee(employee);
            
            return Ok();
        }

        
        [HttpGet]
       // [Authorize]
        public IActionResult GetEmployees(int pageNumber, int pageQuantity)
        {
            var employee = _employeeRepository.GetAllEmployees(pageNumber, pageQuantity);
            return Ok(employee);
        }

         //[Authorize]
        [HttpGet("{id}")]
         public IActionResult GetEmployeesById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            return Ok(employee);
        }
    }
}