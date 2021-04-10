using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class MaximumAreaOfHistogram
	{
		public static int maxArea(int[] arr)
		{
			int n = arr.Length;
			int[] left = nearestSmallerToLeft(n, arr);
			int[] right = nearestSmallerToRight(n, arr);
			int max = int.MinValue;

			for(int i = 0; i < n; i++)
			{
				int width = right[i] - left[i] - 1;
				max = Math.Max(max, arr[i] * width);
			}
			return max;
		}

		public static int[] nearestSmallerToLeft(int n, int[] arr)
		{
			int[] nearestSmaller = new int[n];
			Stack<int> stck = new Stack<int>();

			for(int i = 0; i < n; i++)
			{
				while(stck.Count > 0 && arr[stck.Peek()] >= arr[i])
				{
					stck.Pop();
				}
				nearestSmaller[i] = stck.Count == 0 ? -1 : stck.Peek();
				stck.Push(i);
			}
			return nearestSmaller;
		}

		public static int[] nearestSmallerToRight(int n, int[] arr)
		{
			int[] nearestSmaller = new int[n];
			Stack<int> stck = new Stack<int>();

			for(int i = n-1; i>=0;i--)
			{
				while(stck.Count > 0 && arr[stck.Peek()] >= arr[i])
				{
					stck.Pop();
				}
				nearestSmaller[i] = stck.Count == 0 ? n : stck.Peek();
				stck.Push(i);
			}
			return nearestSmaller;
		}
	}
}
