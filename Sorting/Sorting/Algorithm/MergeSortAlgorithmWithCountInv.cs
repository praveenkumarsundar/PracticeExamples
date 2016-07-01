using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSortAlgorithmWithCountInv
    {
        public void SortNumbers(ref int[] numArray, ref int numOfInversions)
        {
            int start = 0;
            int end = numArray.Length;
            numArray = MergeSort(numArray, ref numOfInversions);
        }

        public int[] MergeSort(int[] numArray, ref int numOfInversions)
        {
            int arrayLength = numArray.Length;
            if (arrayLength == 1)
                return numArray;
            int midIndex = arrayLength / 2;
            int numOfInversionsLeft = 0;
            int numOfInversionsRight = 0;
            var subArray1 = MergeSort(numArray.Take(midIndex).ToArray<int>(), ref numOfInversionsLeft);
            var subArray2 = MergeSort(numArray.Skip(midIndex).ToArray<int>(), ref numOfInversionsRight);
            numOfInversions = numOfInversions + numOfInversionsLeft;
            numOfInversions = numOfInversions + numOfInversionsRight;
            return Merge(subArray1, subArray2, ref numOfInversions);
        }

        public int[] Merge(int[] numArray1, int[] numArray2, ref int numOfInversions)
        {
            int[] sortedArray = new int[numArray1.Length + numArray2.Length];
            int index = 0;
            int i = 0, j = 0;
            //bool lastScanFromArray1 = false;
            //bool lastScanFromArray2 = false;

            while (i < numArray1.Length && j < numArray2.Length)
            {
                if (numArray1[i] < numArray2[j])
                {
                    sortedArray[index] = numArray1[i];
                    index++;
                    i++;
                    //if (lastScanFromArray2)
                    //{
                    //    numOfInversions++;
                    //}
                    //lastScanFromArray1 = true;
                    //lastScanFromArray2 = false;
                }
                else
                {
                    sortedArray[index] = numArray2[j];
                    index++;
                    j++;

                    numOfInversions = numOfInversions + numArray1.Length - i;
                    //if (lastScanFromArray1)
                    //{
                    //    numOfInversions++;
                    //}
                    //lastScanFromArray1 = false;
                    //lastScanFromArray2 = true;
                }
            }

            while (i < numArray1.Length)
            {
                sortedArray[index] = numArray1[i];
                index++;
                i++;
                //if (lastScanFromArray2)
                //{
                //    numOfInversions++;
                //    lastScanFromArray2 = false;
                //}
            }
            while (j < numArray2.Length)
            {
                sortedArray[index] = numArray2[j];
                index++;
                j++;
                //if (lastScanFromArray1)
                //{
                //    numOfInversions++;
                //    lastScanFromArray1 = false;
                //}
            }
            return sortedArray;
        }
    }
}
