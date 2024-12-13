using System.Collections.Concurrent;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
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

                //using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
                //{
                //    // Get the main document part (the body of the document)
                //    var body = wordDoc.MainDocumentPart.Document.Body;

                //    // Extract all text from the body of the Word document
                //    string text = string.Join(" ", body.Descendants<Text>().Select(t => t.Text));

                //    // Split the text into an array by spaces or other delimiter if needed
                //    string[] textArray = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                //    // Count occurrences of the keyword (case-insensitive)
                //     numOfOccurrences = textArray.Count(word => word.Contains(keyword, StringComparison.InvariantCultureIgnoreCase));
                //}
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
                {
                    // Get the main document part (the body of the document)
                    var body = wordDoc.MainDocumentPart.Document.Body;

                    // Extract all text from the body of the Word document
                    string text = body.InnerText;

                    // Count occurrences of the keyword in the extracted text
                    int index = 0;
                    while ((index = text.IndexOf(keyword, index, StringComparison.InvariantCultureIgnoreCase)) != -1)
                    {
                        numOfOccurrences++;
                        index += keyword.Length; // Move past the current occurrence
                    }


                    // Check cancellation token periodically to support cancellation
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
                    // Get the main document part (the body of the document)
                    var body = wordDoc.MainDocumentPart.Document.Body;

                    // Extract all text from the body of the Word document
                    string text = body.InnerText;

                    // Count occurrences of the keyword in the extracted text
                    int index = 0;
                    while ((index = text.IndexOf(keyword, index, StringComparison.InvariantCultureIgnoreCase)) != -1)
                    {
                        numOfOccurrences++;
                        index += keyword.Length; // Move past the current occurrence
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
