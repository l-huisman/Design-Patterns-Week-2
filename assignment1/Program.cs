namespace assignment1;

class Program
{
    static void Main(string[] args)
    {
        Program myProgram = new Program();
        myProgram.Run();
    }

    private void Run()
    {
        // Instantiating a new BatchProcessor
        BatchProcessor batchProcessor = new BatchProcessor();

        // Adding the three different BigDataLoaders to the BatchProcessor
        batchProcessor.AddBigDataLoader(new CallDataLoader());
        batchProcessor.AddBigDataLoader(new TwitterDataLoader());
        batchProcessor.AddBigDataLoader(new SensorDataLoader());

        // Processing the batch
        batchProcessor.ProcessBatch();
    }
}