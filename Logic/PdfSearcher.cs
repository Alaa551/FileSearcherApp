using System.Collections.Concurrent;
using FileSearcherApp.Model;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Path = System.IO.Path;

namespace FileSearcherApp.Logic
{
    public class PdfSearcher : IFileSearcher
    {


        public async void SearchFile(string filePath, string keyword, ConcurrentBag<SearchResult> resultsBag, CancellationToken token)
        {
            int numOfOccurrences = 0;

            using (PdfReader pdfReader = new PdfReader(filePath))
            {
                int numberOfPages = pdfReader.NumberOfPages;
                for (int page = 1; page <= numberOfPages; page++)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    string text = PdfTextExtractor.GetTextFromPage(pdfReader, page);

                    String[] textArray = text.Split('\n');
                    numOfOccurrences += textArray.Count(word => word.Contains(keyword, StringComparison.InvariantCultureIgnoreCase));
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
