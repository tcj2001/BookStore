////////////////////////////////////
// generated StoreController.cs //
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
    public class StoreController : ControllerBase
    {
        private readonly ILogger<StoreController> logger;
        private readonly IServiceManager _serviceManager;

        public StoreController(IServiceManager serviceManager, ILogger<StoreController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<StoreController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.StoreService.GetAllStore();
            return Ok(result.entities);
        }

        // GET api/<StoreController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _serviceManager.StoreService.GetStoreById(id);
            return Ok(result.entity);
        }

        // POST api/<StoreController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Store entity)
        {
            var result = await _serviceManager.StoreService.AddStore(entity);
            return Ok(result);
        }

        // PUT api/<StoreController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Store entity)
        {
            var result = await _serviceManager.StoreService.UpdateStore(entity);
            return Ok(result);
        }

        // DELETE api/<StoreController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _serviceManager.StoreService.RemoveStore(id);
            return Ok(result);
        }
    }
}
