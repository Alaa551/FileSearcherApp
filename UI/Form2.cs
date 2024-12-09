using System.Collections.Concurrent;
using FileSearcherApp.Logic;
using FileSearcherApp.Model;

namespace FileSearcherApp
{
    public partial class Form2 : Form
    {
        private CancellationTokenSource _cts;
        public Form2()
        {
            InitializeComponent();
        }


        private void ResultScreen_Load(object sender, EventArgs e)
        {
            //AdjustDataGridViewHeight(SearchResultGridView);
        }

        private void AdjustDataGridViewHeight(DataGridView dataGridView)
        {
            int totalHeight = dataGridView.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
                             + dataGridView.ColumnHeadersHeight;

            dataGridView.Height = totalHeight;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Clear the selection
            SearchResultGridView.ClearSelection();
        }

        private void Select_Btn_Click(object sender, EventArgs e)
        {
            configDialog();
            int numOfFiles = openFileDialog1.FileNames.Length;
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
            var keyword = keywordTextBox.Text;
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


        private async Task DislayResultOnGrid(ConcurrentBag<SearchResult> searchResultsBag, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (!searchResultsBag.IsEmpty)
                {
                    var dataSnapshot = searchResultsBag.ToList();
                    searchResultsBag.Clear();

                    foreach (var result in dataSnapshot)
                    {
                        Invoke(new Action(() =>
                        {
                            bindData(result);

                        }));
                        await Task.Delay(1000);
                    }

                }
            }

        }

        private async void bindData(SearchResult searchResult)
        {
            SearchResultGridView.Rows.Add(
                 searchResult.FilePath,
                 searchResult.FileName,
                 searchResult.NumOfOccurrences

                );

        }
    }
}
