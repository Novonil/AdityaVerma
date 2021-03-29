using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class MinimizeCostToConnectRopes
	{
		public static int minimumCost(int[] arr)
		{
			int cost = 0;
			PriorityQueue<int> minHeap = new PriorityQueue<int>();

			foreach(int i in arr)
			{
				minHeap.Add(i);
			}

			while(minHeap.Size >= 2)
			{
				int r1 = minHeap.Peek();
				minHeap.Poll();
				int r2 = minHeap.Peek();
				minHeap.Poll();
				cost += r1 + r2;
				minHeap.Add(r1 + r2);
			}
			return cost;
		}
	}
}
