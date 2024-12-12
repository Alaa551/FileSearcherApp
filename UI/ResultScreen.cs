using System.Collections.Concurrent;
using FileSearcherApp.Logic;
using FileSearcherApp.Model;

namespace FileSearcherApp
{
    public partial class ResultScreen : Form
    {
        private CancellationTokenSource _cts;
        private List<SearchResult> _searchResults;
        public ResultScreen()
        {
            InitializeComponent();
            _searchResults = new();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Clear the selection
            SearchResultGridView.ClearSelection();
        }

        private void Select_Btn_Click(object sender, EventArgs e)
        {
            configDialog();
            var numOfFiles = openFileDialog1.FileNames.Count(f => f.Trim().Length != 0);
            Select_Btn.Text = numOfFiles > 1 ? numOfFiles + " files are selected"
                                   : numOfFiles + " file is selected";

        }

        private void configDialog()
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Select files to search";
            openFileDialog1.ShowDialog();
        }

        private async void Search_Btn_Click(object sender, EventArgs e)
        {
            //clear previous displayed result and cancel token it exit
            SearchResultGridView.Rows.Clear();

            //calc the taken time to finish all files
            //  var stopWatch = new Stopwatch();

            //initalize needed objects
            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            ConcurrentBag<SearchResult> resultDataBag = new();
            var keyword = keywordTextBox.Text.Trim();
            var files = openFileDialog1.FileNames;


            //validation
            var numOfFiles = files.Count(f => f.Trim().Length != 0);

            if (keyword.Length == 0 || numOfFiles == 0)
            {
                MessageBox.Show("Please select a file and keyword to search",
                              "Information",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return;
            }


            //start all threads 
            //  stopWatch.Start();
            try
            {
                var searchtasks = openFileDialog1.FileNames
                   .Select(filePath => Task.Run(
                       () => FileSearcher.SearchFileAsync(
                           filePath, keyword, resultDataBag, token
                           )
                       )).ToList();


                // display result on a seperate thread
                var displayResult = Task.Run(async () =>
                    {
                        await DislayResultOnGrid(resultDataBag, token);
                    });

                await Task.WhenAll(searchtasks);
                await Task.Delay(3000);
                _cts.Cancel();

                await displayResult;

                // stopWatch.Stop();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                MessageBox.Show($"time :{_searchResults.Sum(t => t.TimeToFinish)} seconds {Thread.CurrentThread.ManagedThreadId}");
                _cts?.Dispose();
            }
        }

        private async Task DislayResultOnGrid(ConcurrentBag<SearchResult> searchresultsbag, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (!searchresultsbag.IsEmpty)
                {
                    var datasnapshot = searchresultsbag.ToList();
                    _searchResults.AddRange(datasnapshot);
                    searchresultsbag.Clear();

                    foreach (var result in datasnapshot)
                    {
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }

                        Invoke(new Action(async () => await bindData(result)));
                        //  bindData(result);
                        await Task.Delay(500);
                    }

                }
            }

        }

        private async Task bindData(SearchResult searchresult)
        {
            SearchResultGridView.Rows.Add(
                 searchresult.FileName,
                 searchresult.NumOfOccurrences,
                 searchresult.ThreadId,
                 searchresult.TimeToFinish

                );
            await Task.Delay(1000);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts?.Cancel();
                MessageBox.Show("Search is cancelled");

            }
        }

        private void singleThreadBtn_Click(object sender, EventArgs e)
        {
            new ResultScreenSingleThread(openFileDialog1.FileNames, keywordTextBox.Text.Trim()).Show();
        }
    }
}
