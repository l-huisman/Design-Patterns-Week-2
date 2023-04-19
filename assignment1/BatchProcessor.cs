namespace assignment1;

class BatchProcessor
{
    private List<BigDataLoader> bigDataLoaders = new List<BigDataLoader>();

    public void AddBigDataLoader(BigDataLoader bigDataLoader)
    {
        // Add a big data loader to the list
        bigDataLoaders.Add(bigDataLoader);
    }

    public void ProcessBatch()
    {
        // Process all the big data loaders
        foreach (BigDataLoader bigDataLoader in bigDataLoaders)
        {
            bigDataLoader.ETL();
        }
    }
}
