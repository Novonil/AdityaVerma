using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class LargestSubarrayOfSumK
	{
		public static int maximumWindowSize(int size, List<int> arr, int sum)
		{
			//Positive Numbers Only
			int i = 0;
			int j = 0;
			long s = 0;
			int maxWindowSize = int.MinValue;

			while(j<size)
			{
				s += arr[j];
				if(s < sum)
				{
					//j++;

				}
				else if (s == sum)
				{
					maxWindowSize = Math.Max(maxWindowSize, j - i + 1);
					//j++;
				}
				else if (s > sum)
				{
					while (s > sum)
					{
						s -= arr[i];
						i++;
					}
					if(s == sum)
					{
						maxWindowSize = Math.Max(maxWindowSize, j - i + 1);
					}
				}
				j++;
			}
			return maxWindowSize;
		}
		public static int maxWindowSizeBruteForce(int size, List<int> arr, int sum)
		{
			int maxWindow = int.MinValue;

			for(int i = 1; i < size; i++)
			{
				for(int j = 0; j < size - i + 1; j++)
				{
					int s = 0;
					for(int k = j; k < j + i; k++)
					{
						s += arr[k];
					}
					if(s == sum)
					{
						maxWindow = Math.Max(maxWindow, i);
					}
				}
			}
			return maxWindow;
		}
	}
}
