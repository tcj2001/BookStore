////////////////////////////////////
// generated UserController.cs //
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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly IServiceManager _serviceManager;

        public UserController(IServiceManager serviceManager, ILogger<UserController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.UserService.GetAllUser();
            return Ok(result.entities);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _serviceManager.UserService.GetUserById(id);
            return Ok(result.entity);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User entity)
        {
            var result = await _serviceManager.UserService.AddUser(entity);
            return Ok(result);
        }

        // PUT api/<UserController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] User entity)
        {
            var result = await _serviceManager.UserService.UpdateUser(entity);
            return Ok(result);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceManager.UserService.RemoveUser(id);
            return Ok(result);
        }
    }
}
