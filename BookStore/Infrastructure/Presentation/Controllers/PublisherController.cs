////////////////////////////////////
// generated PublisherController.cs //
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
    public class PublisherController : ControllerBase
    {
        private readonly ILogger<PublisherController> logger;
        private readonly IServiceManager _serviceManager;

        public PublisherController(IServiceManager serviceManager, ILogger<PublisherController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<PublisherController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.PublisherService.GetAllPublisher();
            return Ok(result.entities);
        }

        // GET api/<PublisherController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _serviceManager.PublisherService.GetPublisherById(id);
            return Ok(result.entity);
        }

        // POST api/<PublisherController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Publisher entity)
        {
            var result = await _serviceManager.PublisherService.AddPublisher(entity);
            return Ok(result);
        }

        // PUT api/<PublisherController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Publisher entity)
        {
            var result = await _serviceManager.PublisherService.UpdatePublisher(entity);
            return Ok(result);
        }

        // DELETE api/<PublisherController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceManager.PublisherService.RemovePublisher(id);
            return Ok(result);
        }
    }
}
