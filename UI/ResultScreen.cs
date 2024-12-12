using System.Collections.Concurrent;
using FileSearcherApp.Logic;
using FileSearcherApp.Model;

namespace FileSearcherApp
{
    public partial class ResultScreen : Form
    {
        private CancellationTokenSource _cts;
        public ResultScreen()
        {
            InitializeComponent();
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

            _cts?.Cancel();
            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            ConcurrentBag<SearchResult> resultDataBag = new();
            var keyword = keywordTextBox.Text.Trim();
            var files = openFileDialog1.FileNames;

            var numOfFiles = files.Count(f => f.Trim().Length != 0);


            if (keyword.Length == 0 || numOfFiles == 0)
            {
                MessageBox.Show("Please select a file and keyword to search",
                              "Information",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return;
            }


            SearchResultGridView.Rows.Clear();

            var searchtasks = openFileDialog1.FileNames
               .Select(filePath => Task.Run(
                   () => FileSearcher.SearchFile(
                       filePath, keyword, resultDataBag, token
                       )
                   )).ToList();

            var displayResult = Task.Run(async () =>
                {
                    await DislayResultOnGrid(resultDataBag, token);
                });

            await Task.WhenAll(searchtasks);
            await displayResult;

        }

        private async Task DislayResultOnGrid(ConcurrentBag<SearchResult> searchresultsbag, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (!searchresultsbag.IsEmpty)
                {
                    var datasnapshot = searchresultsbag.ToList();
                    searchresultsbag.Clear();

                    foreach (var result in datasnapshot)
                    {
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }
                        Invoke(new Action(() =>
                        {
                            bindData(result);

                        }));
                        await Task.Delay(1000);
                    }

                }
            }

        }

        private async void bindData(SearchResult searchresult)
        {
            SearchResultGridView.Rows.Add(
                 searchresult.FilePath,
                 searchresult.FileName,
                 searchresult.NumOfOccurrences

                );

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts?.Cancel();
                MessageBox.Show(Text = "Search is cancelled");

            }
        }
    }
}
