using Microsoft.AspNetCore.Mvc;
using Work.Core.Entities;
using Work.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeService.GetById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            _employeeService.Add(employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Employee employee)
        {
            _employeeService.Update(employee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.DeleteById(id);
        }
    }
}
