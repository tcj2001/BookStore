////////////////////////////////////
// generated AuthorController.cs //
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
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> logger;
        private readonly IServiceManager _serviceManager;

        public AuthorController(IServiceManager serviceManager, ILogger<AuthorController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<AuthorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.AuthorService.GetAllAuthor();
            return Ok(result.entities);
        }

        // GET api/<AuthorController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _serviceManager.AuthorService.GetAuthorById(id);
            return Ok(result.entity);
        }

        // POST api/<AuthorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Author entity)
        {
            var result = await _serviceManager.AuthorService.AddAuthor(entity);
            return Ok(result);
        }

        // PUT api/<AuthorController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Author entity)
        {
            var result = await _serviceManager.AuthorService.UpdateAuthor(entity);
            return Ok(result);
        }

        // DELETE api/<AuthorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceManager.AuthorService.RemoveAuthor(id);
            return Ok(result);
        }
    }
}
