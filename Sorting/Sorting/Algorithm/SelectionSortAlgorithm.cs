using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSortAlgorithm : ISortAlgorithm
    {
        public void SortNumbers(ref int[] numArray)
        {
            int min = 0;
            int temp = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                min = i;
                for (int j = i; j < numArray.Length; j++)
                {
                    if (numArray[min] > numArray[j])
                    {
                        min = j;
                    }
                }
                if(i!=min)
                {
                    temp = numArray[i];
                    numArray[i] = numArray[min];
                    numArray[min] = temp;
                }
            }
        }
    }
}
