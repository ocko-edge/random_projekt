namespace random_projekt
{
    public partial class Form1 : Form
    {
        MyMath myMath = new MyMath();
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            myMath.calculateEntry(entryArea.Text, entryArea);
        }
    }
}
