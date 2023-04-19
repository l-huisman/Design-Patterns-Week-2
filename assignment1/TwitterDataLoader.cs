namespace assignment1;

class TwitterDataLoader : BigDataLoader
{
    // Overriding the abstract methods from the BigDataLoader class to fit the TwitterDataLoader
    protected override void ExtractData()
    {
        Console.WriteLine("Extracting twitter data...");
    }

    protected override void TransformData()
    {
        Console.WriteLine("Transforming twitter data...");
    }
}
