using System.Collections.Concurrent;
using System.Diagnostics;
using FileSearcherApp.Model;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Path = System.IO.Path;

namespace FileSearcherApp.Logic
{
    public class PdfSearcher : IFileSearcher
    {


        public void SearchFileAsync(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token)
        {
            int numOfOccurrences = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try
            {
                using (PdfReader pdfReader = new PdfReader(filePath))
                {
                    int numberOfPages = pdfReader.NumberOfPages;
                    for (int page = 1; page <= numberOfPages; page++)
                    {
                        if (token.IsCancellationRequested)
                        {
                            stopWatch.Stop();
                            return;
                        }
                        string text = PdfTextExtractor.GetTextFromPage(pdfReader, page);

                        String[] textArray = text.Split('\n');
                        numOfOccurrences += textArray.Count(word => word.Contains(keyword, StringComparison.InvariantCultureIgnoreCase));
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
                using (PdfReader pdfReader = new PdfReader(filePath))
                {
                    int numberOfPages = pdfReader.NumberOfPages;
                    for (int page = 1; page <= numberOfPages; page++)
                    {
                        string text = PdfTextExtractor.GetTextFromPage(pdfReader, page);

                        String[] textArray = text.Split('\n');
                        numOfOccurrences += textArray.Count(word => word.Contains(keyword, StringComparison.InvariantCultureIgnoreCase));
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
