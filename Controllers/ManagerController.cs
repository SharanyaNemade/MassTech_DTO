using FebBatch2026WebApi.DTO;
using FebBatch2026WebApi.Models;
using FebBatch2026WebApi.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FebBatch2026WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        IManagerService service;
        public ManagerController(IManagerService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("AddM")]
        public IActionResult AddManager(ManagerDTO mdto)
        {
            service.AddManager(mdto);
            return Ok(new { message = "Manager Added Success" });
        }
    }
}
