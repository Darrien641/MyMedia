using Microsoft.AspNetCore.Hosting.Server.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace MyMedia.Models
{
    public class MovieRepos : IMoviesRepos
    {
        public Movie GetMoviesByTitle(string title)
        {
            return GetMovies().FirstOrDefault(p => p.MovieTitle == title);
        }

        public IEnumerable<Movie> GetMovies() =>
            new List<Movie>
            {
                new Movie{
                    ImagePath = "Deadpool.jpg",
                    MovieTitle = "DeadPool", 
                    Genre = "Action, Adventure, Comedy", 
                    Notes = "", 
                    ReleaseDate = new DateTime(2016,01,01)
                },
                new Movie{
                    ImagePath ="DP2.jpg",
                    MovieTitle = "DeadPool 2", 
                    Genre = "Action, Adventure, Comedy", 
                    Notes = "", 
                    ReleaseDate = new DateTime(2018,01,01)
                },
                new Movie{
                    ImagePath = "FearAndLoathing.jpg",
                    MovieTitle = "Fear and Loathing in Las Vegas", 
                    Genre = "Comedy, Adventure, Drama", 
                    Notes = "", 
                    ReleaseDate = new DateTime(1998,01,01)
                },
                new Movie{
                    ImagePath ="GetOut.jpg",
                    MovieTitle = "Get Out", 
                    Genre = "Horror, Mystery, Thriller", 
                    Notes = "", 
                    ReleaseDate = new DateTime(2017,01,01)
                },
                new Movie{
                    ImagePath ="IT.jpg",
                    MovieTitle = "IT", 
                    Genre = "Horror", 
                    Notes = "", 
                    ReleaseDate = new DateTime(2017,01,01)
                },
            };
    }
}
