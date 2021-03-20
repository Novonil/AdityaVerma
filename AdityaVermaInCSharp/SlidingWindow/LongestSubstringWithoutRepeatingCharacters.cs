using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class LongestSubstringWithoutRepeatingCharacters
	{
		public static int longestSubstring(int size, string str, int K)
		{
			int i = 0;
			int j = 0;
			Dictionary<char, int> charMap = new Dictionary<char, int>();

			int maxSubstring = 0;
			int count = 0;

			while(j < size)
			{
				if(charMap.ContainsKey(str[j]))
				{
					charMap[str[j]]++;
				}
				else
				{
					charMap.Add(str[j], 1);
				}
				if(j - i + 1 < K)
				{
					j++;
				}
				else if(j - i + 1 == K)
				{
					if(charMap.Count == K)
					{
						maxSubstring = Math.Max(maxSubstring, j - i + 1);
						count++;
					}
					j++;
				}
				else
				{
					if(charMap.ContainsKey(str[i]))
					{
						charMap[str[i]]--;
						if(charMap[str[i]] == 0)
						{
							charMap.Remove(str[i]);
						}
					}
					i++;
				}
			}
			return count;
		}
		public static int longestSubstringBruteForce(int size, string str, int K)
		{
			int count = 0;
			for(int left = 0; left < size - K + 1; left++)
			{
				Dictionary<char, int> charMap = new Dictionary<char, int>(); 
				for(int right = left; right < left + K; right++)
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
				if(charMap.Count == K)
				{
					count++;
				}
			}
			return count;
		}
	}
}
