using AuotMapper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuotMapper.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BookController : ControllerBase
    {
        List<Book> books = new()
        {
            new Book { Id=1,Title="Test Title 1",Author="Test Author 1",Summary="Summary 1",Price=100.5},
            new Book { Id = 2, Title = "Test Title 2", Author = "Test Author 2", Summary = "Summary 2", Price = 75.0 },
            new Book { Id = 3, Title = "Test Title 3", Author = "Test Author 3", Summary = "Summary 3", Price = 0 }


        };
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(books);
        }
    }
}
