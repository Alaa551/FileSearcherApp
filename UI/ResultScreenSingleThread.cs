using FileSearcherApp.Logic;
using FileSearcherApp.Model;

namespace FileSearcherApp
{
    public partial class ResultScreenSingleThread : Form
    {
        private CancellationTokenSource _cts;
        private string[] _fileNames;
        private string _keyword;
        public ResultScreenSingleThread(string[] fileNames, string keyword)
        {
            InitializeComponent();
            _fileNames = fileNames;
            _keyword = keyword;

            StartSearch();

        }


        public async Task StartSearch()
        {
            var results = new List<SearchResult>();
            foreach (var file in _fileNames)
            {
                var res = FileSearcher.SearchFile(file, _keyword);
                results.Add(res);
                bindData(res);
                await Task.Delay(1000);
            }

            MessageBox.Show($"time = {results.Sum(x => x.TimeToFinish)}");


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Clear the selection
            SearchResultGridView.ClearSelection();
        }

        private void bindData(SearchResult searchresult)
        {
            SearchResultGridView.Rows.Add(
                 searchresult.FileName,
                 searchresult.NumOfOccurrences,
                 searchresult.ThreadId,
                 searchresult.TimeToFinish
                );

        }



    }
}
