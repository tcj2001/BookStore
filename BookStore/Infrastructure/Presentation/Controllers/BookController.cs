////////////////////////////////////
// generated BookController.cs //
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
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> logger;
        private readonly IServiceManager _serviceManager;

        public BookController(IServiceManager serviceManager, ILogger<BookController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<BookController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.BookService.GetAllBook();
            return Ok(result.entities);
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _serviceManager.BookService.GetBookById(id);
            return Ok(result.entity);
        }

        // POST api/<BookController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Book entity)
        {
            var result = await _serviceManager.BookService.AddBook(entity);
            return Ok(result);
        }

        // PUT api/<BookController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Book entity)
        {
            var result = await _serviceManager.BookService.UpdateBook(entity);
            return Ok(result);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceManager.BookService.RemoveBook(id);
            return Ok(result);
        }
    }
}
