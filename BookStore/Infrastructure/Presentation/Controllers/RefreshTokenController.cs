////////////////////////////////////
// generated RefreshTokenController.cs //
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
    public class RefreshTokenController : ControllerBase
    {
        private readonly ILogger<RefreshTokenController> logger;
        private readonly IServiceManager _serviceManager;

        public RefreshTokenController(IServiceManager serviceManager, ILogger<RefreshTokenController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<RefreshTokenController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.RefreshTokenService.GetAllRefreshToken();
            return Ok(result.entities);
        }

        // GET api/<RefreshTokenController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _serviceManager.RefreshTokenService.GetRefreshTokenById(id);
            return Ok(result.entity);
        }

        // POST api/<RefreshTokenController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RefreshToken entity)
        {
            var result = await _serviceManager.RefreshTokenService.AddRefreshToken(entity);
            return Ok(result);
        }

        // PUT api/<RefreshTokenController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] RefreshToken entity)
        {
            var result = await _serviceManager.RefreshTokenService.UpdateRefreshToken(entity);
            return Ok(result);
        }

        // DELETE api/<RefreshTokenController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceManager.RefreshTokenService.RemoveRefreshToken(id);
            return Ok(result);
        }
    }
}
