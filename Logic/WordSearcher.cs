using System.Collections.Concurrent;
using FileSearcherApp.Model;
using Path = System.IO.Path;

namespace FileSearcherApp.Logic
{
    public class WordSearcher : IFileSearcher
    {
        public async void SearchFile(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token)
        {
            int numOfOccurrences = 0;

            //using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath))
            //{
            //    // Get the main document part (the body of the document)
            //    var body = wordDoc.ExtendedProperties.Body;

            //    // Extract all text from the body of the Word document
            //    string text = body.InnerText;
            //    String[] textArray = text.Split('\n');
            //    numOfOccurrences += textArray.Count(word => word.Contains(keyword, StringComparison.InvariantCultureIgnoreCase));

            //}
            var searchResult = new SearchResult
            {
                FilePath = filePath,
                FileName = Path.GetFileName(filePath),
                NumOfOccurrences = numOfOccurrences
            };

            resultsBag.Add(searchResult);
            await Task.Delay(1000);
        }
    }


}
