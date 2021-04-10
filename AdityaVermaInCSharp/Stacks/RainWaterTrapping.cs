using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class RainWaterTrapping
	{
		public static int totalWater(int[] arr)
		{
			int n = arr.Length;
			int[] left = findGreatestToLeft(n, arr);
			int[] right = findGreatestToRight(n, arr);
			int sum = 0;

			for(int i = 0; i<n; i++)
			{
				sum += Math.Min(left[i], right[i]) - arr[i];
			}
			return sum;
		}

		public static int[] findGreatestToLeft(int n, int[] arr)
		{
			int[] greatest = new int[n];
			greatest[0] = arr[0];
			for(int i = 1; i<n; i++)
			{
				greatest[i] = Math.Max(greatest[i - 1], arr[i]);
			}
			return greatest;
		}


		public static int[] findGreatestToRight(int n, int[] arr)
		{
			int[] greatest = new int[n];
			greatest[n - 1] = arr[n-1];
			
			for(int i = n-2; i>=0; i--)
			{
				greatest[i] = Math.Max(greatest[i + 1], arr[i]);
			}
			return greatest;
		}
	}
}
