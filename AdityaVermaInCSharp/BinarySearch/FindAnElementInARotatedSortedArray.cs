using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class FindAnElementInARotatedSortedArray
	{
		public static int search(int[] nums, int k)
		{
			int pivot = rotatedArrayPosition(nums);
			pivot = pivot == 0 ? 1 : pivot;
			int first = binarySearch(nums, 0, pivot - 1, k);
			int second = binarySearch(nums, pivot, nums.Length - 1, k) ;
			return first == -1 ? second : first;
		}
		public static int rotatedArrayPosition(int[] nums)
		{
			int len = nums.Length;
			if (nums[0] < nums[len - 1])
			{
				return 0;
			}
			int start = 0;
			int end = len - 1;
			int mid;
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				int prev = (mid + len - 1) % len;
				int next = (mid + 1) % len;
				if(nums[mid] < nums[prev] && nums[mid] < nums[next])
				{
					return mid;
				}
				else if(nums[mid] > nums[0])
				{
					start = mid + 1;
				}
				else if(nums[mid] < nums[nums.Length - 1])
				{
					end = mid - 1;
				}
			}
			return 0;
		}
		public static int binarySearch(int[] nums, int start, int end, int k)
		{
			int mid;
			int res = -1;
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
			return res;
		}
	}	
}
