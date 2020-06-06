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
                    Notes = "This book has a lot of principals and views about how to solidify the basics of programming. This book is great for any programmer who wants to keep thier skills crisp and continue learning as they code. I really enjoyed how this book continues to stay fairly relevant."
                },
                new Book{
                    ImagePath ="CleanCoder.jpg",
                    ISBN = "978-0137081073",
                    AuthorLastname = "Martin",
                    AuthorFirstname ="Robert",
                    BookTitle ="Clean Coder",
                    Edition ="First Edition", 
                    PublishDate = new DateTime(2011,01,01) , 
                    Notes = "This book is a great book for learning the fundamental and ethical foundation of creating programs. As well as the administrative side of how to deal with writing good and consise code. I think that this book could help programmers outside of thier coding lives as well." 
                },
                new Book{
                    ImagePath ="emerald.jpg",
                    ISBN = "978-1438235721",
                    AuthorLastname = "Trismegistus",
                    AuthorFirstname ="Hermes",
                    BookTitle ="The Emerald Tablet Of Hermes & The Kybalion: Two Classic Bookson Hermetic Philosophy",
                    Edition ="First Edition", 
                    PublishDate = new DateTime(2008,01,01) , 
                    Notes = "An interessting book if you like to read about egyptian and greek mythology. This book was said to have been a written collection the Greek God Hermes teachings, which is the foundation for alchemy and hermetecism. I find these very interesting philosophies, with all kinds of mysticism intertwined. I guess you could say it was the bible of alchemy."
                },
                new Book{
                    ImagePath ="Justice.jpg",
                    ISBN = "978-0374532505",
                    AuthorLastname = "Sandel",
                    AuthorFirstname ="Michael",
                    BookTitle ="Justice: What's the Right Thing to Do?",
                    Edition ="Reprint edition", 
                    PublishDate = new DateTime(2010,01,01),
                    Notes = "A very unbiased book that leaves me with more existential questions about life than answers, but this book healthily explores all kinds of avenues and philosophies that resonated with me in more ways than one. I really enjoyed reading this book becasue it's really thought provoking."
                },
                new Book{
                    ImagePath ="Outsiders.jpg",
                    ISBN = "978-0142407332",
                    AuthorLastname = "Hinton",
                    AuthorFirstname ="Susan",
                    BookTitle ="The Ousiders",
                    Edition ="Platnum Edition", 
                    PublishDate = new DateTime(2006,01,01),
                    Notes = "The outsiders is always a favorite of mine not only because of pop culture references, but becasue its a amazing book about some kids who are constantly on the outside looking in, this book will always be relevent not only because of recent events but because of the social inequalities amoungst everbody in our society. " 
                },

            };
    }
}
