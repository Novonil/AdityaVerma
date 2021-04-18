using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class FindPositionOfAnElementInAnInfiniteSortedArray
	{
		public static int search(int[] nums, int k)
		{
			int start = 0;
			int end = 1;
			int mid;

			while(k > nums[end])
			{
				start = end;
				end = end * 2;
			}

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
