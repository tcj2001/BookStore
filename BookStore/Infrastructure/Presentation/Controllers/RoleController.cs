////////////////////////////////////
// generated RoleController.cs //
////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Infrastructure.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ILogger<RoleController> logger;
        private readonly IServiceManager _serviceManager;

        public RoleController(IServiceManager serviceManager, ILogger<RoleController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<RoleController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.RoleService.GetAllRole();
            return Ok(result.entities);
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(short id)
        {
            var result = await _serviceManager.RoleService.GetRoleById(id);
            return Ok(result.entity);
        }

        // POST api/<RoleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Role entity)
        {
            var result = await _serviceManager.RoleService.AddRole(entity);
            return Ok(result);
        }

        // PUT api/<RoleController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Role entity)
        {
            var result = await _serviceManager.RoleService.UpdateRole(entity);
            return Ok(result);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(short id)
        {
            var result = await _serviceManager.RoleService.RemoveRole(id);
            return Ok(result);
        }
    }
}
