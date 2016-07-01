using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numArray = { 89, 76, 45, 92, 67, 12, 99 };
            int[] numArray = { 100, 89, 69, 49, 39, 15, 1 };
            //int[] numArray = { 89, 76, 45, 92, 67, 12, 99 };

            ISortAlgorithm bubbleSorter = new BubbleSortAlgorithm();
            Console.WriteLine("Before Bubble Sort");
            PrintArray(numArray);
            bubbleSorter.SortNumbers(ref numArray);
            Console.WriteLine("After Bubble Sort");
            PrintArray(numArray); 

            int[] numArray1 = { 1, 16, 35, 25, 65, 85, 99 };
            ISortAlgorithm insertionSorter = new InsertionSortAlgorithm();
            Console.WriteLine("Before Insertion Sort");
            PrintArray(numArray1);
            insertionSorter.SortNumbers(ref numArray1);
            Console.WriteLine("After Insertion Sort");
            PrintArray(numArray1);

            int[] numArray2 = { 99, 1, 36, 0, 32, 9, 89 };
            ISortAlgorithm selectionSorter = new SelectionSortAlgorithm();
            Console.WriteLine("Before Selection Sort");
            PrintArray(numArray2);
            selectionSorter.SortNumbers(ref numArray2);
            Console.WriteLine("After Selection Sort");
            PrintArray(numArray2);

            int[] numArray3 = { 89, 76, 45, 92, 67, 12, 99 };
            ISortAlgorithm mergeSorter = new MergeSortAlgorithm();
            Console.WriteLine("Before Merge Sort");
            PrintArray(numArray3);
            mergeSorter.SortNumbers(ref numArray3);
            Console.WriteLine("After Merge Sort");
            PrintArray(numArray3);

            int[] numArray4 = { 89, 76, 45, 92, 67, 12, 99 };
            ISortAlgorithm quickSorter = new QuickSortAlgorithm();
            Console.WriteLine("Before Quick Sort");
            PrintArray(numArray4);
            quickSorter.SortNumbers(ref numArray4);
            Console.WriteLine("After Quick Sort");
            PrintArray(numArray4);

            int[] numArrayCountSort = { 99, 1, 36, 0, 32, 9, 89 };
            ISortAlgorithm countSorter = new CountingSortAlgorithm();
            Console.WriteLine("Before Count Sort");
            PrintArray(numArrayCountSort);
            countSorter.SortNumbers(ref numArrayCountSort);
            Console.WriteLine("After Count Sort");
            PrintArray(numArrayCountSort);

            int[] numArrayBucketSort = { 99, 1, 36, 5, 32, 9, 89 };
            ISortAlgorithm bucketSorter = new BucketSortAlgorithm();
            Console.WriteLine("Before Bucket Sort");
            PrintArray(numArrayBucketSort);
            bucketSorter.SortNumbers(ref numArrayBucketSort);
            Console.WriteLine("After Bucket Sort");
            PrintArray(numArrayBucketSort);

            CountInversionInMergeSort();
            Console.ReadLine();
        }

        public static void CountInversionInMergeSort()
        {
            MergeSortAlgorithmWithCountInv mergeSorter = new MergeSortAlgorithmWithCountInv();
            int numOfInversions = 0;
            
             Console.WriteLine("CountInversion In Merge Sort");
            int[] numArray = { 100, 89, 69, 49, 39, 15, 1 };
            Console.WriteLine("Before Merge Sort");
            PrintArray(numArray);
            mergeSorter.SortNumbers(ref numArray, ref numOfInversions);
            Console.WriteLine("After Merge Sort");
            PrintArray(numArray);
            Console.WriteLine("Num Of Inversions:" + numOfInversions);

            

            int[] numArray1 = { 1, 16, 35, 25, 65, 85, 99 };
            numOfInversions = 0;
            Console.WriteLine("Before Merge Sort");
            PrintArray(numArray1);
            mergeSorter.SortNumbers(ref numArray1, ref numOfInversions);
            Console.WriteLine("After Merge Sort");
            PrintArray(numArray1);
            Console.WriteLine("Num Of Inversions:" + numOfInversions);

            int[] numArray2 = { 99, 1, 36, 0, 32, 9, 89 };
            numOfInversions = 0;
            Console.WriteLine("Before Merge Sort");
            PrintArray(numArray2);
            mergeSorter.SortNumbers(ref numArray2, ref numOfInversions);
            Console.WriteLine("After Merge Sort");
            PrintArray(numArray2);
            Console.WriteLine("Num Of Inversions:" + numOfInversions);

            int[] numArray3 = { 89, 76, 45, 92, 67, 12, 99 };
            numOfInversions = 0;
            Console.WriteLine("Before Merge Sort");
            PrintArray(numArray3);
            mergeSorter.SortNumbers(ref numArray3, ref numOfInversions);
            Console.WriteLine("After Merge Sort");
            PrintArray(numArray3);
            Console.WriteLine("Num Of Inversions:" + numOfInversions);
        }
        public static void PrintArray (int[] numArray)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(" ~ ");
                }
                Console.Write(numArray[i]);
            }
            Console.WriteLine("");
        }
     
    }
}
