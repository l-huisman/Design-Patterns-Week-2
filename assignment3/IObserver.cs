namespace assignment3;

public interface IObserver
{
    // This method is called whenever the observed object is changed.
    void Update(Song song);
}

