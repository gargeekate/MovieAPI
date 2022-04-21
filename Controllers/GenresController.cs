using Microsoft.AspNetCore.Mvc;
using MovieAPI.Entities;
using MovieAPI.Services;

namespace MovieAPI.Controllers
{
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly IRepository repository;
 
        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Genre> Get()
        {
            return repository.GetAllGenres();
        }

        [HttpGet("example")]
        public Genre Get(int Id)
        {
            var genre = repository.GetGenreById(Id);
            if(genre == null)
            {
                //return NotFound();
            }
            return genre;
        }
        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
       
    }
}