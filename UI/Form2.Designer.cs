namespace FileSearcherApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            Select_Btn = new Button();
            keywordTextBox = new TextBox();
            Search_Btn = new Button();
            SearchResultGridView = new DataGridView();
            FilePath = new DataGridViewTextBoxColumn();
            FileName = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            exitBtn = new Button();
            cancelBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
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
            panel1.Location = new Point(76, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 45);
            panel1.TabIndex = 0;
            // 
            // Select_Btn
            // 
            Select_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Select_Btn.BackColor = Color.FromArgb(255, 192, 128);
            Select_Btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Select_Btn.ForeColor = Color.White;
            Select_Btn.Location = new Point(484, 4);
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
            keywordTextBox.Size = new Size(683, 39);
            keywordTextBox.TabIndex = 0;
            // 
            // Search_Btn
            // 
            Search_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search_Btn.BackColor = Color.FromArgb(255, 192, 128);
            Search_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Btn.Image = (Image)resources.GetObject("Search_Btn.Image");
            Search_Btn.Location = new Point(686, 0);
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
            dataGridViewCellStyle6.BackColor = Color.Silver;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            SearchResultGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            SearchResultGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchResultGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchResultGridView.BackgroundColor = SystemColors.Control;
            SearchResultGridView.BorderStyle = BorderStyle.None;
            SearchResultGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            SearchResultGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.SandyBrown;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Padding = new Padding(15);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            SearchResultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            SearchResultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchResultGridView.Columns.AddRange(new DataGridViewColumn[] { FilePath, FileName, Count });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            SearchResultGridView.DefaultCellStyle = dataGridViewCellStyle8;
            SearchResultGridView.EnableHeadersVisualStyles = false;
            SearchResultGridView.GridColor = SystemColors.Control;
            SearchResultGridView.Location = new Point(22, 109);
            SearchResultGridView.MultiSelect = false;
            SearchResultGridView.Name = "SearchResultGridView";
            SearchResultGridView.ReadOnly = true;
            SearchResultGridView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            SearchResultGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            SearchResultGridView.RowHeadersVisible = false;
            SearchResultGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Control;
            SearchResultGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            SearchResultGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            SearchResultGridView.RowTemplate.Height = 50;
            SearchResultGridView.RowTemplate.ReadOnly = true;
            SearchResultGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchResultGridView.Size = new Size(873, 430);
            SearchResultGridView.TabIndex = 8;
            SearchResultGridView.SelectionChanged += dataGridView1_SelectionChanged;
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
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitBtn.BackColor = Color.SandyBrown;
            exitBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = SystemColors.ButtonHighlight;
            exitBtn.Location = new Point(22, 567);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(169, 74);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.SandyBrown;
            cancelBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(726, 567);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(169, 74);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(923, 653);
            Controls.Add(SearchResultGridView);
            Controls.Add(exitBtn);
            Controls.Add(cancelBtn);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(941, 400);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Searcher";
            Load += ResultScreen_Load;
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
        private DataGridViewTextBoxColumn FilePath;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Count;
        private Button exitBtn;
        private Button cancelBtn;
        private OpenFileDialog openFileDialog1;
    }
}