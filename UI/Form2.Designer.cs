namespace FileSearcher
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
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            Select_Btn = new Button();
            textBox1 = new TextBox();
            Search_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(Select_Btn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Search_Btn);
            panel1.Location = new Point(59, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 45);
            panel1.TabIndex = 0;
            // 
            // Select_Btn
            // 
            Select_Btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Select_Btn.BackColor = Color.FromArgb(255, 192, 128);
            Select_Btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Select_Btn.ForeColor = Color.White;
            Select_Btn.Location = new Point(733, 4);
            Select_Btn.Name = "Select_Btn";
            Select_Btn.Size = new Size(105, 33);
            Select_Btn.TabIndex = 2;
            Select_Btn.Text = "select file";
            Select_Btn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(838, 39);
            textBox1.TabIndex = 0;
            // 
            // Search_Btn
            // 
            Search_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search_Btn.BackColor = Color.FromArgb(255, 192, 128);
            Search_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Btn.Image = (Image)resources.GetObject("Search_Btn.Image");
            Search_Btn.Location = new Point(841, 3);
            Search_Btn.Margin = new Padding(0);
            Search_Btn.Name = "Search_Btn";
            Search_Btn.Size = new Size(57, 39);
            Search_Btn.TabIndex = 1;
            Search_Btn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1080, 348);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Searcher";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private Panel panel1;
        private TextBox textBox1;
        private Button Search_Btn;
        private Button Select_Btn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}