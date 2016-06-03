using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    using System.Globalization;

    public class InsertionSortAlgorithm : ISortAlgorithm
    {
        public void SortNumbers(ref int[] numArray)
        {
            int numArrLength = numArray.Length;
            int currValue = 0;
            int currIndex = 0;
            
            for (int i = 1; i < numArrLength; i++)
            {
                currValue = numArray[i];
                currIndex = i;

                while (currIndex >0 )
                {
                    if (currValue < numArray[currIndex - 1])
                    {
                        numArray[currIndex] = numArray[currIndex - 1];
                    }
                    else
                    {
                        break;
                    }
                    currIndex--;
                }
                numArray[currIndex] = currValue;
            }
        }
    }
}
