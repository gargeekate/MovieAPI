using System.Collections.Generic;
using MovieAPI.Entities;

namespace MovieAPI.Services
{
    public interface IRepository
    {
         List<Genre> GetAllGenres();
        Genre GetGenreById(int Id);
    }
}