using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class NearestGreaterToRight
	{
		public static int[] nearestGreaterOnRight(int[] arr)
		{
			int n = arr.Length;
			int j = n - 1;
			int[] nextGreater = new int[n];
			Stack<int> stck = new Stack<int>();

			for(int i = n-1; i>=0; i--)
			{
				while(stck.Count > 0 && stck.Peek() <= arr[i])
				{
					stck.Pop();
				}
				nextGreater[j--] = stck.Count == 0 ? -1 : stck.Peek();

				stck.Push(arr[i]);
			}

			return nextGreater;
		}

		public static int[] nextGreaterBruteForce(int[] arr)
		{
			int[] nextGreater = new int[arr.Length];
			int k = 0;
			bool flag = false;

			for(int i = 0; i< arr.Length; i++)
			{
				flag = false;
				for(int j = i+1; j < arr.Length; j++)
				{
					if(arr[i] < arr[j])
					{
						nextGreater[k++] = arr[j];
						flag = true;
						break;
					}
				}
				if(!flag)
				{
					nextGreater[k++] = -1;
				}
			}

			return nextGreater;
		}
	}
}
