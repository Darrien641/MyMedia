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
                    Notes = "Biggie smalls first studio album, you can hear the lyricism and word play begin to evolve throught the album. I think this is where emotions began to make its way into rap music."
                },
                new Album{
                    ImagePath ="K.O.D.Jpg",
                    AlbumTitle = "K.O.D.",
                    Artist = "Tech N9ne",
                    Notes = "Tech N9ne's 9th studio album, is one of his best. This album mainly focuses on music he wanted to do rather than what his fans asked for. This album is very lyrical, fast paced and mystical."
                },
                new Album{
                    ImagePath ="TechN9ne-Killer.jpg",
                    AlbumTitle = "Killer", 
                    Artist = "Tech N9ne", 
                    Notes = "Tech N9ne's 7th studio album. The cover of this album is actually paying homage to Michel Jacksons\"Thriller\". This album unlike other Tech N9ne albums, starts off slow and builds up to the faster, agressive parts of the album. This album made it to #12 on the 200 billboard and sold over 35, thousand albums in its first week."
                },
                new Album{
                    ImagePath ="StealThisAlbum.png",
                    AlbumTitle = "Steal This Album", 
                    Artist = "System Of A Down", 
                    Notes = "This is System of a Down's third album technically. Some unfinished songs got leaked from thier second album, the band decided to issue a statment about it and release the final versions of the songs as an album. Which is now Steal this Album."
                },
                new Album{
                    ImagePath ="StopStaringAtTheShadows.jpg",
                    AlbumTitle = " Stop Staring At the Shadows ", 
                    Artist = "Suicide Boys", 
                    Notes = "This is Suicide Boys second studio album. All of their other albums and records are either singles, EP's, or mixtapes. I think that this album is highly underappreciated, in terms of lyricysm, beats, and culture. The duo shifted thier sound but, continued with the same aesthetic and message. "
                },
            };
    }
}
