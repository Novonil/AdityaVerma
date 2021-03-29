using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class SumOfElementsBetweenK1SmallestAndK2Smallest
	{
		public static int sum(int[] arr, int k1, int k2)
		{
			int result = 0;
			if(k1 == k2)
			{
				return result;
			}

			PriorityQueue<int> maxHeapk1 = new PriorityQueue<int>(k1, Comparer<int>.Create((a,b) => { return b.CompareTo(a); }));
			PriorityQueue<int> maxHeapk2 = new PriorityQueue<int>(k2, Comparer<int>.Create((a, b) => { return b.CompareTo(a); }));

			foreach(int i in arr)
			{
				maxHeapk1.Add(i);
				maxHeapk2.Add(i);
				if(maxHeapk1.Size > k1)
				{
					maxHeapk1.Poll();
				}
				if(maxHeapk2.Size > k2)
				{
					maxHeapk2.Poll();
				}
			}
			if(k1 > k2)
			{
				if(k1 == maxHeapk1.Size)
				{
					maxHeapk1.Poll();
				}
				while(maxHeapk1.Size > maxHeapk2.Size)
				{
					result += maxHeapk1.Peek();
					maxHeapk1.Poll();
				}
			}
			else
			{
				if (k2 == maxHeapk2.Size)
				{
					maxHeapk2.Poll();
				}
				while (maxHeapk2.Size > maxHeapk1.Size)
				{
					result += maxHeapk2.Peek();
					maxHeapk2.Poll();
				}
			}
			return result;
		}
	}
}
