using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class MaximumOfAllSubarraysOfSizeK
	{
		public static List<int> maxInWindow(int size, List<int> arr, int K)
		{
			int i = 0;
			int j = 0;
			Queue<int> maxQueue = new Queue<int>();
			List<int> result = new List<int>();

			while(j<size)
			{
				while(maxQueue.Count > 0 && arr[j] > maxQueue.Peek())
				{
					maxQueue.Dequeue();
				}
				maxQueue.Enqueue(arr[j]);

				if(j - i + 1 < K)
				{
					j++;
				}

				else if(j - i + 1 == K)
				{
					if(maxQueue.Count > 0)
					{
						result.Add(maxQueue.Peek());
					}

					if(maxQueue.Count > 0 && arr[i] == maxQueue.Peek())
					{
						maxQueue.Dequeue();
					}
					i++;
					j++;
				}
			}
			return result;
		}

		public static List<int> maxInWindowBruteForce(int size, List<int> arr, int K)
		{
			List<int> result = new List<int>();

			for(int i = 0; i < size - K + 1; i++)
			{
				int max = int.MinValue;
				for(int j = i; j<i+K; j++)
				{
					max = Math.Max(max, arr[j]);
				}
				result.Add(max);
			}
			return result;
		}
	}
}
