using System.Collections.Concurrent;
using System.Diagnostics;
using FileSearcherApp.Model;
using Path = System.IO.Path;

namespace FileSearcherApp.Logic
{
    public class WordSearcher : IFileSearcher
    {
        public void SearchFileAsync(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token)
        {
            int numOfOccurrences = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try
            {

                //using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath))
                //{
                //    // Get the main document part (the body of the document)
                //    var body = wordDoc.ExtendedProperties.Body;

                //    // Extract all text from the body of the Word document
                //    string text = body.InnerText;
                //    String[] textArray = text.Split('\n');
                //    numOfOccurrences += textArray.Count(word => word.Contains(keyword, StringComparison.InvariantCultureIgnoreCase));

                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                stopWatch.Stop();
            }
            var searchResult = new SearchResult
            {
                FileName = Path.GetFileName(filePath),
                NumOfOccurrences = numOfOccurrences,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                TimeToFinish = stopWatch.Elapsed.TotalSeconds
            };
            resultsBag.Add(searchResult);
        }

        public SearchResult SearchFile(string filePath, string keyword)
        {
            throw new NotImplementedException();
        }
    }


}
