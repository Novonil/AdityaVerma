using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class PeakElement
	{
		public static int peak(int[] nums)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;
			if (nums.Length == 0)
				return -1;
			if (nums.Length == 1)
				return 0;
			if (nums.Length == 2)
				return nums[0] > nums[1] ? 0 : 1;

			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (mid > 0 && mid < nums.Length && nums[mid] > nums[mid + 1] && nums[mid] > nums[mid - 1])
				{
					return mid;
				}
				else if(nums[mid] < nums[mid - 1])
				{
					end = mid - 1;
				}
				else if(nums[mid] < nums[mid + 1])
				{
					start = mid + 1;
				}
				if(mid == 0 && nums[mid] > nums[mid+1])
				{
					return 0;
				}
				else if(mid == nums.Length - 1 && nums[mid] > nums[mid -1])
				{
					return nums.Length - 1;
				}
			}
			return -1;
		}
	}
}
