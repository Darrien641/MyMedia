using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMedia.Models
{
    public interface IMoviesRepos
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMoviesByTitle(string title);
    }
}
