using System.Collections.Concurrent;
using FileSearcherApp.Model;

namespace FileSearcherApp.Logic
{
    public class FileSearcher
    {
        public static async Task SearchFile(
            string filePath,
            string keyword,
            ConcurrentBag<SearchResult> resultsBag,
            CancellationToken token
            )
        {
            int numOfOccurrences = 0;

            using (var reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    if (line.Contains(keyword, StringComparison.InvariantCultureIgnoreCase))
                    {
                        numOfOccurrences++;
                    }
                }
            }


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
