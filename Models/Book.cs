using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMedia.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string ImagePath { get; set; }
        public string AuthorLastname { get; set; }
        public string AuthorFirstname { get; set; }
        public string BookTitle { get; set; }
        public string Edition { get; set; }
        public DateTime PublishDate { get; set; }
        public string BookCoverImage { get; set; }
        public string Notes { get; set; }
    }
}
