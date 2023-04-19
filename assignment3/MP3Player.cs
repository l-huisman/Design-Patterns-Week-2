namespace assignment3;

class MP3Player : IObservable
{
    private List<Song> songs;
    private List<IObserver> observers;
    private Song currentSong;
    public Song CurrentSong
    {
        get { return currentSong; }
        private set { currentSong = value; }
    }

    public MP3Player()
    {
        // Initialize the list of songs and observers and add some songs
        songs = new List<Song>();
        observers = new List<IObserver>();
        addSongs();
    }

    public void AddObserver(IObserver observer)
    {
        // Add a observer to the list
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        // Remove a observer from the list
        observers.Remove(observer);
    }

    public void NextSong()
    {
        // Select a random song from the list and notify the observers
        Random random = new Random();
        int index = random.Next(songs.Count);
        CurrentSong = songs[index];
        foreach (IObserver observer in observers)
        {
            observer.Update(CurrentSong);
        }
    }

    private void addSongs()
    {
        // Add some songs to the list
        songs.Add(new Song("Papillon", "Editors", new TimeSpan(0, 5, 24)));
        songs.Add(new Song("Wish You Were Here", "Pink Floyd", new TimeSpan(0, 5, 39)));
        songs.Add(new Song("Dazed and Confused", "Led Zeppelin", new TimeSpan(0, 6, 26)));
        songs.Add(new Song("Billionaire", "Bruno Mars", new TimeSpan(0, 3, 31)));
    }
}

