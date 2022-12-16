using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webdot.Data;
using webdot.Models;
using webdot.Services;

namespace webdot.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IBookService _bookService;

        public BookController(DatabaseContext context, IBookService bookService)
        {
            _context = context;
            _bookService = bookService;
        }

        [HttpGet]
        [Route("all")]
        public List<Book> getAll()
        {
            List<Book> result = _bookService.getAll();
            return result;
        }

        [HttpGet]
        [Route("{id}")]
        public Book Detail(int id)
        {
            return _bookService.getById(id);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult add(Book model)
        {
            Book result = _bookService.add(model);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        public Book update(Book model, int id)
        {
            return _bookService.update(model, id);
        }


        [HttpDelete]
        [Route("{id}")]
        public Book remove(int id)
        {
            return _bookService.remove(id);
        }


    }
}