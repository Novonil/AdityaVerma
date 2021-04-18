using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.BinarySearch
{
	class NextAlphabetElement
	{
		public static char nextAlphabet(char[] alpha, char k)
		{
			int len = alpha.Length;
			int start = 0;
			int end = len - 1;
			int mid;
			char res = '0';
			while(start <=  end)
			{
				mid = start + (end - start) / 2;
				if (alpha[mid] <= k)
					start = mid + 1;
				else
				{
					res = alpha[mid];
					end = mid - 1;
				}
			}
			return res;
		}
	}
}
