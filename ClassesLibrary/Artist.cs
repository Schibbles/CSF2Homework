using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields
        //props
        public Song[] Songs { get; set; }
        public string AlbumTitle { get; set; }
        public string Genre { get; set; }
        //ctors
        public Artist()
        {

        }
        public Artist(Song[] songs, string albumTitle, string genre)
        {
            Songs = songs;
            AlbumTitle = albumTitle;
            Genre = genre;
        }
        //methods
        public override string ToString()
        {
            string songsBy = "";
            foreach (Song song in Songs)
            {
                songsBy += song + "\n";
            }
            return string.Format("\nSongs: {0}\n" +
                "Album: {1}\n" +
                "Genre: {2}",
                songsBy, AlbumTitle, Genre);
        }
    }
}
