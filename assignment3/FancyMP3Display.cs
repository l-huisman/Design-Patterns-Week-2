namespace assignment3;

class FancyMP3Display : IObserver
{
    private IObservable player;
    private Song currentSong;

    public FancyMP3Display(IObservable player)
    {
        this.player = player;
        player.AddObserver(this);
    }

    public void Update(Song song)
    {
        // Update the current song and display it
        currentSong = song;
        Display();
    }

    private void Display()
    {
        // Display the song in the following format:
        Console.WriteLine("Fancy MP3 Display: " + currentSong.Artist + " by " + currentSong.Title + $"({currentSong.Length:mm\\:ss})\n");
    }
}

