using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class CountOfElementsInASortedArray
	{
		public static int count(int[] nums, int k)
		{
			int first = firstOccurence(nums, k);
			int last = lastOccurence(nums, k);
			return last == -1 ? 0 : last - first + 1;
		}
		public static int firstOccurence(int[] nums, int k)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;
			int res = -1;
			
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[mid] == k)
				{
					res = mid;
					end = mid - 1;
				}
				else if (nums[mid] > k)
					end = mid - 1;
				else
					start = mid + 1;	
			}
			return res;
		}

		public static int lastOccurence(int[] nums, int k)
		{
			int start = 0;
			int end = nums.Length - 1;
			int mid;
			int res = -1;
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if (nums[mid] == k)
				{
					res = mid;
					start = mid + 1;
				}
				else if (nums[mid] > k)
					end = mid - 1;
				else
					start = mid + 1;
			}
			return res;
		}
	}
}
