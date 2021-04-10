using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class MaximumAreaRectangleOfBinaryMatrix
	{
		public static int maxArea(int[][] arr)
		{
			int max = int.MinValue;
			int row = arr.Length;
			int col = arr[0].Length;

			int[] histogram = new int[col];
			
			for(int i = 0; i < row; i++)
			{
				for(int j = 0; j < col; j++)
				{
					histogram[i] = arr[i][j] == 0 ? 0 : histogram[i] + 1;
				}
				max = Math.Max(max, maxAreaOfHistogram(col, histogram));
			}
			return max;
		}

		public static int maxAreaOfHistogram(int n, int[] arr)
		{
			int[] left = nextSmallerToLeft(n, arr);
			int[] right = nextSmallerToRight(n, arr);
			int max = int.MinValue;
			
			
			for(int i = 0; i < n; i++)
			{
				int width = right[i] - left[i] - 1;
				max = Math.Max(max, width * arr[i]);
			}
			return max;
		}


		public static int[] nextSmallerToLeft(int n, int[] arr)
		{
			int[] nextSmaller = new int[n];
			Stack<int> stck = new Stack<int>();

			for(int i = 0; i < n; i++)
			{
				while(stck.Count > 0 && arr[stck.Peek()] >= arr[i])
				{
					stck.Pop();
				}
				nextSmaller[i] = stck.Count == 0 ? -1 : stck.Peek();
				stck.Push(i);
			}
			return nextSmaller;
		}

		public static int[] nextSmallerToRight(int n, int[] arr)
		{
			int[] nextSmaller = new int[n];
			Stack<int> stack = new Stack<int>();

			for(int i = n-1; i>=0; i--)
			{
				while(stack.Count > 0 && arr[stack.Peek()] >= arr[i])
				{
					stack.Pop();
				}
				nextSmaller[i] = stack.Count == 0 ? n : stack.Peek();
				stack.Push(i);
			}
			return nextSmaller;
		}
	}
}
