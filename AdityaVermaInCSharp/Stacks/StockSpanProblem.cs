using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class StockSpanProblem
	{
		public static int[] stockSpan(int[] arr)
		{
			int n = arr.Length;
			int[] span = new int[n];
			int[] nearestGreaterToLeft = StockSpanProblem.nearestGreaterToLeft(n,arr);
			for(int i = 0; i < n; i++)
			{
				span[i] = i - nearestGreaterToLeft[i];
			}
			return span;
		}

		public static int[] nearestGreaterToLeft(int n, int[] arr)
		{
			int[] nearestGreater = new int[n];
			Stack<int> stck = new Stack<int>();
			int j = 0;

			for(int i = 0; i<n; i++)
			{
				while(stck.Count > 0 && arr[stck.Peek()] <= arr[i])
				{
					stck.Pop();
				}
				nearestGreater[j++] = stck.Count == 0 ? -1 : stck.Peek();
				stck.Push(i);
			}
			return nearestGreater;
		}


	}
}
