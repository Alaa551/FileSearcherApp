using System.Windows.Forms;

namespace FileSearcherApp;

partial class ResultScreen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        ResultLabel = new Label();
        cancelBtn = new Button();
        exitBtn = new Button();
        panel1 = new Panel();
        dataGridView1 = new DataGridView();
        FilePath = new DataGridViewTextBoxColumn();
        FileName = new DataGridViewTextBoxColumn();
        Count = new DataGridViewTextBoxColumn();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // ResultLabel
        // 
        ResultLabel.Anchor = AnchorStyles.None;
        ResultLabel.AutoSize = true;
        ResultLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ResultLabel.ForeColor = Color.Black;
        ResultLabel.Location = new Point(364, 19);
        ResultLabel.Name = "ResultLabel";
        ResultLabel.Size = new Size(222, 36);
        ResultLabel.TabIndex = 0;
        ResultLabel.Text = "Search Result";
        // 
        // cancelBtn
        // 
        cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cancelBtn.BackColor = Color.Chocolate;
        cancelBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cancelBtn.Location = new Point(737, 534);
        cancelBtn.Name = "cancelBtn";
        cancelBtn.Size = new Size(169, 86);
        cancelBtn.TabIndex = 2;
        cancelBtn.Text = "Cancel";
        cancelBtn.UseVisualStyleBackColor = false;
        // 
        // exitBtn
        // 
        exitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        exitBtn.BackColor = Color.Chocolate;
        exitBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        exitBtn.Location = new Point(30, 534);
        exitBtn.Name = "exitBtn";
        exitBtn.Size = new Size(169, 86);
        exitBtn.TabIndex = 3;
        exitBtn.Text = "Exit";
        exitBtn.UseVisualStyleBackColor = false;
        // 
        // panel1
        // 
        panel1.Controls.Add(ResultLabel);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(932, 70);
        panel1.TabIndex = 4;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.BackgroundColor = SystemColors.Control;
        dataGridView1.BorderStyle = BorderStyle.None;
        dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
        dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.Chocolate;
        dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.Padding = new Padding(15);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FilePath, FileName, Count });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
        dataGridView1.EnableHeadersVisualStyles = false;
        dataGridView1.GridColor = SystemColors.Control;
        dataGridView1.Location = new Point(12, 92);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RightToLeft = RightToLeft.No;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.Padding = new Padding(5);
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.RowHeadersWidth = 51;
        dataGridViewCellStyle4.BackColor = SystemColors.Control;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
        dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
        dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridView1.RowTemplate.DividerHeight = 5;
        dataGridView1.RowTemplate.Height = 50;
        dataGridView1.RowTemplate.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(908, 409);
        dataGridView1.TabIndex = 5;
        dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        // 
        // FilePath
        // 
        FilePath.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        FilePath.FillWeight = 3F;
        FilePath.HeaderText = "File Path";
        FilePath.MinimumWidth = 6;
        FilePath.Name = "FilePath";
        FilePath.ReadOnly = true;
        FilePath.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // FileName
        // 
        FileName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        FileName.FillWeight = 2F;
        FileName.HeaderText = "File Name";
        FileName.MinimumWidth = 6;
        FileName.Name = "FileName";
        FileName.ReadOnly = true;
        FileName.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // Count
        // 
        Count.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Count.FillWeight = 1F;
        Count.HeaderText = "Count";
        Count.MinimumWidth = 6;
        Count.Name = "Count";
        Count.ReadOnly = true;
        Count.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // ResultScreen
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(932, 632);
        Controls.Add(dataGridView1);
        Controls.Add(panel1);
        Controls.Add(exitBtn);
        Controls.Add(cancelBtn);
        MinimumSize = new Size(950, 679);
        Name = "ResultScreen";
        Text = "Form1";
        Load += ResultScreen_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label ResultLabel;
    private Button cancelBtn;
    private Button exitBtn;
    private Panel panel1;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn FilePath;
    private DataGridViewTextBoxColumn FileName;
    private DataGridViewTextBoxColumn Count;
}
