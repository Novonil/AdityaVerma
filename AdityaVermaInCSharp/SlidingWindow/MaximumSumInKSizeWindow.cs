using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class MaximumSumInKSizeWindow
	{
		public static int maxSum(int size, List<int> arr, int K)
		{
			int i = 0;
			int j = 0;
			int max = int.MinValue;
			int sum = 0;

			while(j < size)
			{
				sum += arr[j];
				if(j - i + 1 < K)
				{
					j++;
				}
				else if(j-i+1 == K)
				{
					max = Math.Max(max,sum);
					sum -= arr[i];
					i++;
					j++;
				}
			}
			return max;
		}
		public static int maxSumBruteForce(int size, List<int> arr, int K)
		{
			int maxSum = int.MinValue;

			for(int i = 0; i<size-K + 1; i++)
			{
				int sum = 0;
				for(int j = i; j < i+K; j++)
				{
					sum += arr[j];
				}
				maxSum = Math.Max(maxSum, sum);
			}
			return maxSum;
		}
	}
}
