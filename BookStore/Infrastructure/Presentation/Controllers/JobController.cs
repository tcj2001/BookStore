////////////////////////////////////
// generated JobController.cs //
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
    public class JobController : ControllerBase
    {
        private readonly ILogger<JobController> logger;
        private readonly IServiceManager _serviceManager;

        public JobController(IServiceManager serviceManager, ILogger<JobController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<JobController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.JobService.GetAllJob();
            return Ok(result.entities);
        }

        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(short id)
        {
            var result = await _serviceManager.JobService.GetJobById(id);
            return Ok(result.entity);
        }

        // POST api/<JobController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Job entity)
        {
            var result = await _serviceManager.JobService.AddJob(entity);
            return Ok(result);
        }

        // PUT api/<JobController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Job entity)
        {
            var result = await _serviceManager.JobService.UpdateJob(entity);
            return Ok(result);
        }

        // DELETE api/<JobController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(short id)
        {
            var result = await _serviceManager.JobService.RemoveJob(id);
            return Ok(result);
        }
    }
}
