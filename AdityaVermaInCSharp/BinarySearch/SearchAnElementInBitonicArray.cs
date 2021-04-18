using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class SearchAnElementInBitonicArray
	{
		public static int search(int[] nums, int k)
		{
			int peak = peakElement(nums);
			int left = binarySearch(nums, 0, peak, k);
			int right = binarySearch(nums, peak + 1, nums.Length -1, k);
			return left == -1 ? right : left;
		}
		public static int peakElement(int[] nums)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;

			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (mid == 0 && nums[mid] > nums[mid + 1])
					return mid;
				else if (mid == nums.Length - 1 && nums[mid] > nums[mid - 1])
					return mid;
				else if (mid > 0 && mid < nums.Length && nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
					return mid;
				else if (nums[mid] < nums[mid - 1])
					end = mid - 1;
				else if (nums[mid] < nums[mid + 1])
					start = mid + 1;
			}
			return -1;
		}

		public static int binarySearch(int[] nums, int start, int end, int k)
		{
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
