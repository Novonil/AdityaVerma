using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class NearestSmallerToRight
	{
		public static int[] nearestSmallerOnRight(int[] arr)
		{
			int n = arr.Length;
			int[] nearestSmaller = new int[n];
			Stack<int> stck = new Stack<int>();
			int j = n - 1;

			for(int i = n-1; i>= 0; i--)
			{
				while(stck.Count > 0 && stck.Peek() >= arr[i])
				{
					stck.Pop();
				}
				nearestSmaller[j--] = stck.Count == 0 ? -1 : stck.Peek();
				stck.Push(arr[i]);
			}
			return nearestSmaller;
		}


		public static int[] nearestSmallerOnRightBruteForce(int[] arr)
		{
			int n = arr.Length;
			int[] nearestSmaller = new int[n];
			int k = 0;
			bool flag = false;

			for(int i = 0; i < n; i++)
			{
				flag = false;
				for(int j = i+1; j < n; j++)
				{
					if(arr[j] < arr[i])
					{
						nearestSmaller[k++] = arr[j];
						flag = true;
						break;
					}
				}
				if(!flag)
				{
					nearestSmaller[k++] = -1;
				}
			}
			return nearestSmaller;
		}
	}
}
