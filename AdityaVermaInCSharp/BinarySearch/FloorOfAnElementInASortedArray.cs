using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class FloorOfAnElementInASortedArray
	{
		public static int floor(int[] nums, int k)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;
			int flr = -1;
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[mid] == k)
				{
					flr = nums[mid];
					return flr;
				}
					
				else if(nums[mid] < k)
				{
					flr = nums[mid];
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}
			return flr;
		}
	}
}
