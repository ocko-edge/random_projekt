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
            label1.Text = (-result * 2).ToString();
            label2.Text = (result * 2).ToString();
            if (result < 0)
            {
                negativeResult.Visible = true;
                plusResult.Visible = false;
                label3.Text = result.ToString();
                label3.Visible = true;
                label4.Visible = false;
            }
            else
            {
                negativeResult.Visible = false;
                plusResult.Visible = true;
                label4.Text = result.ToString();
                label4.Visible = true;
                label3.Visible = false;
            }
        }
    }
}
