using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace random_projekt
{
    internal class MyMath
    {
        float result;

        public float calculateEntry(string mathematicalEntry, TextBox entryArea)
        {
            List<object> entries = new List<object>();

            foreach (char c in mathematicalEntry)
            {
                entries.Add(c);
            }

            for (int i = 0; i < entries.Count; i++)
            {
                string current = entries[i].ToString();
                if (current == "^")
                {
                    float left = float.Parse(entries[i - 1].ToString());
                    float right = float.Parse(entries[i + 1].ToString());
                    float temp = (float)Math.Pow(left, right);

                    entries[i - 1] = temp.ToString();
                    entries.RemoveAt(i);
                    entries.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < entries.Count; i++)
            {
                string current = entries[i].ToString();
                if (current == "*" || current == "/")
                {
                    float left = float.Parse(entries[i - 1].ToString());
                    float right = float.Parse(entries[i + 1].ToString());
                    float temp;

                    if (current == "*")
                    {
                        temp = left * right;
                    }
                    else
                    {
                        temp = left / right;
                    }

                    entries[i - 1] = temp.ToString();
                    entries.RemoveAt(i);
                    entries.RemoveAt(i); 
                    i--;
                }
            }

            for (int i = 0; i < entries.Count; i++)
            {
                string current = entries[i].ToString();
                if (current == "+" || current == "-")
                {
                    float left = float.Parse(entries[i - 1].ToString());
                    float right = float.Parse(entries[i + 1].ToString());
                    float temp;

                    if (current == "+")
                    {
                        temp = left + right;
                    }
                    else
                    {
                        temp = left - right;
                    }

                    entries[i - 1] = temp.ToString();
                    entries.RemoveAt(i); 
                    entries.RemoveAt(i); 
                    i--;
                }
            }
            return result;
        }
    }
}
