using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var movie = new Movie("Batman", "Jason McDonalds");
            var album = new Album("1984", "The Submarines");
            var audiobook = new AudioBook("The Art of War", "Sun-Tzu");

            Console.WriteLine("Movie: " + movie.Title + " by " + movie.Director);
            Console.WriteLine("Album: " + album.Title + " by " + album.Artist);
            Console.WriteLine("Audiobook: " + audiobook.Title + " by " + audiobook.Author);
        }
    }
}
