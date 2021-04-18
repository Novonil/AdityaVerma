using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class BinarySearchOrderAgnostic
	{
		public static int search(int[] nums, int k)
		{
			if (nums.Length == 0)
				return -1;
			int len = nums.Length;
			int result = -1;
			if (nums[0] > nums[len - 1])
			{
				result = searchDescending(nums, k);
			}
			else
			{
				result = searchAscending(nums, k);
			}
			return result;
		}

		public static int  searchDescending(int[] nums, int k)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[mid] == k)
					return mid;
				else if (nums[mid] > k)
					start = mid + 1;
				else
					end = mid - 1;
			}
			return -1;
		}

		public static int searchAscending(int[] nums, int k)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[mid] == k)
					return mid;
				else if (nums[mid] > k)
					end = mid - 1;
				else
					start = mid + 1;
			}
			return -1;
		}
	}
}
