namespace assignment1;

class CallDataLoader : BigDataLoader
{
    // Overriding the abstract methods from the BigDataLoader class to fit the CallDataLoader
    protected override void ExtractData()
    {
        Console.WriteLine("Extracting call data...");
    }

    protected override void TransformData()
    {
        Console.WriteLine("Transforming call data...");
    }
}
