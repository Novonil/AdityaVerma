using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class AllocateMinimumNumberOfPages
	{
		public static int minPages(int[] nums, int n)
		{
			int[] maxAndSum = maxAndSumFromArray(nums);
			int max = maxAndSum[0];
			int sum = maxAndSum[1];

			int res = search(nums, max, sum, n);
			return res;
		}

		public static int[] maxAndSumFromArray(int[] nums)
		{
			int max = int.MinValue;
			int sum = 0;
			foreach(int num in nums)
			{
				max = Math.Max(max, num);
				sum += num;
			}
			return new int[] { max, sum };
		}

		public static int search(int[] nums, int start, int end, int n)
		{
			int mid;
			int res = -1;
			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if(!validCountOfStudents(nums, mid, n))
				{
					start = mid + 1;
				}
				else
				{
					res = mid;
					end = mid - 1;
				}
			}
			return res;
		}

		public static bool validCountOfStudents(int[] nums, int max, int n)
		{
			int count = 1;
			int sum = 0;
			foreach(int num in nums)
			{
				sum += num;
				if(sum > max)
				{
					count++;
					if (count > n)
						return false;
					sum = num;
				}
			}
			return true;
		}
	}
}
