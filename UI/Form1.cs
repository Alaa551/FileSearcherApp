namespace FileSearcherApp
{
    public partial class Form1 : Form
    {
        private string text;
        private int len = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            text = AnimatedText.Text;
            AnimatedText.Text = "";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (len < text.Length)
            {
                AnimatedText.Text = AnimatedText.Text + text.ElementAt(len);
                len++;
                //if (len == 8)
                //{
                //    picture1.Visible = true;
                //}

            }

            else
            {
                timer1.Stop();
                btnstart.Visible = true;
                picture1.Visible = true;
            }
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void picture1_Click(object sender, EventArgs e)
        {

        }
    }
}
