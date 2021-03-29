using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class KClosestPointsToOrigin
	{
		public static List<List<int>> kClosestPoints(int[][] arr, int k)
		{
			PriorityQueue<(int, int, int)> maxHeap = new PriorityQueue<(int, int, int)>(k, Comparer<(int, int, int)>.Create((a, b) => { return b.Item1.CompareTo(a.Item1); }));
			List<List<int>> result = new List<List<int>>();

			foreach(int[] i in arr)
			{
				int distance = (i[0] * i[0]) + (i[1] * i[1]);
				maxHeap.Add((distance,i[0],i[1]));

				if(maxHeap.Size > k)
				{
					maxHeap.Poll();
				}
			}

			while(maxHeap.Size > 0)
			{
				List<int> l = new List<int>();
				l.Add(maxHeap.Peek().Item1);
				l.Add(maxHeap.Peek().Item2);
				l.Add(maxHeap.Peek().Item3);
				maxHeap.Poll();
				result.Add(l);
			}
			return result;
		}
	}
}
