using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class LongestSubstringWithNoRepeatingCharacters
	{
		public static int longestSubstring(int size, string str)
		{
			int i = 0;
			int j = 0;
			int k = 0;
			int maxSubstring = 0;
			Dictionary<char, int> charMap = new Dictionary<char, int>();


			while(j < size)
			{
				k = j - i + 1;
				if(charMap.ContainsKey(str[j]))
				{
					charMap[str[j]]++;
				}
				else
				{
					charMap.Add(str[j], 1);
				}
				if(charMap.Count == k)
				{
					maxSubstring = Math.Max(maxSubstring, k);
				}
				else if(charMap.Count < k)
				{
					while(charMap.Count < k)
					{
						if (charMap.ContainsKey(str[i]))
						{
							charMap[str[i]]--;
							if (charMap[str[i]] == 0)
							{
								charMap.Remove(str[i]);
							}
						}
						i++;
						k--;
					}
					if(charMap.Count == k)
					{
						maxSubstring = Math.Max(maxSubstring, k);
					}
				}
				j++;
			}
			return maxSubstring;
		}
		public static int longestSubstringBruteForce(int size, string str)
		{
			int windowSize = 0;
			int left = 0;
			int right = 0;
			int maxSubstring = int.MinValue;

			for(windowSize = 1; windowSize <= size; windowSize++)
			{
				for(left = 0; left < size - windowSize + 1; left++)
				{
					Dictionary<char, int> charMap = new Dictionary<char, int>();
					for (right = left; right < left + windowSize; right++)
					{
						if(charMap.ContainsKey(str[right]))
						{
							charMap[str[right]]++;
						}
						else
						{
							charMap.Add(str[right], 1);
						}
					}
					if(charMap.Count == windowSize)
					{
						maxSubstring = Math.Max(maxSubstring,windowSize);
						break;
					}
				}
			}
			return maxSubstring;
		}
	}
}
