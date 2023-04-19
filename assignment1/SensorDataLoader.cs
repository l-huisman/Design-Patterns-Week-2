namespace assignment1;

class SensorDataLoader : BigDataLoader
{
    // Overriding the abstract methods from the BigDataLoader class to fit the SensorDataLoader
    protected override void ExtractData()
    {
        Console.WriteLine("Extracting sensor data...");
    }

    protected override void TransformData()
    {
        Console.WriteLine("Transforming sensor data...");
    }
}
