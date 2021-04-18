using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class MinimumDifferenceElementInASortedArray
	{
		public static int minDiff(int[] nums, int k)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;

			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[mid] == k)
					return 0;
				if (nums[mid] < k)
					start = mid + 1;
				else
					end = mid - 1;
			}
			return Math.Min(Math.Abs(nums[end] - k), Math.Abs(nums[start] - k));
		}
	}
}
