using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var getResult = _bookService.GetById(id);
            if(getResult == null)
            {
                return BadRequest("Invalid id type");
            }
            return Ok(getResult);
        }
    }
}
