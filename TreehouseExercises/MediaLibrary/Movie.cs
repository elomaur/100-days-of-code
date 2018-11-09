namespace Treehouse.MediaLibrary
{
    class Movie
    {
            public string Title;
            public string Director;
            public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }
            public string GetDisplay()

            {
                return "Album: " + Title + "by" + Artist;
            }

    }
}