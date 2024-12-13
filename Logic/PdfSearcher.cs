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


        public async Task SearchFileAsync(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token)
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

                        // Extract text from the current page
                        string pageText = PdfTextExtractor.GetTextFromPage(pdfReader, page);

                        // Count occurrences of the keyword in the page text
                        int index = 0;
                        while ((index = pageText.IndexOf(keyword, index, StringComparison.InvariantCultureIgnoreCase)) != -1)
                        {
                            numOfOccurrences++;
                            index += keyword.Length; // Move past the current occurrence
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
            //   await Task.Delay(1000);

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
                        int index = 0;
                        while ((index = text.IndexOf(keyword, index, StringComparison.InvariantCultureIgnoreCase)) != -1)
                        {
                            numOfOccurrences++;
                            index += keyword.Length; // Move past the current occurrence
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            stopWatch.Stop();
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
