using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class SearchingInANearlySortedArray
	{
		public static int search(int[] nums, int k)
		{
			int len = nums.Length;
			int start = 0;
			int end = len - 1;
			int mid;
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[mid] == k)
					return mid;
				else if (mid - 1 >= 0 && nums[mid - 1] == k)
					return mid - 1;
				else if (mid + 1 <= len && nums[mid + 1] == k)
					return mid + 1;

				else if(nums[mid] > k)
				{
					end = mid - 2;
				}
				else if(nums[mid] < k)
				{
					start = mid + 2;
				}
			}
			return -1;
		}
	}
}
