using AdityaVermaInCSharp.BinarySearch;
using AdityaVermaInCSharp.Heaps;
using AdityaVermaInCSharp.SlidingWindow;
using AdityaVermaInCSharp.Stacks;
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

			//int[][] arr = new int[4][];
			//arr[0] = new int[] { 1, 3 };
			//arr[1] = new int[] { -2, 2 };
			//arr[2] = new int[] { 5, 8 };
			//arr[3] = new int[] { 0, 1 };

			////int[] nums = { 6,2,5,4,5,1,6 };
			//int[][] nums = new int[4][];
			//nums[0] = new int[] { 0,1,1,0 };
			//nums[1] = new int[] { 1,1,1,1 };
			//nums[2] = new int[] { 1,1,1,1 };
			//nums[3] = new int[] { 1,1,0,0 };

			//int res = MaximumAreaRectangleOfBinaryMatrix.maxArea(nums);

			//MinStackNoExtraSpace.Push(18);
			//MinStackNoExtraSpace.Push(19);
			//MinStackNoExtraSpace.Push(29);
			//int res = MinStackNoExtraSpace.Pop();
			//Console.WriteLine(res);
			//MinStackNoExtraSpace.Push(15);
			//MinStackNoExtraSpace.Push(16);
			//res = MinStackNoExtraSpace.Pop();
			//Console.WriteLine(res);
			//res = MinStackNoExtraSpace.Pop();
			//Console.WriteLine(res); 
			//res = MinStackNoExtraSpace.Pop();
			//Console.WriteLine(res);
			//res = MinStackNoExtraSpace.Peek();
			//Console.WriteLine(res);
			//res = MinStackNoExtraSpace.Pop();
			//Console.WriteLine(res);
			//res = MinStackNoExtraSpace.Peek();
			//Console.WriteLine(res);+
			//foreach (int i in res)
			//{
			//	Console.WriteLine(i);
			//}
			int[] nums = { 20, 17, 15,14,13,12,10,9,8,4  };
			int[][] mat = new int[4][];
			mat[0] = new int[] { 10,20,30,40 };
			mat[1] = new int[] { 15,25,35,45 };
			mat[2] = new int[] { 27,29,37,48};
			mat[3] = new int[] { 32, 33, 39, 50};

			int res = BinarySearchDescending.search(nums,10);
			Console.WriteLine(res);
			Console.ReadLine();
		}
	}
}
