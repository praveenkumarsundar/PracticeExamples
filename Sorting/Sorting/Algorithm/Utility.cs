using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Utility
    {
        public static int FindMaxValue(int[] numArray)
        {
            int max = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] > max) max = numArray[i];
            }
            return max;
        }
    }
}
