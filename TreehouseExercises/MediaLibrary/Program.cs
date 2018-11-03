using System;

namespace MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var movie = new Movie();
            movie.Title = "Batman";
            movie.Director = "Jason McDonalds";

            var album = new Album();
            album.Title = "1984";
            album.Artist = "The Submarine";

            var audiobook = new AudioBook();
            audiobook.Title = "The Art of War";
            audiobook.Author = "Sun-Tzu";
        }
    }
}
