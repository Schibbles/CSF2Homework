using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    //props
    public class Song
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        //ctors
        public Song()
        {

        }
        public Song(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
        }
        //methods
        public override string ToString()
        {
            return string.Format("Artist: {0}\n" +
                "Title: {1}\n" +
                "Length in seconds: {2}",
                Artist, Title, Length);
        }
    }
    
}
