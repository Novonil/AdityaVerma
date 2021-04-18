using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class IndexOfFirst1InABinarySortedInfinteArray
	{
		public static int firstOccurence(int[] nums)
		{
			int start = 0;
			int end = 1;

			while(nums[end] == 0)
			{
				start = end;
				end = end * 2;
			}

			return firstOccurence(nums, start, end);
		}

		public static int firstOccurence(int[] nums, int start, int end)
		{
			int mid;
			int res = -1;

			while (start <= end)
			{
				mid = start + (end - start) / 2;

				if(nums[mid] == 1)
				{
					res = mid;
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return res;
		}
	}
}
