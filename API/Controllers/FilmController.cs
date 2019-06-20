using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drobnjak.Application.DataTransfer;
using Drobnjak.Application.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Drobnjak.Application.Exceptions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly ICreatFilmCommand _creatFilm;

        public FilmController(ICreatFilmCommand creatFilm)
        {
            _creatFilm = creatFilm;
        }
        // GET: api/Film
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Film/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Film
        [HttpPost]
        public IActionResult Post([FromBody] CreatFilmDto dto)
        {
            try
            {
                _creatFilm.Execute(dto);
                return StatusCode(201);
            }
            catch (EntityNotFoundException e)
            {
                return UnprocessableEntity(e.Message);
            }
            catch (Exception)
            {
                return (StatusCode(500));
            }


        }

        // PUT: api/Film/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
