using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class SearchInRowWiseAndColumnWiseSortedArray
	{
		public static int[] search(int[][] mat, int k)
		{
			int rows = mat.Length;
			int cols = mat[0].Length;
			int row = 0;
			int col = cols - 1;

			while(row <= rows - 1 && col >= 0)
			{
				if (mat[row][col] == k)
					return new int[] { row, col };
				else if (mat[row][col] > k)
					col--;
				else
					row++;
			}

			return new int[] { row, col };
		}
	}
}
