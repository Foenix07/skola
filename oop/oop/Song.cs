using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Song
    {
        public string title;
        public string artist;
        public string album;
        public int seconds;
        
        public Song(string aTitle, string aArtist, string aAlbum, int aSeconds)
        {
            title = aTitle;
            artist = aArtist;
            album = aAlbum;
            seconds = aSeconds;
        }


        public void GetSongInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Artist: " + artist);
            Console.WriteLine("Album: " + album);
            Console.WriteLine("Seconds: " + seconds);
        }

        
    }

    
}
