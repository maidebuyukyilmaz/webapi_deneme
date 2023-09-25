using entities.Models;
using Microsoft.AspNetCore.Mvc;
using services.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace presentation.controllers
{
    [ApiController]
    [Route("api/Controllers")]
    public class BooksController:ControllerBase
    {

        private readonly Iservicemanager _manager;
       

        public BooksController(Iservicemanager manager)
        {
            _manager = manager;
           
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _manager.bookservice.getallbooks(false);
            return Ok(books);
        }
        [HttpGet("{id:int}")]
      
        public IActionResult GetOneBook([FromRoute(Name = "id")] int id)
        {
          
            try
            {
                var book = _manager.bookservice.getonebookyid(id, false);

                if (book == null)
                    return NotFound();
                return Ok(book);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
        [HttpPost]
        public IActionResult CreateOneBook([FromBody] Book book)
        {

            if (book == null)
                return BadRequest();

            _manager.bookservice.createonebook(book);


            return StatusCode(201, book);



        }
        [HttpPut("{id:int}")]
        public IActionResult UptadeOneBook([FromRoute(Name = "id")] int id,
            [FromBody] Book book)
        {
            var entity = _manager.bookservice.getonebookyid(id, false);

            if (entity is null)
                return NotFound();

            if (id != book.Id) return BadRequest();


            return NoContent();
        }


        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBook([FromRoute(Name = "id")] int id)
        {


            _manager.bookservice.deleteonebook(id, false);

            return NoContent();
        }


    }
}
