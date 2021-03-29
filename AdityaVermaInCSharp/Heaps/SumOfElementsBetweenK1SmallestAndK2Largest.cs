using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class SumOfElementsBetweenK1SmallestAndK2Largest
	{
		public static int sum(int[] arr, int k1, int k2)
		{
			int result = 0;

			PriorityQueue<int> minHeap = new PriorityQueue<int>();
			PriorityQueue<int> maxHeap = new PriorityQueue<int>(k1, Comparer<int>.Create((a, b) => { return b.CompareTo(a); }));
			
			foreach(int i in arr)
			{
				minHeap.Add(i);
				maxHeap.Add(i);
				if (minHeap.Size > k2)
					minHeap.Poll();

				if (maxHeap.Size > k1)
					maxHeap.Poll();
			}

			int top1 = maxHeap.Peek();
			int top2 = minHeap.Peek();

			if (top1 == top2)
				return 0;

			if(top1 > top2)
			{
				for(int i = 0; i< arr.Length; i++)
				{
					if (arr[i] > top2 && arr[i] < top1)
						result += arr[i];
				}
			}
			else
			{
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] > top1 && arr[i] < top2)
						result += arr[i];
				}
			}
			return result;
		}
	}
}
