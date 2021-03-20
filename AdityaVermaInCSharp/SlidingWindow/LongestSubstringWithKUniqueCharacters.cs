using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class LongestSubstringWithKUniqueCharacters
	{
		public static int longestSubstring(int size, string str, int K)
		{
			int i = 0;
			int j = 0;
			int count = 0;
			int maxLengthOfSubstring = int.MinValue;
			Dictionary<char, int> charMap = new Dictionary<char, int>();

			while(j<size)
			{
				if(charMap.ContainsKey(str[j]))
				{
					charMap[str[j]]++;
				}
				else
				{
					charMap.Add(str[j], 1);
				}
				count = charMap.Count;

				if(count < K)
				{

				}
				else if (count == K)
				{
					maxLengthOfSubstring = Math.Max(maxLengthOfSubstring, j - i + 1);

				}
				else
				{
					while (count > K)
					{
						charMap[str[i]]--;
						if (charMap[str[i]] == 0)
						{
							count--;
							charMap.Remove(str[i]);
						}
						i++;
					}
					if (count == K)
					{
						maxLengthOfSubstring = Math.Max(maxLengthOfSubstring, j - i + 1);
						
					}
				}
				j++;
			}
			return maxLengthOfSubstring;
		}

		//public static int longestWordBruteForce(int size, string str, int K)
		//{ 
			
		//}
	}
}
