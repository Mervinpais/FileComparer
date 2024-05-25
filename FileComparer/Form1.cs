namespace FileComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath1 = "";
        string filePath2 = "";
        private void file1BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filePath1 = ofd.FileName;
            Compare();
        }

        private void file2BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filePath2 = ofd.FileName;
            Compare();
        }

        private void Compare()
        {
            if (filePath1 != "" && filePath2 != "")
            {
                if (File.ReadAllBytes(filePath1) == File.ReadAllBytes(filePath2))
                {
                    statusLB.ForeColor = Color.Green;
                    statusLB.Text = "They are the same!";
                }
                else
                {
                    statusLB.ForeColor = Color.Red;
                    statusLB.Text = "They are NOT the same!";
                }
            }
        }
    }
}
