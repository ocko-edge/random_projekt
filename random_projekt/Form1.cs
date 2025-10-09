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
            float result = myMath.calculateEntry(entryArea.Text, entryArea);
            label1.Text = (result * -2).ToString();
            label2.Text = (result * 2).ToString();
        }
    }
}
