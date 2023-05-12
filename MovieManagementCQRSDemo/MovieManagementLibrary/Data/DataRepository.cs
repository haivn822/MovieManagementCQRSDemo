using MovieManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Data
{
    public class DataRepository : IDataRepository
    {
        public static List<MovieModel> _movies = new()
        {
            new MovieModel { Id = 1, Name = "Suit", Cost = 2000 },
            new MovieModel { Id = 2, Name = "How i met your mother", Cost = 4000 },
        };

        public MovieModel AddMovie(MovieModel movie)
        {
            _movies.Add(movie);
            return movie;
        }

        public List<MovieModel> GetMovies()
        {
            return _movies;
        }
    }
}
