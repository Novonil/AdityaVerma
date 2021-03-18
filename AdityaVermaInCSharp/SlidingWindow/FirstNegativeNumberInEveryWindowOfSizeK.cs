using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class FirstNegativeNumberInEveryWindowOfSizeK
	{
		public static List<int> findFirstNegative(int size, List<int> arr, int K)
		{
			int i = 0;
			int j = 0;
			Queue<int> negativeNumberQueue = new Queue<int>();

			List<int> result = new List<int>();

			while (j < size)
			{
				if (arr[j] < 0)
				{
					negativeNumberQueue.Enqueue(arr[j]);
				}
				if (j - i + 1 < K)
				{
					j++;
				}
				else if (j - i + 1 == K)
				{
					if (negativeNumberQueue.Count == 0)
					{
						result.Add(0);
					}
					else
					{
						result.Add(negativeNumberQueue.Peek());
						if (negativeNumberQueue.Peek() == arr[i])
						{
							negativeNumberQueue.Dequeue();
						}
					}
					i++;
					j++;
				}
			}
			return result;
		}

		public static List<int> findFirstNegativeBruteForce(int size, List<int> arr, int K)
		{
			List<int> result = new List<int>();

			for (int i = 0; i < size - K + 1; i++)
			{
				bool foundNegatives = false;
				for (int j = i; j < i + K; j++)
				{
					if (arr[j] < 0)
					{
						foundNegatives = true;
						result.Add(arr[j]);
						break;
					}
				}
				if (!foundNegatives)
				{
					result.Add(0);
				}
			}
			return result;
		}
	}
}
