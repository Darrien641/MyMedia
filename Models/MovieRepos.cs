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
                    Notes = "This super hero action movie is much more than just that, its a movie that lived up to its hype and expectations more than eny other super hero movie that ive seen. This movie was funny, action packed and has a solid back story to give context to the main charaters personality.", 
                    ReleaseDate = new DateTime(2016,01,01)
                },
                new Movie{
                    ImagePath ="DP2.jpg",
                    MovieTitle = "DeadPool 2", 
                    Genre = "Action, Adventure, Comedy", 
                    Notes = " DeadPool 2 is the second movie in the series. This movie aligns perfectly with the first in expectations, comedy, story, action and an all around continuance of the same shenanigans with a little extra zing.", 
                    ReleaseDate = new DateTime(2018,01,01)
                },
                new Movie{
                    ImagePath = "FearAndLoathing.jpg",
                    MovieTitle = "Fear and Loathing in Las Vegas", 
                    Genre = "Comedy, Adventure, Drama", 
                    Notes = "Fear and Loathing in Las Vegas is an interesting movie. A book first, and an article in the rolling stones before that. The movie follows the plot of the book, these two men have been assigned to cover motorcycle races, both of them of course always compleatly intoxicated on multiple substances, end up destroying thier hotel room and car all while thier mental state also deteriorates. This movie was really interesting I think Jhonny Depp did a great job as an actor in this movie. ", 
                    ReleaseDate = new DateTime(1998,01,01)
                },
                new Movie{
                    ImagePath ="GetOut.jpg",
                    MovieTitle = "Get Out", 
                    Genre = "Horror, Mystery, Thriller", 
                    Notes = "An interesting horror film, written ironicaly by a comedian. This movie was actually pretty terrifying, the way the movie was filmed it felt like what had occured in the movie might actually be a real concern. I think that the writers and evrybody involved with this movie did exactly what they were supposed to and did it very well, the acting was spot on and the story was realistic and had a terrifying aesthetic.", 
                    ReleaseDate = new DateTime(2017,01,01)
                },
                new Movie{
                    ImagePath ="IT.jpg",
                    MovieTitle = "IT", 
                    Genre = "Horror", 
                    Notes = "The Second movie in the IT trilogy. This is the continuance of the movie from the 90s with Tim Curry. The advanced technology and updated movie magic, the movie that was produced was a step up in, special effects, substance and story. I especially liked that the story line was deepened in this movie.", 
                    ReleaseDate = new DateTime(2017,01,01)
                },
            };
    }
}
