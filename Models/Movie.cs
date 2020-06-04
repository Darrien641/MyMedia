using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMedia.Models
{
    public class Movie
    {
        public string MovieTitle { get; set; }
        public string ImagePath { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Notes { get; set; }
    }
}
