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
            filepath1LB.Text = ofd.FileName;
            Compare();
        }

        private void file2BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filePath2 = ofd.FileName;
            filepath2LB.Text = ofd.FileName;
            Compare();
        }

        private void Compare()
        {
            if (filePath1 != "" && filePath2 != "")
            {
                statusLB.ForeColor = Color.Orange;
                statusLB.Text = "Checking...";

                extraStatusLB.Text = 
                    $"File Length Diff: {Math.Abs(File.ReadAllBytes(filePath1).Length - File.ReadAllBytes(filePath2).Length)} bytes";
                byte[] f1 = File.ReadAllBytes(filePath1);
                byte[] f2 = File.ReadAllBytes(filePath2);
                if (f1.SequenceEqual(f2)) // Compare the contents of the arrays
                {
                    statusLB.ForeColor = Color.LightGreen;
                    statusLB.Text = "They are the same!";
                }
                else
                {
                    statusLB.ForeColor = Color.FromArgb(255,96,96);
                    statusLB.Text = "They are NOT the same!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("""
                Click on the first button to select file 1
                Click on the second button to select file 2
                The Textbox/Label in the Middle will say whether the 2 files are the same or not

                © 2024 Mervinpais @ github.com/Mervinpais
                """);
        }
    }
}
