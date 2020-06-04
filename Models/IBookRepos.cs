using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMedia.Models
{
    public interface IBookRepos
    {
        IEnumerable<Book> GetBooks();
        Book GetBooksByTitle(string title);
    }
}
