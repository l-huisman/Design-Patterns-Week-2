namespace assignment3;

public class Song
{
    private string title;
    private string artist;
    private TimeSpan length;

    public Song(string title, string artist, TimeSpan length)
    {
        this.title = title;
        this.artist = artist;
        this.length = length;
    }

    // getters and setters
    public string Title
    {
        get { return title; }
        private set { title = value; }
    }

    public string Artist
    {
        get { return artist; }
        private set { artist = value; }
    }

    public TimeSpan Length
    {
        get { return length; }
        private set { length = value; }
    }
}

