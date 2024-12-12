using System.Collections.Concurrent;
using System.Diagnostics;
using FileSearcherApp.Model;

namespace FileSearcherApp.Logic
{
    public class TxtSearcher : IFileSearcher
    {
        public async void SearchFileAsync(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token)
        {
            int numOfOccurrences = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try
            {

                using (var reader = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        if (token.IsCancellationRequested)
                        {
                            stopWatch.Stop();
                            return;
                        }

                        if (line.Contains(keyword, StringComparison.InvariantCultureIgnoreCase))
                        {
                            numOfOccurrences++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
            int numOfOccurrences = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try
            {

                using (var reader = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(keyword, StringComparison.InvariantCultureIgnoreCase))
                        {
                            numOfOccurrences++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
            return searchResult;

        }
    }


}
