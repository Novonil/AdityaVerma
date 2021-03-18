using AdityaVermaInCSharp.SlidingWindow;
using System;
using System.Collections.Generic;

namespace AdityaVermaInCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> arr = new List<int>();

			//arr.Add(12);
			//arr.Add(-1);
			//arr.Add(-7);
			//arr.Add(8);
			//arr.Add(-15);
			//arr.Add(30);
			//arr.Add(16);
			//arr.Add(28);

			//List<int> result = FirstNegativeNumberInEveryWindowOfSizeK.findFirstNegative(arr.Count, arr, 3);
			//foreach (int i in result)
			//{
			//	Console.Write(i + " ");
			//}


			arr.Add(2);
			arr.Add(5);
			arr.Add(1);
			arr.Add(8);
			arr.Add(2);
			arr.Add(9);
			arr.Add(10);

			int sum = MaximumSumInKSizeWindow.maxSumBruteForce(arr.Count, arr, 3);
			Console.WriteLine(sum);

			Console.ReadLine();
		}
	}
}
