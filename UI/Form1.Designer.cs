namespace FileSearcher
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AnimatedText = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnstart = new Button();
            picture1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture1).BeginInit();
            SuspendLayout();
            // 
            // AnimatedText
            // 
            AnimatedText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AnimatedText.AutoSize = true;
            AnimatedText.BackColor = Color.White;
            AnimatedText.Font = new Font("Algerian", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AnimatedText.ForeColor = Color.FromArgb(255, 192, 128);
            AnimatedText.Location = new Point(12, 94);
            AnimatedText.Name = "AnimatedText";
            AnimatedText.Size = new Size(627, 41);
            AnimatedText.TabIndex = 0;
            AnimatedText.Text = "welcome to file searcher app\r\n";
            AnimatedText.Click += lblText_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btnstart
            // 
            btnstart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnstart.AutoSize = true;
            btnstart.BackColor = Color.FromArgb(255, 192, 128);
            btnstart.ForeColor = Color.White;
            btnstart.Location = new Point(257, 240);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(143, 45);
            btnstart.TabIndex = 2;
            btnstart.Text = "start";
            btnstart.UseVisualStyleBackColor = false;
            btnstart.Visible = false;
            btnstart.Click += btnstart_Click;
            // 
            // picture1
            // 
            picture1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            picture1.Image = (Image)resources.GetObject("picture1.Image");
            picture1.Location = new Point(645, 2);
            picture1.Name = "picture1";
            picture1.Size = new Size(435, 345);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 3;
            picture1.TabStop = false;
            picture1.Visible = false;
            picture1.Click += picture1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1080, 348);
            Controls.Add(picture1);
            Controls.Add(btnstart);
            Controls.Add(AnimatedText);
            Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Searcher";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AnimatedText;
        private System.Windows.Forms.Timer timer1;
        private Button btnstart;
        private PictureBox picture1;
    }
}
