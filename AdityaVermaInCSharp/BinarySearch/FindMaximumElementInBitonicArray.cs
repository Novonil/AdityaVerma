using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class FindMaximumElementInBitonicArray
	{
		public static int maxElement(int[] nums)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;

			while(start <= end)
			{
				mid = start + (end - start) / 2;

				if (mid == 0 && nums[mid] > nums[mid + 1])
					return nums[mid];
				else if (mid == nums.Length && nums[mid] > nums[mid - 1])
					return nums[mid];
				else if (mid > 0 && mid < nums.Length && nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
					return nums[mid];
				else if (nums[mid] < nums[mid - 1])
					end = mid - 1;
				else if (nums[mid] < nums[mid + 1])
					start = mid + 1;
			}
			return -1;
		}
	}
}
