using System.Collections.Concurrent;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;
using FileSearcherApp.Model;
using Path = System.IO.Path;

namespace FileSearcherApp.Logic
{
    public class WordSearcher : IFileSearcher
    {
        public async Task SearchFileAsync(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token)
        {
            int numOfOccurrences = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
                {
                    var body = wordDoc.MainDocumentPart.Document.Body;

                    string text = body.InnerText;

                    // count occurrences of the keyword in the body
                    int index = 0;
                    while ((index = text.IndexOf(keyword, index, StringComparison.InvariantCultureIgnoreCase)) != -1)
                    {
                        numOfOccurrences++;
                        index += keyword.Length;
                    }


                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                stopWatch.Stop();
                // await Task.Delay(1000);

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


                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
                {
                    var body = wordDoc.MainDocumentPart.Document.Body;

                    string text = body.InnerText;

                    // count occurrences of the keyword in the body
                    int index = 0;
                    while ((index = text.IndexOf(keyword, index, StringComparison.InvariantCultureIgnoreCase)) != -1)
                    {
                        numOfOccurrences++;
                        index += keyword.Length;
                    }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                stopWatch.Stop();
                // await Task.Delay(1000);

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
