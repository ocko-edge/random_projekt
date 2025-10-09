using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace random_projekt
{
    internal class MyMath
    {
        public float result;

        public float calculateEntry(string mathematicalEntry, TextBox entryArea)
        {
            try
            {
                // Convert ^ operators to Power() syntax
                string expression = ConvertExponentiation(mathematicalEntry);

                // Create DataTable
                DataTable table = new DataTable();

                // Evaluate expression
                object evalResult = table.Compute(expression, "");

                // Convert to float and save to field
                result = Convert.ToSingle(evalResult);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
                return 0;
            }
        }

        // Converts something like 2^3+4 into Power(2,3)+4
        private string ConvertExponentiation(string expr)
        {
            while (expr.Contains("^"))
            {
                int index = expr.IndexOf('^');

                // Find left number
                int left = index - 1;
                while (left >= 0 && (char.IsDigit(expr[left]) || expr[left] == '.'))
                    left--;

                // Find right number
                int right = index + 1;
                while (right < expr.Length && (char.IsDigit(expr[right]) || expr[right] == '.'))
                    right++;

                string leftNum = expr.Substring(left + 1, index - left - 1);
                string rightNum = expr.Substring(index + 1, right - index - 1);

                string powerExpr = $"Power({leftNum},{rightNum})";
                expr = expr.Substring(0, left + 1) + powerExpr + expr.Substring(right);
            }
            return expr;
        }
    }
 }