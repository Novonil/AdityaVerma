using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class KClosestNumbers
	{
		public static List<int> kClosestNumbersToX(int[] arr, int X, int k)
		{
			List<int> result = new List<int>();
			PriorityQueue<(int,int)> maxHeap = new PriorityQueue<(int,int)>(k, Comparer<(int,int)>.Create((a, b) => { return b.Item1.CompareTo(a.Item1); }));

			foreach(int i in arr)
			{
				int diff = Math.Abs(X-i);
				maxHeap.Add((diff,i));
				if(maxHeap.Size > k)
				{
					maxHeap.Poll();
				}
			}


			while(maxHeap.Size > 0)
			{
				result.Add(maxHeap.Peek().Item2);
				maxHeap.Poll();
			}

			return result;
		}
	}
}
