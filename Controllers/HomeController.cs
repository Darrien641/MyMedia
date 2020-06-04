using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMedia.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumRepos albumRepos;
        private readonly IBookRepos bookRepos;
        private readonly IMoviesRepos moviesRepos;
        
        public HomeController(IAlbumRepos AlbumRP, IBookRepos BookRp, IMoviesRepos MoviesRp)
        {
            albumRepos = AlbumRP;
            bookRepos = BookRp;
            moviesRepos = MoviesRp;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Book()
        {
            return View(bookRepos.GetBooks());
        }
        public IActionResult Album()
        {
            return View(albumRepos.GetAlbums());
        }
        public IActionResult Movies()
        {
            return View(moviesRepos.GetMovies());
        }


    }
}
