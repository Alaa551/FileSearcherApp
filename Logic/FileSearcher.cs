using System.Collections.Concurrent;
using FileSearcherApp.Model;
using Path = System.IO.Path;

namespace FileSearcherApp.Logic
{
    public class FileSearcher
    {
        public static async Task SearchFile(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token)
        {
            var searcher = GetSearcherFromExtension(filePath);
            searcher?.SearchFile(filePath, keyword, resultsBag, token);
        }

        private static IFileSearcher GetSearcherFromExtension(string filePath)
        {
            var pathFile = Path.GetExtension(filePath);
            return pathFile switch
            {
                ".pdf" => new PdfSearcher(),
                ".doc" or ".docx" => new WordSearcher(),
                ".txt" => new TxtSearcher(),
                _ => null
            };

        }
    }

}

