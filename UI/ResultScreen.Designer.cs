namespace FileSearcherApp
{
    partial class ResultScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultScreen));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            Select_Btn = new Button();
            keywordTextBox = new TextBox();
            Search_Btn = new Button();
            SearchResultGridView = new DataGridView();
            FileName = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            ThreadId = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            cancelBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            singleThreadBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchResultGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(Select_Btn);
            panel1.Controls.Add(keywordTextBox);
            panel1.Controls.Add(Search_Btn);
            panel1.Location = new Point(22, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 45);
            panel1.TabIndex = 0;
            // 
            // Select_Btn
            // 
            Select_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Select_Btn.BackColor = Color.FromArgb(255, 192, 128);
            Select_Btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Select_Btn.ForeColor = Color.White;
            Select_Btn.Location = new Point(824, 4);
            Select_Btn.Name = "Select_Btn";
            Select_Btn.Size = new Size(199, 33);
            Select_Btn.TabIndex = 2;
            Select_Btn.Text = "select file";
            Select_Btn.UseVisualStyleBackColor = false;
            Select_Btn.Click += Select_Btn_Click;
            // 
            // keywordTextBox
            // 
            keywordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            keywordTextBox.Location = new Point(3, 0);
            keywordTextBox.Multiline = true;
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(1023, 39);
            keywordTextBox.TabIndex = 0;
            // 
            // Search_Btn
            // 
            Search_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search_Btn.BackColor = Color.FromArgb(255, 192, 128);
            Search_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Btn.Image = (Image)resources.GetObject("Search_Btn.Image");
            Search_Btn.Location = new Point(1026, 0);
            Search_Btn.Margin = new Padding(0);
            Search_Btn.Name = "Search_Btn";
            Search_Btn.Size = new Size(57, 39);
            Search_Btn.TabIndex = 1;
            Search_Btn.UseVisualStyleBackColor = false;
            Search_Btn.Click += Search_Btn_Click;
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
            SearchResultGridView.Columns.AddRange(new DataGridViewColumn[] { FileName, Count, ThreadId, Time });
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
            SearchResultGridView.Location = new Point(22, 109);
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
            SearchResultGridView.Size = new Size(1050, 430);
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
            // Time
            // 
            Time.FillWeight = 1F;
            Time.HeaderText = "Time";
            Time.MinimumWidth = 4;
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.SandyBrown;
            cancelBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(819, 567);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(253, 74);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // singleThreadBtn
            // 
            singleThreadBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            singleThreadBtn.BackColor = Color.SandyBrown;
            singleThreadBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            singleThreadBtn.ForeColor = SystemColors.ButtonHighlight;
            singleThreadBtn.Location = new Point(22, 567);
            singleThreadBtn.Name = "singleThreadBtn";
            singleThreadBtn.Size = new Size(253, 74);
            singleThreadBtn.TabIndex = 9;
            singleThreadBtn.Text = "Test Single Thread";
            singleThreadBtn.UseVisualStyleBackColor = false;
            singleThreadBtn.Click += singleThreadBtn_Click;
            // 
            // ResultScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1133, 653);
            Controls.Add(singleThreadBtn);
            Controls.Add(SearchResultGridView);
            Controls.Add(cancelBtn);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(941, 400);
            Name = "ResultScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Searcher";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchResultGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private Panel panel1;
        private TextBox keywordTextBox;
        private Button Search_Btn;
        private Button Select_Btn;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView SearchResultGridView;
        private Button cancelBtn;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn ThreadId;
        private DataGridViewTextBoxColumn Time;
        private Button singleThreadBtn;
    }
}