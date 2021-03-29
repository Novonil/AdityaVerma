using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class TopKFrequentNumbers
	{
		public static List<int> topKfreqNumbers(int[] arr, int k)
		{
			PriorityQueue<(int, int)> minHeap = new PriorityQueue<(int, int)>(1, Comparer<(int, int)>.Create((a, b) => { return a.CompareTo(b); }));
			Dictionary<int, int> freqMap = new Dictionary<int, int>();
			List<int> result = new List<int>();

			foreach(int i in arr)
			{
				if(freqMap.ContainsKey(i))
				{
					freqMap[i]++;
				}
				else
				{
					freqMap.Add(i, 1);
				}
			}

			foreach(KeyValuePair<int,int> kv in freqMap)
			{
				minHeap.Add((kv.Value,kv.Key));
				if(minHeap.Size > k)
				{
					minHeap.Poll();
				}
			}

			while(minHeap.Size > 0)
			{
				result.Add(minHeap.Peek().Item2);
				minHeap.Poll();
			}
			return result;
		}
	}
}
