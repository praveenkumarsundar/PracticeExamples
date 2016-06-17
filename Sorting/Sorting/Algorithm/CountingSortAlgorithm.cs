using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    using System.Security.Cryptography.X509Certificates;

    public class CountingSortAlgorithm : ISortAlgorithm
    {
        public void SortNumbers(ref int[] numArray)
        {
            int MaxValue = Utility.FindMaxValue(numArray); // Instead of using Max Value, should try to have unique key
            int[] countArray = new int[MaxValue+1];
            int[] outputArray = new int[numArray.Length];

            for (int i = 0; i < numArray.Length; i++)
            {
                countArray[numArray[i]] = countArray[numArray[i]] + 1;
            }

            int oldCount = 0;
            int total = 0;
            for (int j = 0; j < countArray.Length; j++)
            {
                oldCount = countArray[j];
                countArray[j] =  total;
                total = oldCount + total;
            }
            for (int i = 0; i < numArray.Length; i++)
            {
                outputArray[countArray[numArray[i]]] = numArray[i];
                countArray[numArray[i]] = countArray[numArray[i]] + 1;
            }
            numArray = outputArray;
        }

       
    }
}
