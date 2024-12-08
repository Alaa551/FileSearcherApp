namespace FileSearcherApp;

public partial class ResultScreen : Form
{
    public ResultScreen()
    {
        InitializeComponent();
    }

    private void AddDummyDataToTheGridView()
    {
        // Example of populating the DataGridView
        dataGridView1.Rows.Add("Path1", "Name1", 1);
        dataGridView1.Rows.Add("Path2", "Name2", 1);
        dataGridView1.Rows.Add("Path3", "Name3", 1);
        dataGridView1.Rows.Add("Path4", "Name4", 1);
        dataGridView1.Rows.Add("Path5", "Name5", 2);
        dataGridView1.Rows.Add("Path5", "Name5", 2);
        dataGridView1.Rows.Add("Path5", "Name5", 2);
        dataGridView1.Rows.Add("Path5", "Name5", 2);
        dataGridView1.Rows.Add("Path5", "Name5", 2);
        dataGridView1.Rows.Add("Path5", "Name5", 2);
        dataGridView1.Rows.Add("Path5", "Name5", 2);
        dataGridView1.Rows.Add("Path5", "Name5", 2);
        dataGridView1.Rows.Add("Path5", "Name5", 2);


    }

    private void ResultScreen_Load(object sender, EventArgs e)
    {
        AddDummyDataToTheGridView();
        AdjustDataGridViewHeight(dataGridView1);
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
        dataGridView1.ClearSelection();
    }

}

