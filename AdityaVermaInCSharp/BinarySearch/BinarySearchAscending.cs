using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class BinarySearchAscending
	{
		public static int search(int[] nums, int k)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if(nums[mid] == k)
				{
					return mid;
				}
				else if(nums[mid] > k)
				{
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return -1;
		}
	}
}
