using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class NearestGreaterToLeft
	{
		public static int[] nearestSmallerOnLeft(int[] arr)
		{
			int n = arr.Length;
			int[] nearestGreater = new int[n];
			Stack<int> stck = new Stack<int>();
			int j = 0;

			for(int i = 0; i < n; i++)
			{
				while(stck.Count > 0 && stck.Peek() <= arr[i])
				{
					stck.Pop();
				}
				nearestGreater[j++] = stck.Count == 0 ? -1 : stck.Peek();
				stck.Push(arr[i]);
			}

			return nearestGreater;
		}

		public static int[] nearestGreaterOnLeftBruteForce(int[] arr)
		{
			int n = arr.Length;
			int[] nearestGreater = new int[n];
			int k = 0;
			bool flag = false;

			for(int i = 0; i<n; i++)
			{
				flag = false;
				for(int j = i-1; j >= 0; j--)
				{
					if(arr[i] < arr[j])
					{
						nearestGreater[k++] = arr[j];
						flag = true;
						break;
					}
				}
				if(!flag)
				{
					nearestGreater[k++] = -1;
				}
			}
			return nearestGreater;
		}
	}
}
