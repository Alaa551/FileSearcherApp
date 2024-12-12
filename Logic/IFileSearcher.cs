using System.Collections.Concurrent;
using FileSearcherApp.Model;

namespace FileSearcherApp.Logic
{
    public interface IFileSearcher
    {
        public void SearchFile(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token);
    }


}
