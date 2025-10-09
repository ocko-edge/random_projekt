using System;
using System.Data;
using System.Windows.Forms;

namespace random_projekt
{
    internal class MyMath
    {
        public float result;

        public float calculateEntry(string mathematicalEntry, TextBox entryArea)
        {
            try
            {
                // Create DataTable to use Compute
                DataTable table = new DataTable();

                // Evaluate the math expression
                object evalResult = table.Compute(mathematicalEntry, "");

                // Convert to float
                result = Convert.ToSingle(evalResult);

                // Return or show result
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
                return 0;
            }
        }
    }
}
