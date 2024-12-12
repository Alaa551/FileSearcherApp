using System.Collections.Concurrent;
using FileSearcherApp.Model;

namespace FileSearcherApp.Logic
{
    public interface IFileSearcher
    {
        public void SearchFileAsync(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token);
        public SearchResult SearchFile(string filePath, string keyword);
    }


}
