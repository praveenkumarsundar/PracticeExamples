using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[12]  { 1, 4, 6, 7, 10, 15, 17, 21, 24, 29, 37, 50 };

            int SearchedNumber = 50;

            int index = -1;

            SearchedNumber = 50;
            index = FindIndexByBinarySearch(SearchedNumber, numArray);
            
            SearchedNumber = 1;
            index = FindIndexByBinarySearch(SearchedNumber, numArray);

            SearchedNumber = 17;
            index = FindIndexByBinarySearch(SearchedNumber, numArray);

            SearchedNumber = 10;
            index = FindIndexByBinarySearch(SearchedNumber, numArray);

            SearchedNumber = 4;
            index = FindIndexByBinarySearch(SearchedNumber, numArray);

            SearchedNumber = 37;
            index = FindIndexByBinarySearch(SearchedNumber, numArray);

            SearchedNumber = 21;
            index = FindIndexByBinarySearch(SearchedNumber, numArray);

            int startIndex = 0;
            int endIndex = numArray.Length - 1;
            int mid = (startIndex + endIndex) / 2;

            SearchedNumber = 50;
            index = FindIndexByBinarySearchRecursive(SearchedNumber, numArray,startIndex, mid, endIndex);

            SearchedNumber = 1;
            index = FindIndexByBinarySearchRecursive(SearchedNumber, numArray, startIndex, mid, endIndex);

            SearchedNumber = 17;
            index = FindIndexByBinarySearchRecursive(SearchedNumber, numArray, startIndex, mid, endIndex);

            SearchedNumber = 10;
            index = FindIndexByBinarySearchRecursive(SearchedNumber, numArray, startIndex, mid, endIndex);

            SearchedNumber = 4;
            index = FindIndexByBinarySearchRecursive(SearchedNumber, numArray, startIndex, mid, endIndex);

            SearchedNumber = 37;
            index = FindIndexByBinarySearchRecursive(SearchedNumber, numArray, startIndex, mid, endIndex);

            SearchedNumber = 21;
            index = FindIndexByBinarySearchRecursive(SearchedNumber, numArray, startIndex, mid, endIndex);

        }

        public static int FindIndexByBinarySearch(int SearchedNumber, int[] numArray)
        {
            int searchIndex = -1;
            int startIndex = 0;
            int endIndex = numArray.Length-1;
            int mid = (startIndex + endIndex) / 2;

            while (startIndex <= endIndex)
            {
                mid = (startIndex+ endIndex) / 2;
                if (numArray[mid] == SearchedNumber)
                {
                    searchIndex = mid;
                    break;
                }
                else if (numArray[mid] > SearchedNumber)
                {
                    endIndex = mid -1;
                    continue;
                }
                else if (numArray[mid] < SearchedNumber)
                {
                    startIndex = mid +1;
                    continue;
                }
            }
            return searchIndex;
        }

        public static int FindIndexByBinarySearchRecursive(int SearchedNumber, int[] numArray, int startIndex, int mid, int endIndex)
        {
            if(startIndex> endIndex)
            {
                return -1;
            }

            if (numArray[mid] == SearchedNumber)
            {
                return mid;
            }
            else if (numArray[mid] > SearchedNumber)
            {
                endIndex = mid - 1;
                mid = (startIndex + endIndex) / 2;
                return FindIndexByBinarySearchRecursive(SearchedNumber, numArray, startIndex, mid, endIndex);
            }
            else if (numArray[mid] < SearchedNumber)
            {
                startIndex = mid + 1;
                mid = (startIndex + endIndex) / 2;
                return FindIndexByBinarySearchRecursive(SearchedNumber, numArray, startIndex, mid, endIndex);
            }
            return -1;
        }

    }
}
