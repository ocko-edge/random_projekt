using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_projekt
{
    internal class MyMath
    {
        float result;

        public float calculateEntry(string mathematicalEntry, TextBox entryArea)
        {
            if (float.TryParse(entryArea.Text, out result))
            {
                return result;
            }
            else
            {
                return result = 0;
            }
        }
    }
}
