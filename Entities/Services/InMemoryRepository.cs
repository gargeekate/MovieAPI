using MovieAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public class InMemoryRepository : IRepository
    {
        private List<Genre> _genres;
        public InMemoryRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre(){Id=1, Name = "Comedy"},
                new Genre(){Id=2, Name = "Romance"},
                new Genre(){Id=3, Name = "Horror"}
            };
        }

        //192.168.0.103

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }

        public Genre GetGenreById(int Id)
        {
            return _genres.FirstOrDefault(x => x.Id == Id);
        }
    }
}