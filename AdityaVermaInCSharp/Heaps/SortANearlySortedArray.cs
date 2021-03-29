using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class SortANearlySortedArray
	{
		public static int[] sortInAscending(int[] arr, int k)
		{
			PriorityQueue<int> minHeap = new PriorityQueue<int>();
			List<int> sortedArray = new List<int>();

			foreach(int i in arr)
			{
				minHeap.Add(i);
				if(minHeap.Size > k)
				{
					sortedArray.Add(minHeap.Peek());
					minHeap.Poll();
				}
			}

			while(minHeap.Size > 0)
			{
				sortedArray.Add(minHeap.Peek());
				minHeap.Poll();
			}
			return sortedArray.ToArray();
		}

		public static int[] sortInDescending(int[] arr, int k)
		{
			PriorityQueue<int> maxHeap = new PriorityQueue<int>(k, Comparer<int>.Create((a, b) => { return b.CompareTo(a); }));
			List<int> sortedArray = new List<int>();

			foreach(int i in arr)
			{
				maxHeap.Add(i);
				if(maxHeap.Size > k)
				{
					sortedArray.Add(maxHeap.Peek());
					maxHeap.Poll();
				}
			}

			while(maxHeap.Size > 0)
			{
				sortedArray.Add(maxHeap.Peek());
				maxHeap.Poll();
			}
			return sortedArray.ToArray();
		}
	}
}
