using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSortAlgorithm : ISortAlgorithm
    {
        public void SortNumbers(ref int[] numArray)
        {
            int start = 0;
            int end = numArray.Length;
            numArray = MergeSort(numArray);
        }

        public int[] MergeSort(int[] numArray)
        {
            int arrayLength = numArray.Length;
            if (arrayLength == 1)
                return numArray;
            int midIndex = arrayLength / 2;
            var subArray1 = MergeSort(numArray.Take(midIndex).ToArray<int>());
            var subArray2 = MergeSort(numArray.Skip(midIndex).ToArray<int>());
            return Merge(subArray1, subArray2);
        }

        public int[] Merge(int[] numArray1, int[] numArray2)
        {
            int[] sortedArray = new int[numArray1.Length + numArray2.Length];
            int index = 0;
            int i = 0, j = 0;
            while (i < numArray1.Length && j < numArray2.Length)
            {
                if (numArray1[i] < numArray2[j])
                {
                    sortedArray[index] = numArray1[i];
                    index++;
                    i++;
                }
                else
                {
                    sortedArray[index] = numArray2[j];
                    index++;
                    j++;
                }
            }

            while (i < numArray1.Length)
            {
                sortedArray[index] = numArray1[i];
                index++;
                i++;
            }
            while (j < numArray2.Length)
            {
                sortedArray[index] = numArray2[j];
                index++;
                j++;
            }
            return sortedArray;
        }
    }
}
