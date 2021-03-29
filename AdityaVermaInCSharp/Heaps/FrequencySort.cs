using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Heaps
{
	class FrequencySort
	{
		public static List<int> sortFrequency(int[] arr)
		{
			PriorityQueue<(int, int)> maxHeap = new PriorityQueue<(int, int)>(arr.Length,Comparer<(int,int)>.Create((a,b) => { return b.Item1.CompareTo(a.Item1);  }));
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
				maxHeap.Add((kv.Value,kv.Key));
			}

			while(maxHeap.Size > 0)
			{
				int freq = maxHeap.Peek().Item1;
				int num = maxHeap.Peek().Item2;
				for(int i = 1; i <= freq; i++)
				{
					result.Add(num);
				}
				maxHeap.Poll();
			}
			return result;
		}
	}
}
