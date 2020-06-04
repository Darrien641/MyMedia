using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyMedia.Models
{
    public class BookRepos : IBookRepos
    {
        public Book GetBooksByTitle(string title)
        {
            return GetBooks().FirstOrDefault(p => p.BookTitle == title);
        }

        public IEnumerable<Book> GetBooks() =>
            new List<Book>
            {
                new Book{
                    ImagePath ="CleanCode.jpg",
                    ISBN = "978-0132350884",
                    AuthorLastname = "Martin",
                    AuthorFirstname ="Robert",
                    BookTitle ="Clean Code",
                    Edition ="First Edition", 
                    PublishDate = new DateTime(2008,01,01) , 
                    Notes = ""
                },
                new Book{
                    ImagePath ="CleanCoder.jpg",
                    ISBN = "978-0137081073",
                    AuthorLastname = "Martin",
                    AuthorFirstname ="Robert",
                    BookTitle ="Clean Coder",
                    Edition ="First Edition", 
                    PublishDate = new DateTime(2011,01,01) , 
                    Notes = "" 
                },
                new Book{
                    ImagePath ="emerald.jpg",
                    ISBN = "978-1438235721",
                    AuthorLastname = "Trismegistus",
                    AuthorFirstname ="Hermes",
                    BookTitle ="The Emerald Tablet Of Hermes & The Kybalion: Two Classic Bookson Hermetic Philosophy",
                    Edition ="First Edition", 
                    PublishDate = new DateTime(2008,01,01) , 
                    Notes = ""
                },
                new Book{
                    ImagePath ="Justice.jpg",
                    ISBN = "978-0374532505",
                    AuthorLastname = "Sandel",
                    AuthorFirstname ="Michael",
                    BookTitle ="Justice: What's the Right Thing to Do?",
                    Edition ="Reprint edition", 
                    PublishDate = new DateTime(2010,01,01),
                    Notes = ""
                },
                new Book{
                    ImagePath ="Outsiders.jpg",
                    ISBN = "978-0142407332",
                    AuthorLastname = "Hinton",
                    AuthorFirstname ="Susan",
                    BookTitle ="The Ousiders",
                    Edition ="Platnum Edition", 
                    PublishDate = new DateTime(2006,01,01),
                    Notes = "" 
                },

            };
    }
}
