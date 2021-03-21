using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class MaximumOfAllSubarraysOfSizeK
	{
		public static int[] maxInWindow(int[] nums, int k)
		{

			if (k > nums.Length)
			{
				int max = nums.Max();
				return new int[] { max };
			}
			int left = 0;
			int right = 0;
			int size = nums.Length;
			List<int> maxList = new List<int>();
			List<int> result = new List<int>();

			while (right < size)
			{
				int windowSize = right - left + 1;
				while (maxList.Count > 0 && nums[right] > maxList[maxList.Count - 1])
				{
					maxList.RemoveAt(maxList.Count - 1);
				}
				maxList.Add(nums[right]);
				if (windowSize < k)
				{
					right++;
				}
				else if (windowSize == k)
				{
					if (maxList.Count > 0)
					{
						result.Add(maxList[0]);
					}
					if (maxList.Count > 0 && maxList[0] == nums[left])
					{
						maxList.RemoveAt(0);
					}
					left++;
					right++;
				}
			}
			return result.ToArray();
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
