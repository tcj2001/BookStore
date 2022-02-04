////////////////////////////////////
// generated BookAuthorController.cs //
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
    public class BookAuthorController : ControllerBase
    {
        private readonly ILogger<BookAuthorController> logger;
        private readonly IServiceManager _serviceManager;

        public BookAuthorController(IServiceManager serviceManager, ILogger<BookAuthorController> logger)
        {
            _serviceManager = serviceManager;
            this.logger = logger;
        }
        // GET: api/<BookAuthorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceManager.BookAuthorService.GetAllBookAuthor();
            return Ok(result.entities);
        }

        // GET api/<BookAuthorController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _serviceManager.BookAuthorService.GetBookAuthorById(id);
            return Ok(result.entity);
        }

        // POST api/<BookAuthorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BookAuthor entity)
        {
            var result = await _serviceManager.BookAuthorService.AddBookAuthor(entity);
            return Ok(result);
        }

        // PUT api/<BookAuthorController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] BookAuthor entity)
        {
            var result = await _serviceManager.BookAuthorService.UpdateBookAuthor(entity);
            return Ok(result);
        }

        // DELETE api/<BookAuthorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceManager.BookAuthorService.RemoveBookAuthor(id);
            return Ok(result);
        }
    }
}
