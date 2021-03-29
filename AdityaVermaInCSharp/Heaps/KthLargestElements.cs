using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class KthLargestElements
	{
		public static int[] kthLargestElements(int[] arr, int k)
		{
			List<int> result = new List<int>();
			PriorityQueue<int> minHeap = new PriorityQueue<int>();

			foreach (int i in arr)
			{
				minHeap.Add(i);
				if(minHeap.Size > k)
				{
					minHeap.Poll();
				}
			}

			while(minHeap.Size > 0)
			{
				result.Add(minHeap.Peek());
				minHeap.Poll();
			}

			return result.ToArray();
		}
	}
}
