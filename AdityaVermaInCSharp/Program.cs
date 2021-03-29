using AdityaVermaInCSharp.Heaps;
using AdityaVermaInCSharp.SlidingWindow;
using System;
using System.Collections.Generic;

namespace AdityaVermaInCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			//List<int> arr = new List<int>();

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


			//arr.Add(2);
			//arr.Add(5);
			//arr.Add(1);
			//arr.Add(8);
			//arr.Add(2);
			//arr.Add(9);
			//arr.Add(10);

			//int sum = MaximumSumInKSizeWindow.maxSumBruteForce(arr.Count, arr, 3);
			//Console.WriteLine(sum);

			//int count = CountOccurencesOfAnagrams.countOfAnagramsBruteForce("foorxfxorfxdofrmorfxor", "for");
			//Console.WriteLine(count);

			//arr.Add(4);
			//arr.Add(1);
			//arr.Add(1);
			//arr.Add(1);
			//arr.Add(2);
			//arr.Add(3);
			//arr.Add(5);


			//List<string> toys = new List<string>();
			//toys.Add("a");
			//toys.Add("a");
			//toys.Add("b");
			//toys.Add("a");
			//toys.Add("c");
			//toys.Add("b");
			//toys.Add("e");
			//toys.Add("b");
			//toys.Add("e");
			//toys.Add("b");
			//toys.Add("e");

			//List<int> result = new List<int>();
			//string str = "totmtaptat";
			//string tar = "tta";

			//int[] rs = MaximumOfAllSubarraysOfSizeK.maxInWindow(arr.ToArray(), 3);



			//foreach (int i in rs)
			//{
			//	Console.Write(i + " ");
			//}
			//foreach(int r in result)
			//{
			//	Console.Write(r + " ");
			//}

			int[][] arr = new int[4][];
			arr[0] = new int[] { 1, 3 };
			arr[1] = new int[] { -2, 2 };
			arr[2] = new int[] { 5, 8 };
			arr[3] = new int[] { 0, 1 };

			int[] nums = { 1,3,12,5,15,11 };

			int res = SumOfElementsBetweenK1SmallestAndK2Largest.sum(nums,3,6);
			Console.WriteLine(res);
			//foreach (List<int> i in res)
			//{
			//	Console.WriteLine(i[0] + " , " + i[1] + " , " + i[2]);
			//}
			Console.ReadLine();
		}
	}
}
