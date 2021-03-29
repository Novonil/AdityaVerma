using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class KthSmallestElement
	{
		public static int kthSmallestElement(int[] arr, int k)
		{
			PriorityQueue<int> maxHeap = new PriorityQueue<int>(k, Comparer<int>.Create((a, b) => { return b.CompareTo(a);}));

			foreach(int i in arr)
			{
				maxHeap.Add(i);
				if(maxHeap.Size > k)
				{
					maxHeap.Poll();
				}
			}
			return maxHeap.Peek();
		}
	}
}
