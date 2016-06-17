using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BucketSortAlgorithm: ISortAlgorithm 
    {
        public void SortNumbers(ref int[] numArray)
        {
            int bucketRange = 10;
            int MaxValue = Utility.FindMaxValue(numArray);
            int bucketCount = FindBucketNumber(MaxValue, bucketRange);
           
            List<int>[] bucketList = new List<int>[bucketCount+1];
            int bucketNum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                bucketNum = FindBucketNumber(numArray[i] , bucketRange);
                if (bucketList[bucketNum] == null)
                {
                   bucketList[bucketNum] = new List<int>();
                }
                bucketList[bucketNum].Add(numArray[i]);
            }

            List<int> consolidatedList = new List<int>();

            foreach (var bucket in bucketList)
            {
                if (bucket != null)
                {
                    consolidatedList.AddRange(bucket);
                }
            }

            int[] consolidatedArray = consolidatedList.ToArray();
            ISortAlgorithm insertionSort = new InsertionSortAlgorithm();
            insertionSort.SortNumbers(ref consolidatedArray);
            numArray = consolidatedArray;
        }

        public int FindBucketNumber(int value, int bucketRange)
        {
            int bucketNum = 0;
            if (value % bucketRange == 0)
            {
                bucketNum = value / bucketRange;
            }
            else
            {
                bucketNum = value / bucketRange + 1;
            }
            return bucketNum-1;
        }
    }
}
