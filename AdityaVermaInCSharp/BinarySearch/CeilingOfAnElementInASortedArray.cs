using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class CeilingOfAnElementInASortedArray
	{
		public static int ceiling(int[] nums, int k)
		{
			int len = nums.Length;
			int start = 0;
			int end = len - 1;
			int mid;
			int ceil = -1;

			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[mid] == k)
				{
					ceil = nums[mid];
					return ceil;
				}
				else if(nums[mid] > k)
				{
					ceil = nums[mid];
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return ceil;
		}
	}
}
