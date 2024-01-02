using Microsoft.AspNetCore.Mvc;
using Work.Core.Entities;
using Work.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerService _employerService;
        public EmployerController(IEmployerService employerService)
        {
            _employerService = employerService;
        }

        // GET: api/<EmployerController>
        [HttpGet]
        public IEnumerable<Employer> Get()
        {
            return _employerService.GetAll();
        }

        // GET api/<EmployerController>/5
        [HttpGet("{id}")]
        public Employer Get(int id)
        {
            return _employerService.GetById(id);
        }

        // POST api/<EmployerController>
        [HttpPost]
        public Employer Post([FromBody] Employer employer)
        {
          return  _employerService.Add(employer);
        }

        // PUT api/<EmployerController>/5
        [HttpPut("{id}")]
        public Employer Put( [FromBody] Employer employer)
        {
           return _employerService.Update(employer);
        }

        // DELETE api/<EmployerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employerService.DeleteById(id);
        }
    }
}
