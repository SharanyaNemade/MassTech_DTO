
using FebBatch2026WebApi.DTO;
using FebBatch2026WebApi.Models;
using FebBatch2026WebApi.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FebBatch2026WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmpService service;
        public EmployeeController(IEmpService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("AddE")]
        public IActionResult AddEmp(EmpDTO e)
        {
            service.AddEmp(e);
            return Ok(new { message = "Emp Added Success", data = e });
        }

        [HttpGet]
        [Route("FetchE")]
        public IActionResult FetchEmp()
        {
            var data=service.FetchEmp();
            return Ok(data);
        }
    }

}
