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
