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
            _cts = new CancellationTokenSource();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Clear the selection
            SearchResultGridView.ClearSelection();
        }

        private void Select_Btn_Click(object sender, EventArgs e)
        {
            configDialog();
            changeSelectBtnText();

        }

        private void changeSelectBtnText()
        {
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
            initalizeSearchOperations();
            //validation

            if (!ValidateInput(keywordTextBox.Text.Trim()))
            {
                MessageBox.Show("Please select a file and keyword to search",
                              "Information",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return;
            }
            try
            {
                await execSearchOperations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                double totalTime = 0;
                foreach (DataGridViewRow row in SearchResultGridView.Rows)
                {
                    if (row.Cells["Time"].Value != null &&
                        double.TryParse(row.Cells["Time"].Value.ToString(), out double time))
                    {
                        totalTime += time;
                    }
                }

                MessageBox.Show($"Time: {totalTime} seconds");
                _cts?.Cancel();
            }


        }

        private void initalizeSearchOperations()
        {
            //clear previous displayed result and cancel token it exit
            SearchResultGridView.Rows.Clear();

            //initalize needed objects
            _cts = new CancellationTokenSource();
        }

        private async Task execSearchOperations()
        {
            var token = _cts.Token;
            ConcurrentBag<SearchResult> resultDataBag = new();
            var keyword = keywordTextBox.Text.Trim();
            // var files = openFileDialog1.FileNames;

            //start all threads 
            await startAllThreads(keyword, resultDataBag, token);


        }

        private async Task startAllThreads(string keyword, ConcurrentBag<SearchResult> resultDataBag, CancellationToken token)
        {
            var searchTasks = openFileDialog1.FileNames
                  .Select(filePath => Task.Run(
                  () => FileSearcher.SearchFileAsync(
                          filePath, keyword, resultDataBag, token
                          )
                      )).ToList();


            // display result on a seperate thread
            var displayResult = Task.Run(async () =>
            {
                await DislayResultOnGrid(resultDataBag, token, searchTasks);
            });

            await Task.WhenAll(searchTasks);
            // await Task.Delay(3000);
            await displayResult;

        }

        private bool ValidateInput(string keyword)
        {
            var numOfFiles = openFileDialog1.FileNames.Count(f => f.Trim().Length != 0);

            return numOfFiles != 0 && !string.IsNullOrWhiteSpace(keyword);
        }

        private async Task DislayResultOnGrid(ConcurrentBag<SearchResult> searchresultsbag, CancellationToken token, List<Task> searchTasks)
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

                        Invoke(new Action(() => bindData(result)));
                        //  bindData(result);
                        await Task.Delay(1000);
                    }


                }
                if (searchTasks.All(t => t.IsCompleted) && searchresultsbag.IsEmpty)
                {
                    break;
                }
                await Task.Delay(100); // Avoid tight loop

            }

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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts.Cancel();
                MessageBox.Show("Search is cancelled");

            }
        }

        private void singleThreadBtn_Click(object sender, EventArgs e)
        {
            new ResultScreenSingleThread(openFileDialog1.FileNames, keywordTextBox.Text.Trim()).Show();
        }
    }
}
