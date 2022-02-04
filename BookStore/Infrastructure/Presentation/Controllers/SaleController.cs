////////////////////////////////////
// generated SaleController.cs //
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
    public class SaleController : ControllerBase
    {
        private readonly ILogger<SaleController> logger;
        private readonly IServiceManager _serviceManager;

        public SaleController(IServiceManager serviceManager, ILogger<SaleController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<SaleController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.SaleService.GetAllSale();
            return Ok(result.entities);
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _serviceManager.SaleService.GetSaleById(id);
            return Ok(result.entity);
        }

        // POST api/<SaleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Sale entity)
        {
            var result = await _serviceManager.SaleService.AddSale(entity);
            return Ok(result);
        }

        // PUT api/<SaleController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Sale entity)
        {
            var result = await _serviceManager.SaleService.UpdateSale(entity);
            return Ok(result);
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceManager.SaleService.RemoveSale(id);
            return Ok(result);
        }
    }
}
