using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using System.IO;

namespace MyMedia.Models
{
    public class AlbumRepos : IAlbumRepos
    {
        public Album GetAlbumByTitle(string title)
        {
            return GetAlbums().FirstOrDefault(p => p.AlbumTitle == title );
        }

        public IEnumerable<Album> GetAlbums() =>
            new List<Album>
            {
                new Album{
                    ImagePath ="ReadyToDie.jpg",
                    AlbumTitle = "Ready To Die",
                    Artist = "Biggie Smalls",
                    Notes = ""
                },
                new Album{
                    ImagePath ="K.O.D.Jpg",
                    AlbumTitle = "K.O.D.",
                    Artist = "Tech N9ne",
                    Notes = ""
                },
                new Album{
                    ImagePath ="TechN9ne-Killer.jpg",
                    AlbumTitle = "Killer", 
                    Artist = "Tech N9ne", 
                    Notes = ""
                },
                new Album{
                    ImagePath ="StealThisAlbum.png",
                    AlbumTitle = "Steal This Album", 
                    Artist = "System Of A Down", 
                    Notes = ""
                },
                new Album{
                    ImagePath ="StopStaringAtTheShadows.jpg",
                    AlbumTitle = " Stop Staring At the Shadows ", 
                    Artist = "Suicide Boys", 
                    Notes = ""
                },
            };
    }
}
