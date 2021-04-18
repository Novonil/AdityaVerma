using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class FirstAndLastOccurenceOfAnElement
	{
		public static int[] findOccurences(int[] nums, int k)
		{
			int[] result = new int[2];
			result[0] = findFirstOccurence(nums, k);
			result[1] = findLastOccurence(nums, k);
			return result;
		}
		public static int findFirstOccurence(int[] nums, int k)
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
				else if(nums[mid] > k)
				{
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return res;
		}

		public static int findLastOccurence(int[] nums, int k)
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
