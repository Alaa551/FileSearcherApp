namespace FileSearcherApp.Model
{

    public class SearchResult
    {
        public string? FileName { get; set; }
        public int ThreadId { get; set; }
        public int NumOfOccurrences { get; set; }
        public double TimeToFinish { get; set; }

    }
}
