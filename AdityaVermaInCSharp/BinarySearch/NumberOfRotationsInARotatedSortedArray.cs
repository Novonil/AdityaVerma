using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class NumberOfRotationsInARotatedSortedArray
	{
		public static int numberOfRotations(int[] nums)
		{
			int numberOfRotations = findPivot(nums);
			return numberOfRotations;
		}

		public static int findPivot(int[] nums)
		{
			int len = nums.Length;
			int start = 0;
			int end = len - 1;
			int mid;
			if (nums[0] < nums[len - 1])
				return 0;

			while (start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[(mid + len - 1) % len] > nums[mid] && nums[(mid + 1) % len] > nums[mid])
					return mid;
				else if (nums[mid] > nums[0])
				{
					start = mid + 1;
				}
				else if (nums[mid] < nums[nums.Length -1])
				{
					end = mid - 1;
				}
			}
			return 0;
		}
	}
}
