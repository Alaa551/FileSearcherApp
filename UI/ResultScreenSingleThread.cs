using System.Diagnostics;
using FileSearcherApp.Logic;
using FileSearcherApp.Model;

namespace FileSearcherApp
{
    public partial class ResultScreenSingleThread : Form
    {
        private string[] _fileNames;
        private string _keyword;
        List<SearchResult> _results;
        private double totalTime = 0;
        public ResultScreenSingleThread(string[] fileNames, string keyword)
        {
            InitializeComponent();
            _fileNames = fileNames;
            _keyword = keyword;
            _results = new();


        }


        public async Task StartSearch()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var file in _fileNames)
            {
                var res = FileSearcher.SearchFile(file, _keyword);
                await Task.Delay(500);

                _results.Add(res);
            }
            stopwatch.Stop();
            totalTime = stopwatch.Elapsed.TotalSeconds;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Clear the selection
            SearchResultGridView.ClearSelection();
        }

        private async Task bindData(List<SearchResult> searchresults)
        {
            foreach (var searchresult in searchresults)
            {
                SearchResultGridView.Rows.Add(
                 searchresult.FileName,
                 searchresult.NumOfOccurrences,
                 searchresult.ThreadId
                );
                await Task.Delay(500);

            }

        }




        private async void ResultScreenSingleThread_Load(object sender, EventArgs e)
        {

            await StartSearch();
            await bindData(_results);
            timeLabel.Text = $"Total time to finish: {totalTime} seconds";

        }
    }
}
