namespace assignment3;

class SimpleMP3Display : IObserver
{
    private IObservable player;
    private Song currentSong;

    public SimpleMP3Display(IObservable player)
    {
        // Add the display as an observer to the player
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
        Console.WriteLine("Simple Display: " + currentSong.Artist + " - " + currentSong.Title);
    }
}

