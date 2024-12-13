namespace FileSearcherApp
{
    partial class ResultScreenSingleThread
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultScreenSingleThread));
            bindingSource1 = new BindingSource(components);
            SearchResultGridView = new DataGridView();
            FileName = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            ThreadId = new DataGridViewTextBoxColumn();
            timeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchResultGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchResultGridView
            // 
            SearchResultGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            SearchResultGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SearchResultGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchResultGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchResultGridView.BackgroundColor = SystemColors.Control;
            SearchResultGridView.BorderStyle = BorderStyle.None;
            SearchResultGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            SearchResultGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SandyBrown;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SearchResultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SearchResultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchResultGridView.Columns.AddRange(new DataGridViewColumn[] { FileName, Count, ThreadId });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SearchResultGridView.DefaultCellStyle = dataGridViewCellStyle3;
            SearchResultGridView.EnableHeadersVisualStyles = false;
            SearchResultGridView.GridColor = SystemColors.Control;
            SearchResultGridView.Location = new Point(39, 23);
            SearchResultGridView.MultiSelect = false;
            SearchResultGridView.Name = "SearchResultGridView";
            SearchResultGridView.ReadOnly = true;
            SearchResultGridView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            SearchResultGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            SearchResultGridView.RowHeadersVisible = false;
            SearchResultGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            SearchResultGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            SearchResultGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            SearchResultGridView.RowTemplate.Height = 50;
            SearchResultGridView.RowTemplate.ReadOnly = true;
            SearchResultGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchResultGridView.Size = new Size(1050, 478);
            SearchResultGridView.TabIndex = 8;
            SearchResultGridView.SelectionChanged += dataGridView1_SelectionChanged;
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
            Count.MinimumWidth = 4;
            Count.Name = "Count";
            Count.ReadOnly = true;
            Count.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ThreadId
            // 
            ThreadId.FillWeight = 1F;
            ThreadId.HeaderText = "Thread Id";
            ThreadId.MinimumWidth = 4;
            ThreadId.Name = "ThreadId";
            ThreadId.ReadOnly = true;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(516, 555);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(0, 28);
            timeLabel.TabIndex = 9;
            // 
            // ResultScreenSingleThread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1133, 653);
            Controls.Add(timeLabel);
            Controls.Add(SearchResultGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(941, 400);
            Name = "ResultScreenSingleThread";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Searcher";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchResultGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView SearchResultGridView;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn ThreadId;
        private Label timeLabel;
    }
}