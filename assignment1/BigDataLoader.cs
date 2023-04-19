namespace assignment1;

public abstract class BigDataLoader
{
    // Declaring the ETL method since it is the same for all subclasses
    public void ETL()
    {
        ExtractData();
        TransformData();
        LoadData();
    }

    // Defining the abstract methods that will be implemented in the subclasses
    protected abstract void ExtractData();
    protected abstract void TransformData();

    // Declaring the LoadData method since it is the same for all subclasses
    protected void LoadData() {
        Console.WriteLine("loading transformed data...\n");
    }
}