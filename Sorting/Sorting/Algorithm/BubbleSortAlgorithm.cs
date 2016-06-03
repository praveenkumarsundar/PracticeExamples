using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSortAlgorithm : ISortAlgorithm
    {
        public void SortNumbers(ref int[] numArray)
        {
            int numArrLength = numArray.Length;
            int temp = 0;

            for (int i = 0; i < numArrLength; i++)
            {
                for (int j = 0; j < numArrLength-1-i; j++)
                {
                    if (numArray[j] > numArray[j + 1])
                    {
                        temp = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = temp;
                    }
                }
            }
        }
    }
}
