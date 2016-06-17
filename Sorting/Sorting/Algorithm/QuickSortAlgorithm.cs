using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSortAlgorithm : ISortAlgorithm
    {
        public void SortNumbers(ref int[] numArray)
        {
            QuickSort(ref numArray, 0, numArray.Length - 1);
        }

        public void QuickSort(ref int[] numArray, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = (left + right) / 2;
            int temp;
            while (i <= j)
            {
                while (numArray[i] < numArray[pivot])
                {
                    i++;
                }
                while (numArray[j] > numArray[pivot])
                {
                    j--;
                }
                if (i <= j)
                {
                    temp = numArray[i];
                    numArray[i] = numArray[j];
                    numArray[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(ref numArray, left, j);
            }
            if (i < right)
            {
                QuickSort(ref numArray, i, right);
            }
        }
    }
}
